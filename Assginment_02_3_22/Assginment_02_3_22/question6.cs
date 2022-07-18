//Write a C# program which will demonstrate the single inheritance. Take base class as Bird
//and child class as parrot. Write and inherit the appropriate methods.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assginment_02_3_22
{
    class bird
    {
        public void b()
        {
            Console.Clear();
            Console.WriteLine("_Basic traits_");
            Console.WriteLine("It can fly");
            Console.WriteLine("It has two legs");
            Console.WriteLine("It has two wings");  

        }

    }

    class parrot:bird
    {
       public void p()
        {
            
            Console.WriteLine("Bird Name : Parrot");
            Console.WriteLine("It has a green body");
            Console.WriteLine("It has red beak");

        }

    }

    class ealge:bird
    {
        public void e()
        {
            
            Console.WriteLine("Bird Name : Eagle");
            Console.WriteLine("It is called king of the birds");
            Console.WriteLine("It has a keen eyeshight");
            Console.WriteLine("It has very sharp beak");

        }

    }

    class kingfisher:bird
    {
        public void k()
        {
            
            Console.WriteLine("Bird Name : Kingfisher");
            Console.WriteLine("It hunts fish");
            Console.WriteLine("It has a multicolor body");
            Console.WriteLine("It has a long beak");

        }
    }
}
