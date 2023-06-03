using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Judgment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[3,4] { { 1, 2, 3, 4 }, { 5, 1, 2, 3 }, { 9, 5, 1, 2 } };
            Myclass c = new Myclass();
            bool b = c.IsT(a);
            Console.WriteLine(b);
        }
       
    }
    class Myclass
    {
        public bool IsT(int[,] matrix)
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    if (row > 0 && col > 0 && matrix[row,col] != matrix[row - 1,col - 1])
                    {
                        return false;
                    }
                }

            }
            return true;

        }
        

    }
}
