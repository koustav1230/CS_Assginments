//Input a square matrix and find the sum of diagonal elements
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assginment_28_2_22
{
    internal class question13
    {
        int r, c;
        int i, j, temp = 0;
        int[,] arr = new int[5, 5];
        int[,] arr2 = new int[5, 5];

        public void prgm()
        {
            Console.Write("Enter the Row size : ");
            r = int.Parse(Console.ReadLine());

            Console.Write("Enter the Column size : ");
            c = int.Parse(Console.ReadLine());



            for (i = 0; i < r; i++)
            {
                for (j = 0; j < c; j++)
                {
                    Console.Write("element - [{0}],[{1}] : ", i, j);
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }


            Console.WriteLine("Diplaying Matrix");

            for (i = 0; i < r; i++)
            {
                Console.Write("|    ");

                for (j = 0; j < c; j++)
                {
                    Console.Write(arr[i, j] + "    ");
                    Thread.Sleep(500);
                    if (i == j)
                    {
                        temp = temp + arr[i, j];
                    }

                }
                Console.Write("|");
                Console.Write("\n");
            }


            Console.WriteLine("sum of diagonal elements is : " + temp);

        }
    }
}
