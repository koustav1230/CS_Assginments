//Write a program to find all factors of given number. 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assginment_23_2_22
{
    class fact
    {
       
        public void Fact()
        {
            Console.WriteLine("Enter the number");
            int num=int .Parse(Console.ReadLine());
            Console.WriteLine("all factors of " + num);
            for(int i=1;i<=num;i++)
            {
                if(num%i==0)
                {
                    Console.Write(i+"\t");
                }
                
            }
            
        }

    }
}
