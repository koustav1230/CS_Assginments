//Input one matrix and print its transpose.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assginment_28_2_22
{
    class question12
    {

        int r, c;
        int i, j;
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

            Console.Clear();
            Console.WriteLine(" :Original matrix:");
            for (i = 0; i < r; i++)
            {
                for (j = 0; j < c; j++)
                {
                    Console.Write(arr[i, j] + "\t");

                }
                Console.Write("\n");
            }


            for (i = 0; i < r; i++)
            {
                for (j = 0; j < c; j++)
                {
                    arr2[j, i] = arr[i, j];

                }
            }


            Console.WriteLine(" :After transpose:");

            for (i = 0; i < c; i++)
            {
                Console.Write("|    ");

                for (j = 0; j < r; j++)
                {
                    Console.Write(arr2[i, j] + "    ");
                    Thread.Sleep(500);

                }
                Console.Write("|");
                Console.Write("\n");
            }


        }
    }
}
