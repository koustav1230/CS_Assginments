//Write a program in C# to search given element in array
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assginment_28_2_22
{
    class question11
    {

        int s, co = 1, find;
        int i, temp;
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
            Console.Write("Enter the ELement you want to search: ");
            find = int.Parse(Console.ReadLine());

            Console.Clear();
            bool flag=false;

            for (i = 0; i < s; i++)
            {
                temp++;
                if (arr[i] == find)
                {
                    int temp2 = temp - 1;
                    Console.WriteLine("Element Has been Found!!");
                    Console.WriteLine("POSITION = " + temp);
                    Console.WriteLine("INDEX = " + temp2);
                    flag = true;
                    break;

                }

               
                


            }
            if(!flag)
            {
                {
                    Console.WriteLine("OOPS NO MATCHING ELEMENT...");

                }
                Console.WriteLine("The Elements Were ");

                for (i = 0; i < s; i++)
                {
                    Console.Write("[" + arr[i] + "]");
                    Thread.Sleep(500);
                }
            }




        }

    }

}
