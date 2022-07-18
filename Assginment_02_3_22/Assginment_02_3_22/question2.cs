//Write a program which will demonstrate constructor overloading. Use default, paratermised and copy constructor.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assginment_02_3_22
{
    class question2
    {
        int a, b;

        public question2() { } //defult
        public question2(int x,int y) //parameterized
        {
            
            a = x;
            b = y;
            Console.WriteLine("value of x = " + a);
            Console.WriteLine("Value of y = " + b);


        }

        public question2(question2 cpy) //copy
        {
            a = cpy.a;
            b = cpy.b;
            Console.WriteLine("Copy constructor has been called");
            Console.WriteLine("value of x = " + cpy.a);
            Console.WriteLine("Value of y = " + cpy.b);

        }
        



    }
}
