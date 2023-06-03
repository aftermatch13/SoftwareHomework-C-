using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleCrawler
{
	class MyCrawler
	{
		private Hashtable urls = new Hashtable();
		private int count = 0;
		private string[] suffixes = { ".htm", ".html", ".aspx", ".php", ".jsp" };

		public delegate void WriteLineHandler(string? value);
		public static event WriteLineHandler WriteLine;

		public static void MyCrawlerMain(params string[] args)
		{
			MyCrawler myCrawler = new();
			string startUrl = "http://www.cnblogs.com/dstang2000/";
			if (args.Length >= 1) startUrl = args[0];
			myCrawler.urls.Add(startUrl, false); // 加入初始页面
			new Thread(myCrawler.Crawl).Start();
		}

		private void Crawl()
		{
			WriteLine("开始爬行了....");
			while (true)
			{
				string? current = null;
				foreach (string url in urls.Keys)
				{
					if (urls[url] != null && (bool)urls[url]!) continue;
					current = url;
				}

				if (current == null || count > 10) break;
				WriteLine("爬行" + current + "页面!");
				string html = Download(current); // 下载
				foreach(string suffix in suffixes)
				{
					if (current.EndsWith(suffix))
					{
						Parse(current, html); // 解析, 并加入新的链接
						break;
					}
				}
				WriteLine("爬行结束");
			}
		}

		public string Download(string url)
		{
			try
			{
				WebClient webClient = new() { Encoding = Encoding.UTF8 };
				string html = webClient.DownloadString(url);
				string fileName = count.ToString();
				File.WriteAllText(fileName, html, Encoding.UTF8);
				urls[url] = true;
				count++;
				return html;
			}
			catch (Exception ex)
			{
				urls[url] = false;
				WriteLine(ex.Message);
				return "";
			}
		}

		private void Parse(string url, string html)
		{
			string strRef = @"(href|HREF)[]*=[]*[""'][^""'#>]+[""']";
			MatchCollection matches = new Regex(strRef).Matches(html);
			foreach (Match match in matches)
			{
				strRef = match.Value[(match.Value.IndexOf('=') + 1)..]
						.Trim('"', '\'', '#', '>');
				if (strRef.Length == 0) continue;
				if (strRef.StartsWith("/"))
				{
					string domain = "/";
					string pattern = @"http(s)?://(([\w-]+\.)+\w+(:\d{1,5})?)";
					Match match1 = Regex.Match(strRef, pattern);
					if (match1.Success)
					{
						domain = match1.Groups[2].Value;
					}
					strRef = domain + strRef;
				}
				else if (strRef.StartsWith(".") || strRef.StartsWith(".."))
				{
					if (!url.EndsWith("/"))
					{
						url += "/";
					}
					strRef = url + strRef;
				}
				if (urls[strRef] == null) urls[strRef] = false;
			}
		}
	}
}
