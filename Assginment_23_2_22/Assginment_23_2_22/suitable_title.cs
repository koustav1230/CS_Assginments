//Write a program to assign suitable title (Miss, Mrs, Mr) to person. Take input one’s gender and marital status if required.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assginment_23_2_22
{

    class title
    {
        string name,gen,mstatus;
        byte age;
        public void getdetails()
        {
        
            Console.WriteLine("Enter your name : ");
            name = Console.ReadLine();
            
            Console.WriteLine("Enter you age : ");
            age = byte.Parse(Console.ReadLine());

            Console.WriteLine("Eter your Gender : ");
            gen = Console.ReadLine();

            
            //Console.Clear();

        }

        public void showdetails()
        {
            
            if(gen == "female" || gen == "male")
            {
                if (gen == "female")
                {
                    Console.WriteLine("Enter you marital status");
                    mstatus = Console.ReadLine();
                    Console.Clear();
                }
                Console.Clear();
                if (gen == "female" && mstatus == "married")
                    Console.WriteLine("Name : Mrs " + name);
                else if (gen == "female" && mstatus == "single")
                    Console.WriteLine("Name : Miss " + name);
                else if (gen == "male")
                    Console.WriteLine("Name : Mr " + name);
                else
                    Console.WriteLine("Invalid Entry");
            }

            if (age <= 100 || age >= 0)
            {
                Console.WriteLine("Age : " + age);
            }
            else
            {
                Console.WriteLine("Invalid Entry");
            }

            Console.WriteLine("Gender : "+gen);
          

        }

    }

   
}
