//Write a program to find sum of all digits in given number
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assginment_23_2_22
{
   class sum
    {
        int num,rem,Sum;
        public void prgm()
        {
            Console.WriteLine("Enter the number");
            num=int.Parse(Console.ReadLine());
            Console.Clear();
            int no = num;
            while(num>0)
            {
                rem=num%10;
                num = num / 10;
                Sum += rem;

            }
            Console.WriteLine("sum of "+no+" is " + Sum);
        
        }
    }
}
