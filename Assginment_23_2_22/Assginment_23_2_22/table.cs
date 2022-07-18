//Write a program to find table of given number.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assginment_23_2_22
{
    class table
    {
        
        int mul=0;
        public void multiplication()
        {
            Console.WriteLine("enter which number of table you want to print");
            int a=int.Parse(Console.ReadLine());
            Console.Clear();
            for (byte b=1;b<=10;b++)
            {
                mul = a*b;
                
                Console.WriteLine(a+" x "+b+" = "+mul);
                Thread.Sleep(400);
            }

        }

    }

}
