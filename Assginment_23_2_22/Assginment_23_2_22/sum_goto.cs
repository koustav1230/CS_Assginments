//Write a program to find sum of 1 to n numbers using goto statement.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assginment_23_2_22
{
    class sum_goto
    {
        int n;
        int st = 1;
        int sum=0;
        public void get()
        {

            Console.WriteLine("Enter the value of N ");
            n = int.Parse(Console.ReadLine());

        }
        public void show()
        {
        lbl:
            if (st <= n)
            {
                sum += st;
                st++;
                goto lbl;
            }
            Console.WriteLine("sum of 1 to "+n+" is = "+sum);
        }

    }
}
