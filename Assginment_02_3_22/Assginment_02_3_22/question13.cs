//Demonstrate the use of sealed keyword.(with class and methods)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assginment_02_3_22
{
     class question13
    {
        public int dprice, lprice, sprice, hprice;
        public question13()
        {
            dprice = 20000;
            lprice = 25000;
            sprice = 30000;
            hprice = 28000;

        }   

    }
      sealed class child:question13
    {

        public void del()
        {
            string txt = "\t\t\t\tTransaction is processing..........";

            string txt1 = "\t\t\t\tsucsess..........";

            Console.WriteLine("\t\t\t\tThe Price Is " + dprice);
            Console.WriteLine("\t\t\t\tPress Enter To Continue The Purchase");
            Console.ReadKey();
            Console.Clear();

            for (int i = 0; i < txt.Length; i++)
            {
                Console.Write(txt[i]);
                Thread.Sleep(100);
            }
            Console.Clear();

            for (int i = 0; i < txt1.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write(txt1[i]);
                Thread.Sleep(100);
            }
            Console.WriteLine();
            Console.WriteLine("\t\t\t\tThanks For Shoping with us");
            Console.WriteLine("\t\t\t\tPress Any Key");
            Console.ReadKey();
            Console.Clear();
        }

        public void len()
        {
            string txt = "\t\t\t\tTransaction is processing..........";

            string txt1 = "\t\t\t\tsucsess..........";

            Console.WriteLine("\t\t\t\tThe Price Is " + lprice);
            Console.WriteLine("\t\t\t\tPress Enter To Continue The Purchase");
            Console.ReadKey();
            Console.Clear();

            for (int i = 0; i < txt.Length; i++)
            {
                Console.Write(txt[i]);
                Thread.Sleep(100);
            }
            Console.Clear();

            for (int i = 0; i < txt1.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write(txt1[i]);
                Thread.Sleep(100);
            }

            Console.WriteLine();
            Console.WriteLine("\t\t\t\tThanks For Shoping with us");
            Console.WriteLine("\t\t\t\tPress Any Key");
            Console.ReadKey();
            Console.Clear();
        }

        public void hp()
        {
            string txt = "\t\t\t\tTransaction is processing..........";

            string txt1 = "\t\t\t\tsucsess..........";

            Console.WriteLine("\t\t\t\tThe Price Is " + hprice);
            Console.WriteLine("\t\t\t\tPress Enter To Continue The Purchase");
            Console.ReadKey();
            Console.Clear();

            for (int i = 0; i < txt.Length; i++)
            {
                Console.Write(txt[i]);
                Thread.Sleep(100);
            }
            Console.Clear();

            for (int i = 0; i < txt1.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write(txt1[i]);
                Thread.Sleep(100);
            }

            Console.WriteLine();
            Console.WriteLine("\t\t\t\tThanks For Shoping with us");
            Console.WriteLine("\t\t\t\tPress Any Key");
            Console.ReadKey();
            Console.Clear();
        }


        public void sam()
        {
            string txt = "\t\t\t\tTransaction is processing..........";

            string txt1 = "\t\t\t\tsucsess..........";

            Console.WriteLine("\t\t\t\tThe Price Is " + sprice);
            Console.WriteLine("\t\t\t\tPress Enter To Continue The Purchase");
            Console.ReadKey();
            Console.Clear();

            for (int i = 0; i < txt.Length; i++)
            {
                Console.Write(txt[i]);
                Thread.Sleep(100);
            }
            Console.Clear();

            for (int i = 0; i < txt1.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write(txt1[i]);
                Thread.Sleep(100);
            }
            Console.WriteLine();
            Console.WriteLine("\t\t\t\tThanks For Shoping with us");
            Console.WriteLine("\t\t\t\tPress Any Key");
            Console.ReadKey();
            Console.Clear();



        }

    }








}
