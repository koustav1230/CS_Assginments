//Write a program to print all prime numbers between given two intervals
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assginment_23_2_22
{
    class prime
    {
        int num,num2,i,j;
        public void prgm()
        {

            Console.WriteLine("Enter The Starting Point");
            num=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Ending Point");
            num2= int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Prime Number between " + num + " To " + num2 + " are ");
            for (i=num;i<num2;i++)
            {
                for(j=2;j<i;j++)
                {
                    if(i%j==0)
                    {
                        break;
                    }
                }
                if(i==j)
                Console.Write(i+" ");
            }

            


        }

    }
}
