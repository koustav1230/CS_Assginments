//Write a program to print all Armstrong numbers between given two intervals
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assginment_23_2_22
{
    internal class armstrong_interval
    {
        int num,num2,i,temp,temp2,rem;
        int count;
        double sum;

        public void prgm()
        {
            Console.WriteLine("Enter the starting point number");
            num=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the end point");
            num2=int.Parse(Console.ReadLine());

            Console.WriteLine("All armstrong numbers between "+num+" and "+num2+" are:");
            for(i=num;i<num2;i++)
            {
                temp = i;
                temp2 = i;

                while(temp!=0)
                {
                    temp = temp / 10;
                    count++;
                }
                while(temp2!=0)
                {
                    rem= temp2 % 10;
                    sum+=Math.Pow(rem,count);
                    temp2= temp2 / 10;
                    
                }
                
                if (sum==i)
                {
                    Console.Write(i+"\t");
                }
                count = 0;
                sum = 0;    
            }

        }
    }
}
