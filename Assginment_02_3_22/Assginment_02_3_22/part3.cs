using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assginment_02_3_22
{
    partial class question16
    {
        public void pyra()
        {
            int temp = row;
            for (i = 1; i <= row; i++)
            {
                for (j = 1; j <= temp; j++)
                {
                    Console.Write(" ");
                }
                temp--;
                for (k = 1; k <= i; k++)
                {
                    Console.Write(" " + pa);
                    Thread.Sleep(70);
                }
                Console.WriteLine();
            }
        }

        public void inv()
        {

            int temp = row;
            int z = row*2-1;
            
            for (i=row;i>=1;i--)
            {
                for (j = row; j >= i; j--)
                {
                    Console.Write(" ");
                }
                
                for (k = 1; k <= z; k++)
                {
                    Console.Write("" + pa);
                    Thread.Sleep(70);
                }
                z -= 2;
                

                Console.WriteLine();
                

            }
        }
    }
}