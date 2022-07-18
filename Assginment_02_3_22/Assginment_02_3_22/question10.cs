//Declare a class name ‘A’ with some methods and one parameterised constructor. Derive another class ‘B’ from ‘class A’.
//In class B have some methods and constructor. Demonstrate how base class
//parameterised constructor gets call from child class constructor.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assginment_02_3_22
{
    class A
    {
        
        int geti;
      
        public A()
        {
           
        }
        public A(int a)
        {
            geti = a;
            Console.Clear();
            Console.Write("\nNumber of cars : " + geti);


        }

        public void show()
        {
            string k = "Loading Please Wait.............";
            for (int i = 0; i < k.Length; i++)
            {
                Console.Write(k[i]);
                Thread.Sleep(100);
            }


        }

    }

    class B : A
    {
        int data;
        string[] n =new string[10];
        string[] col = new string[10];    
        float[] m=new float[10];
        static int k;
        static int o;
        string[] mno = new string[10];
        int[] cc = new int[10];
        int[] year = new int[100];


        public B(int st)
        {
            data = st;


        }
       
        public  void getb()
        {
            for (int i = 0; i < data; i++)
            {
                
                k++;
                Console.Write("\nEnter the brand name(model - "+k+") : ");
                n[i] = Console.ReadLine();
                Console.Write("\nEnter The Mileage : ");
                m[i] = float.Parse(Console.ReadLine());
                Console.Write("\nEnter The Color : ");
                col[i] = Console.ReadLine();


                Console.Write("Enter The Model Number Car( " + k + "): ");
                mno[i] = Console.ReadLine();

                Console.Write("\nEnter The Price : ");
                cc[i] = int.Parse(Console.ReadLine());
                Console.Write("\nEnter Launch Year : ");
                year[i] = int.Parse(Console.ReadLine());


            }



        }

        
        public void showb()
        {
           
            for(int i =0; i<data; i++)
            {
                o++;
                string txt="Car Is Loading.........";
                
                
               
                Console.WriteLine();
                Console.Write(o + " . ");
                for (int j = 0; j < txt.Length; j++)
                {
                    Console.Write(txt[j]);
                    Thread.Sleep(100);
                }

                Console.WriteLine("\nBrand Name : "+n[i]);
                Console.WriteLine("Mileage : "+m[i]);
                Console.WriteLine("Model Color : "+col[i]);

                Console.Write("\nModel Numbver : " + mno[i]);
                Console.Write("\nModel Price : " + cc[i]);
                Console.Write("\nLaunch Year: " + year[i]);
                Console.WriteLine();
            }
            
        }


    }
}
