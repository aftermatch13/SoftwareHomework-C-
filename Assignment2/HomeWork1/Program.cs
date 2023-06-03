using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            while (true)
            {
                Console.WriteLine("请输入一个整数：");
                int number = int.Parse(Console.ReadLine());
                if (number <= 1)
                {
                    Console.WriteLine("输入整数不能小于1，请重新输入。");
                    continue;
                }
                Console.WriteLine("{0}的素数因子有：", number);
                for (int i = 2; i <= number;)
                {
                    if (number % i == 0)
                    {
                        number = number / i;
                        Console.WriteLine(i);
                    }
                    else
                    {
                        i++;
                    }
                    
            }
                break;
            }
        }
    }
}
