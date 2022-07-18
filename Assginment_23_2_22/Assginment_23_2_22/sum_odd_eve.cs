//Write a program to calculate sum of all even numbers up to given number.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assginment_23_2_22
{
     class sumeve
    {
        int num,oddsum,evesum;

        public void get()
        {
            Console.WriteLine("Enter the number");
            num=int.Parse(Console.ReadLine());

            for(int i = 1; i <= num; i++)
            {
                if(i%2==0)
                {
                    evesum += i;
                    Console.WriteLine("even numbers: "+i);
                }
                else
                {
                    oddsum += i;
                    Console.WriteLine("odd numbers : "+i);
                }
            }

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~");
            if (evesum != 0)
                Console.WriteLine("sum of the even numbers " + evesum);
            if (oddsum != 0)
                Console.WriteLine("sum of the odd numbers " + oddsum);
        }
    }
}
