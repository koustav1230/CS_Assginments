//Take Account as abstract class. Make saving a/c and current a/c as its child.
//Make hierarchical inheritance between them
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assginment_02_3_22
{
    abstract class account
    {
        int p;
        int q;
        public void details()
        {
            while (p == q)
            {
                if (true)
                {
                    try
                    {

                        Console.Write("\t\t\t\tEnter PIN: ");
                        p = int.Parse(Console.ReadLine());


                    }
                    catch (Exception)
                    {
                        Console.WriteLine("\t\t\t\tInvaild PIN........");


                    }


                }

            }


            Console.Clear();
            Console.Write("\t\t\t\tNAME : ");
            string na = Console.ReadLine();


            Console.Write("\t\t\t\tAccout Number : ");
            int an = int.Parse(Console.ReadLine());
       
            

            Console.Write("\t\t\t\tBrunch Name : ");
            string bna = Console.ReadLine();

        }
    }

        class current : account
        {

        float bal;
        public void baldis()
        {
            string txt2 = "\t\t\t\tTotal Balance : ";
            Console.Clear();
            for(int i = 0; i < txt2.Length; i++)
            {
                Console.Write(txt2[i]);
                Thread.Sleep(100);
            }
            Console.Write(""+bal);


        }

        public void dipo()
        {
            string text = "\t\t\t\tNew Balance has been updated........";
            Console.Write("\t\t\t\tDiposit ammount: ");
            float dip =float.Parse(Console.ReadLine());
            bal = bal + dip;
            Console.Clear();
            for (int i = 0; i < text.Length; i++)
            {
                Console.Write(text[i]);
                Thread.Sleep(100);
            }
        }

        public void wtdr()
        {
            string text = "\t\t\t\tNew Balance has been updated........";
            string text2 = "\t\t\t\tYour balance is 0 you cant withdraw sir/mam.......";
            Console.Write("\t\t\t\tWithdraw Ammout : ");
            float wit = float.Parse(Console.ReadLine());

            if (bal > 1000)
            {
                
                bal -= wit;
                Console.Clear();   
               for(int i = 0; i <text.Length; i++)
                {
                    Console.Write(text[i]);
                    Thread.Sleep(100);
                }
                
            }
            else
            {
                Console.Clear();
                for (int i = 0; i <text2.Length; i++)
                {
                    Console.Write(text2[i]);
                    Thread.Sleep(100);
                }
            }

        }

        }


    class saving:account
    {
        float s_bal;
        public void sdis()
        {
            string txt2 = "\t\t\t\tTotal Balance : ";
            Console.Clear();
            for (int i = 0; i < txt2.Length; i++)
            {
                Console.Write(txt2[i]);
                Thread.Sleep(100);
            }
            Console.Write("" + s_bal);

        }


        public void sdipo()
        {
            float inter;
            string text = "\t\t\t\tNew Balance has been updated........";
            Console.Write("\t\t\t\tDiposit ammount: ");
            float sdip = float.Parse(Console.ReadLine());
            s_bal = s_bal + sdip;
            inter = (s_bal * 2) / 100;
            s_bal = s_bal + inter;

            Console.Clear();
            for (int i = 0; i < text.Length; i++)
            {
                Console.Write(text[i]);
                Thread.Sleep(100);
            }

        }


        public void swit()
        {
            string text = "\t\t\t\tNew Balance has been updated........";
            string text2 = "\t\t\t\tYour balance is 0 you cant withdraw sir/mam.......";
            Console.Write("\t\t\t\tWithdraw Ammout : ");
            float S_wit = float.Parse(Console.ReadLine());

            if (s_bal > 500)
            {

                s_bal -= S_wit;
                Console.Clear();
                for (int i = 0; i < text.Length; i++)
                {
                    Console.Write(text[i]);
                    Thread.Sleep(100);
                }

            }
            else
            {
                Console.Clear();
                for (int i = 0; i < text2.Length; i++)
                {
                    Console.Write(text2[i]);
                    Thread.Sleep(100);
                }
            }


        }



    }



}
