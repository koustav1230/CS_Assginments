//Write a program to print Fibonacci series up to n number of terms.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assginment_23_2_22
{
     class fibbonaci
    {
        int n,num1,num2,sum=0;
        public void fibo()
        {
            Console.WriteLine("Enter the number of term");
            n=int.Parse(Console.ReadLine());

            num1 = 0;
            num2 = 1;
            for (byte i = 1; i <= n; i++)
            {
                Console.Write(sum+"\t");
                num1 = num2;
                num2 = sum;
                sum = num1 + num2;
   
            }

        }

    }
}
