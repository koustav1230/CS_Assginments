//Write a C# program to demonstrate multilevel inheritance. Base class – bird,
//middle class – flying birds, child class – any bird. Use appropriate
//methods in related class.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assginment_02_3_22
{
    class Bird
    {
        string b="Base Class Called";
     
        
        public void brd()
        {
            Console.Clear();
            for(int i=0;i<b.Length;i++)
            {
                Console.Write(b[i]);
                Thread.Sleep(100);
            }
            Console.WriteLine("\n\n_Basic traits_");
            Console.WriteLine("It has two legs");
            Console.WriteLine("It has two wings\n");
        }

    }
    class Flyingbirds:Bird
    {
        string c = "Mid Class called";
        public void fb()
        {
            for (int i = 0; i < c.Length; i++)
            {
                Console.Write(c[i]);
                Thread.Sleep(100);
            }
            Console.WriteLine("\n\nIt can fly\n");
        }
    }

    class Eagle:Flyingbirds
    {
        string d = "Child Class Called";
        public void eg()
        {
            for (int i = 0; i < d.Length; i++)
            {
                Console.Write(d[i]);
                Thread.Sleep(100);
            }
            Console.WriteLine("\n\nBird Name : Eagle");
            Console.WriteLine("It is called king of the birds");
            Console.WriteLine("It has a keen eyeshight");
            Console.WriteLine("It has very sharp beak");
        }
    }




}
