using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assginment_23_2_22
{
     class greater
    {
        double n1, n2, n3;
        public void cal()
        {

            Console.WriteLine("Emter three numbers");
            n1=double.Parse(Console.ReadLine());
            n2=double.Parse(Console.ReadLine());
            n3 = double.Parse(Console.ReadLine());
            Console.Clear();
            if (n1 >= n2 && n1 >= n3)
            {
                Console.WriteLine(n1+" is greater");

            }
            else if(n2 >= n1 && n2 >= n3)
            {
                Console.WriteLine(n2 + " is greater");
            }
            else if (n3 >= n1 && n3 >= n2)
            {
                Console.WriteLine(n3 + " is greater");
            }
        }
    }
}
