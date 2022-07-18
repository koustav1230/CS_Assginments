//Write a program in C# to sort the given array in descending order
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assginment_28_2_22
{
    class question10
    {
        int s, co = 1;
        int i, j, temp = 0;
        int[] arr = new int[10];

        public void prgm()
        {
            Console.Write("Enter the array size : ");
            s = int.Parse(Console.ReadLine());




            for (i = 0; i < s; i++)
            {
                Console.Write("Enter the array element [" + co++ + "] : ");
                arr[i] = int.Parse(Console.ReadLine());

            }
            Console.Clear();
            Console.Write("Displaying Original");
            for (i = 0; i < 4; i++)
            {
                Thread.Sleep(100);
                Console.Write(".");
            }
            Console.Write("\n");

            for (i = 0; i < s; i++)
            {


                Console.Write("[" + arr[i] + "]");
                Thread.Sleep(500);
            }

            for (i = 0; i < s - 1; i++)
            {
                for (j = 0; j < s - i - 1; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            Console.Write("\n");
            Console.Write("Sorting");
            for (i = 0; i < 4; i++)
            {
                Thread.Sleep(100);
                Console.Write(".");
            }
            Console.Write("\n");

            for (i = 0; i < s; i++)
            {
                Console.Write("[" + arr[i] + "]");
                Thread.Sleep(500);
            }

        }
    }
}
