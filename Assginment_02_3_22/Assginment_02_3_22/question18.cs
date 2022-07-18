using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assginment_02_3_22
{
    static class question18
    {
        static Int32 a;
        static Int32 b;
        static Int32 c;
        static Int32 temp;
        public static void max_x(this Int32 m)
        {

            Console.Write("Enter The Value of a : ");
            a=Int32.Parse(Console.ReadLine());
            Console.Clear();

            Console.Write("Enter The Value of a : ");
            b=Int32.Parse(Console.ReadLine());
            Console.Clear();

            Console.Write("Enter The Value of a : ");
            c=Int32.Parse(Console.ReadLine());
            Console.Clear();


            temp = (a > b && a > c) ? (a) : (b > c) ? (b) : (c);
            Console.Clear();
            Console.WriteLine("THE MAX NUM BWTWEEN {0},{1} and {2} is {3}",a,b,c,temp);


        }

    }
}
