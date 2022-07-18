//Find the greater between given 3 numbers using ternary operator
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assginment_28_2_22
{
    class question2
    {
        int a, b, c, res;
        public void prgm()
        {

            Console.WriteLine("Enter the three Numbers");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());

            res = (a > b && a > c) ? (a) : (b > c) ? (b) : (c);
            Console.WriteLine("The Greater Nuber Bewteen " + a + " " + b + " " + c + " is :");
            Console.WriteLine(res);

        }
    }
}
