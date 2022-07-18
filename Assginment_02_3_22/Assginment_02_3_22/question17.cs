//Write a program to implement the concept of extended method.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assginment_02_3_22
{
    static class question17
    {
        static int count;
        static double sum = 0;
        static int[] a = new int[10];
        static int i = 0;
        static int o;
        public static void pgrm(this int ob)
        {
            o= ob;
            
            while (ob != 0)
            {
                a[i++] = ob % 10;
                ob /= 10;
                count++;

            }
            

            for ( i = 0; i < count; i++)
            {
                sum += Math.Pow(a[i], count);
             }

            //Console.WriteLine(sum);

            if (sum==o)
            {
                
                Console.WriteLine(o + " Is an Amrstrong number");
            }
            else
            {
                Console.WriteLine(o + " Is not an armstrong Number");
            }



        }

    }
}
