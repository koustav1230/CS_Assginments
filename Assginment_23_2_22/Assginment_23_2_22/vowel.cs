//Write a program to check given character is vowel or consonant.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assginment_23_2_22
{
    class vowel
    {
        char ch;
        public void getc()
        {
            Console.WriteLine("Enter a random charecter to check if its a vowel or consonant");
            ch = Console.ReadLine()[0];
        }

        public void condition()
        {
            Console.Clear();
            if (char.IsLetter(ch))
            {
                if (ch == 'a' || ch == 'A')
                {
                    Console.WriteLine(ch + " is a vowel");
                }
                else if (ch == 'e' || ch == 'E')
                {
                    Console.WriteLine(ch + " is a vowel");
                }
                else if (ch == 'i' || ch == 'I')
                {
                    Console.WriteLine(ch + " is a vowel");
                }
                else if (ch == 'o' || ch == 'O')
                {
                    Console.WriteLine(ch + " is a vowel");
                }
                else if (ch == 'u' || ch == 'U')
                {
                    Console.WriteLine(ch + " is a vowel");
                }
                else
                {
                    Console.WriteLine(ch + " is a Consonant");
                }
            }
            else
            {
                Console.WriteLine("Invaid");
            }

            
          }
    }


}
