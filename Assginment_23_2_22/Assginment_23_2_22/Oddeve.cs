using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program to check given number is even or odd.
namespace Assginment_23_2_22
{
    class Oddeve
    {
        int num;
        public void getnum()
        {
            Console.WriteLine("Enter the number to check if its a even or odd");
            num = int.Parse(Console.ReadLine());
        }

        public void numcal()
        {
            if (num >= 0)
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine(num + " is a even number");
                }
                else
                {
                    Console.WriteLine(num + " is a odd number");
                }
            }
            else
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine(num + " is a even negative number");
                }
                else
                {
                    Console.WriteLine(num + " is a odd negative number");
                }

            }
                
        
        }
    }

}

