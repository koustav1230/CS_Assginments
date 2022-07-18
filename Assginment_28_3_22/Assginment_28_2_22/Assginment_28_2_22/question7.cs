//Write a program in C# to read n number of values in an array and display it in reverse order
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assginment_28_2_22
{
    class question7
    {
        byte s, co = 1;
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
            Console.WriteLine("Entered array elemensts");
            foreach (int item in arr)
            {
                Console.Write("[" + item + "]" + "\t");
            }

            Console.WriteLine("\nReverese array elemensts");
            for (int i = s - 1; i >= 0; i--)
            {
                Console.Write("[" + arr[i] + "]" + "\t");
            }



        }
    }
}
