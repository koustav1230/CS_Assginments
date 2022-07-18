//Write a program in C# to find the sum and average of all elements of the array.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assginment_28_2_22
{
    class question8
    {

        byte s, co = 1;
        int sum = 0, avg;
        public void prgm()
        {
            Console.Write("Enter the array size : ");
            s = byte.Parse(Console.ReadLine());
            int[] arr = new int[s];


            for (int i = 0; i < s; i++)
            {
                Console.Write("Enter the array element [" + co++ + "] : ");
                arr[i] = int.Parse(Console.ReadLine());


            }

            Console.Clear();
            Console.WriteLine("  Sum && Average:");
            for (int i = 0; i < s; i++)
            {
                sum += arr[i];
                Console.Write(" + [" + arr[i] + "]");
                Thread.Sleep(500);
            }
            avg = sum / arr.Length;

            Console.Write(" = " + "[" + sum + "]" + " && [" + avg + "]");



        }
    }
}
