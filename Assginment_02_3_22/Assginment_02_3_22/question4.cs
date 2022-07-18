//Write a program to demonstrate static constructor with proper example
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assginment_02_3_22
{
    class question4
    {
        string s;
        static question4()
        {
            string line = "Checking the give number is a palindrome or not";
            for (int i = 0; i < line.Length; i++)
            {

                Console.Write(line[i]);
                Thread.Sleep(100);
            }
            for (int i = 0; i <5; i++)
            {
                Console.Write(".");
                Thread.Sleep(100);
            }
        }
        public question4(string k)
        {
            
            s = k;
        }

        public void pgrm()
        {
            
            string rev=string.Empty;
            for(int i = s.Length-1; i >= 0; i--)
            {
                rev += s[i].ToString();
            
                
            }
            if (rev == s)
            {
                Console.Clear();
                Console.WriteLine(s + " is a palindorme..");

            }
            else
            {
                Console.Clear();
                Console.WriteLine(s+" is not palindrome.."); 
            }


            
            
        }

    }

}



