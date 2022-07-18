//Write a C# program to print all perfect numbers within given range
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assginment_28_2_22
{
    class question5
    {
        int s, e;
        int sum;
        public void prgm()
        {
            Console.Write("Enter the starting point: ");
            s = int.Parse(Console.ReadLine());
            Console.Write("Enter the end point: ");
            e = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Perfect numbers between " + s + " and " + e + " are");
            for (int i = s; i <= e; i++)
            {
                sum = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        sum = sum + j;


                    }
                }

                if (sum == i)
                {
                    Console.Write(i + " ");
                }

            }

        }

    }
}
