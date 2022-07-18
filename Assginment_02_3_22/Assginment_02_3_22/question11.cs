//Demonstrate the difference between abstract class and interface
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assginment_02_3_22
{
    abstract class question11:I1,I2
    {
        string na, city;
        int dd, mm, yy;
        int td;
        int d,tm;
        int f;

        public question11()
        {
            td = 2022;
            tm = 3;

        }
        public void get()
        {
            Console.Write("\n~~~~~User Enter your deatils~~~~~~");
            Console.Write("\nEnter Name : ");
            na=Console.ReadLine();
            Console.Write("\nEnter City : ");
            city=Console.ReadLine();
            Console.Write("\nEnter your age(dd/mm/yy) : ");
            
            
                dd = int.Parse(Console.ReadLine());
                mm = int.Parse(Console.ReadLine());
                yy = int.Parse(Console.ReadLine());
        }
            
       
        public void func()
        {
        
        if (dd < 30 && dd > 0 && yy > 1900 && yy < 2022 && mm > 0 && mm < 12)
        {
            d = td - yy;


            f = 1;
        }
        else
            {

                Console.WriteLine("Invalid date");

                f = 2;

            }
            

        }

        public void show()
        {
            Console.WriteLine("Hi  Mr/Ms " + na+".....");

            if(f == 1)
            Console.WriteLine("You Are Almost "+d);


        }
    }

    interface I1
    {
       public void func();

    }

    interface I2
    {
        public void show();
    }




     class Temp : question11
    {
        
    }
}
