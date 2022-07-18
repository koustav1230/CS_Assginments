//Write a program to reverse the given number.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assginment_23_2_22
{
    class rev_num
    {
        int num, rev=0, rem=0;
        public void showrev()
        {
            Console.WriteLine("Enter a number you want to reverse");
            num=int.Parse(Console.ReadLine());
           
            while(num!=0)
            {
                rem = num % 10;
                rev = rev*10+rem;
                num = num / 10;

            }

            Console.WriteLine("Reverse of the integer is: " + rev);
        }

    }
}
