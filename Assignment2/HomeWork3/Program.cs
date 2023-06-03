using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int[] number = new int[101];
            for (int i = 2; i <= 100; i++)
            {               //从第一个素数2开始筛选
                if (number[i] == 0)
                {                          //如果是素数则剔除掉它的倍数
                    for (int j = i * i; j <= 100; j += i)
                    {          
                        number[j] = 1;
                    }
                }
            }
            Console.WriteLine("2~100之间的素数为：");
            for (int i = 2; i <= 100; i++)
            {
                if (number[i] == 0)
                {
                   Console.WriteLine(i);    

                }
            }

        }
    }
}
