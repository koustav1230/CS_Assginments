//Write a c# program to convert given number in word form . (147 : one hundred forty seven)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assginment_28_2_22
{
    class question1
    {
        int num, temp;
        string[] a = new string[9] { "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
        string[] b = new string[9] { "Eleven", "Twelve", "Thirrteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
        string[] c = new string[9] { "Ten", "Twenty", "Thirty", "Fourty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

        public void prgm()
        {

            Console.WriteLine("Enter the number");
            num = int.Parse(Console.ReadLine());
            Console.Clear();
            int n = num;
            Console.Write(n + " = ");

            if (num < 9999)
            {
                if (num > 1000)
                {
                    temp = num / 1000;
                    num = num % 1000;
                    Console.Write(a[temp - 1] + " Thousand");

                }
                if (num > 100)
                {
                    temp = num / 100;
                    num = num % 100;

                    
                    Console.Write(" " + a[temp - 1] + " Hundred And ");
                }
                if (num >= 10 && num < 20)
                {
                    temp = num % 10;
                    Console.Write(" " + b[temp - 1]);

                }

                if (num > 19 && num <= 100)
                {
                    temp = num / 10;
                    num = num % 10;

                    Console.Write(""+c[temp - 1]);

                }
                if (num < 10)
                {
                    Console.Write(" " + a[num-1]+".");
                }

            }
            else
            {
                Console.WriteLine("Invalid!!");
            }


        }

    }
}
