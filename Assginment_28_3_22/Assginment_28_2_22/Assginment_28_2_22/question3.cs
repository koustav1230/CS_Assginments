//Write a C# program to convert decimal number to binary
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assginment_28_2_22
{
    class question3
    {
        int num, i;
        int[] a = new int[10];

        public void prgm()
        {

            Console.WriteLine("Enter the number you want convert");
            num = int.Parse(Console.ReadLine());
            byte temp = (byte)num;


            for (i = 0; num > 0; i++)
            {
                a[i] = num % 2;
                num /= 2;
            }

            Console.Clear();
            Console.WriteLine("The Binary of " + temp + " is :");
            for (i = i - 1; i >= 0; i--)
            {
                Console.Write(a[i]);
            }


        }

    }
}
