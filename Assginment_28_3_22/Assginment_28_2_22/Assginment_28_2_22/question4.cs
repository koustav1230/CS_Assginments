//Write a C# program to check whether given number is perfect or not
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assginment_28_2_22
{
    internal class question4
    {
        int num, sum = 0, temp;
        public void pgrm()
        {
            Console.WriteLine("Enter the number you want to check");
            num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    sum += i;
                    temp = sum - num;

                }

            }
            temp = sum - num;
            Console.WriteLine(temp);
            Console.Clear();
            if (temp == num)
            {
                Console.WriteLine(num + " is a Perfect number");
            }
            else
            {
                Console.WriteLine(num + " is not a Perfect number");
            }
        }
    }
}
