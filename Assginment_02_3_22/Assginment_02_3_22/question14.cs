//Demonstrate the difference between var, object and dynamic data types with suitable example
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assginment_02_3_22
{
    internal class question14
    {

        public void prgrm()
        {

            var a = "\t\t\t\t: Enter Any Data Type [] to Concatinate : ";

            for(int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i]);
                Thread.Sleep(100);
            }
            Console.Write("\n\t\t\t\tEnter the size of the array : ");
            var size=int.Parse(Console.ReadLine());
            
            dynamic sum=null;


            object[] b = new object[size];

            for (int i = 0; i < size; i++)
            {
                b[i] =(Console.ReadLine());
            }
            Console.Clear();    
            for (int i = 0; i < size; i++)
            {
                
                Console.Write(b[i] + " + ");
                sum=sum+b[i];
                
            }
            Console.WriteLine("= Concate : "+sum);


        }

        public void gpm()
        {

            var a = "\t\t\t\t: Enter [] to Add : ";

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i]);
                Thread.Sleep(100);
            }
            Console.Write("\n\t\t\t\tEnter the size of the array : ");
            var size = int.Parse(Console.ReadLine());

            dynamic sum = 0;


            dynamic[] b = new dynamic[size];

            for (int i = 0; i < size; i++)
            {
                b[i] = int.Parse(Console.ReadLine());
            }
            Console.Clear();
            for (int i = 0; i < size; i++)
            {

                Console.Write(b[i] + " + ");
                sum = sum + b[i];

            }
            Console.WriteLine("= Add : " + sum);


        }



    }
}
