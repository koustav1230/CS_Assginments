//Write a program which will demonstrate the function overriding.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assginment_02_3_22
{
    internal class question12
    {
        public int term;
        public int num1=0;
        public int num2=1;
        public int sum=0;

        public virtual void mrthod()
        {
            Console.WriteLine("I  just a demo method");
        }


    }

    class Demo : question12
    {
        
        public override void mrthod()
        {
            string txt = "Term is loading.....";
            Console.WriteLine("Enter the nunber of term you want to print : ");
            term=int.Parse(Console.ReadLine());

            for (int i = 0; i < txt.Length; i++)
            {

                Console.Write(txt[i]);
                Thread.Sleep(100);
            }
            Console.WriteLine();
            for(int i=1;i<=term;i++)
            {
                
                Console.Write(sum + "\t");
                num1 = num2;
                num2 = sum;
                sum= num1 + num2;
            }

        }



    }

}
