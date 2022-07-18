//Write a program to add one extended method to ArrayList class.
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assginment_02_3_22
{
    static class question19
    {
        //static string pname;
        //static int ;
        static int it;
        public static void demo(this int o)
        {
            Console.Write("How Many Items You Want To add : ");
            it=int.Parse(Console.ReadLine());
            
            int[] price = new int[it];
            string [] pname = new string[it];

            for (int i = 0; i < it; i++)
            {
                Console.Write("\nEnter Your Details : ");
                Console.Write("\nEnter The Product name :");
                pname[i] = Console.ReadLine();

                Console.Write("\nEnter The Product Price : ");
                price[i] = int.Parse(Console.ReadLine());
            }


            ArrayList obj = new ArrayList();
            for (int i = 0; i < it; i++)
            {
                obj.Add(pname[i]);
                obj.Add(price[i]);
            }
            Console.Clear();
            //Console.Write("name :");
            //for(int i = 0; i < it; i++)
            //Console.Write("Name\t\tprice");

            foreach (var i in obj)
            {
                
                Console.Write(i+"\t\t");
                
            }

        }
            
            

        
    }
}
