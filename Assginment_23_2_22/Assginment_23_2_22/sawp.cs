//Write a program to swap given two numbers.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assginment_23_2_22
{
    class swap 
    {
        int x;
        int y;
        public void get()
    {
        Console.WriteLine("Enter 2 number you wnat to sawp");
        x = int.Parse(Console.ReadLine());
        y = int.Parse(Console.ReadLine());

    }

    public int cal(int a, int b)
    {
        int temp;

        temp = a;
        a = b;
        b = temp;
        Console.WriteLine("x =" + a);
        Console.WriteLine("y =" + b);
        return 0;
    }

    public void show()
    {
        Console.Clear();
        Console.WriteLine("Before sawping");
        Console.WriteLine("x =" + x);
        Console.WriteLine("y =" + y);

        Console.WriteLine("after spawping");
        cal(x, y);
    }

}
}
