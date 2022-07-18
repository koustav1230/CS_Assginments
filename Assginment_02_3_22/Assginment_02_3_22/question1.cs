//Write a program which will demonstrate function overloading. Use minimum 3 functions. 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assginment_02_3_22
{
    class question1
    {
    
        public void pgrm(int x,int y)
        {
            int sum = x + y;
            Console.Write("\nAddition of X and Y is (int) : "+sum);
        }

        public void prgm(float x, float y)
        {
            float sum = x + y;
            Console.Write("\nAddition of X and Y is (float) : " + sum);
        }

        public void prgm(string x ,string y)
        {

            string sum = x + y;
            Console.Write("\nAddition/Concatination of X and Y is (string) : " + sum);

        }
    
    }
}
