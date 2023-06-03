using SimpleCrawler;

namespace Assignment7
{
	public partial class FormMain : Form
	{
		public FormMain()
		{
			InitializeComponent();
			MyCrawler.WriteLine += WriteLine;
		}

		private void btnStart_Click(object sender, EventArgs e)
		{
			string url = txtUrl.Text.Trim();
			if (string.IsNullOrEmpty(url))
			{
				MyCrawler.MyCrawlerMain();
			}
			else
			{
				MyCrawler.MyCrawlerMain(url);
			}
		}

		void WriteLine(string? value)
		{
			if (value == null) return;
			txtLog.Text += value + '\n';
		}
	}
}