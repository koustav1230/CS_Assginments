//Write a program to find given number is Armstrong or not.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assginment_23_2_22
{
     class Armstrong
    {
        
        int num,i = 0;
        int Count = 0;
        int[] arr = new int[10];
        double sum = 0;
        public void cal()
        {
            Console.WriteLine("Enter the number");
            num=int.Parse(Console.ReadLine());
            int no = num;
            while(num>0)
            {
                arr[i++]=num%10;
                num = num / 10;
                Count++;
            }
            for (i = 0; i < Count; i++)
            {
                sum += Math.Pow(arr[i], Count);
            }
            if (no==sum)
            {
                Console.WriteLine(no + " is an armstrong");
            }
            else
            {
                Console.WriteLine(no + (" is not an armstromg"));
            }

        }
    
    }
}
