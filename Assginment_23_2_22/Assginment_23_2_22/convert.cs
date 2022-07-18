//Write a c# program to convert given number in word. (357546  :  three five seven five four six )
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assginment_23_2_22
{
    class convert
    {
        int num, rem, sum, no;

        public void prgm()
        {
            Console.WriteLine("Enter Any Number");
            num = int.Parse(Console.ReadLine());
            Console.Clear();

        
            while (num > 0)
            {
                rem = num % 10;
                sum=sum*10+rem;   
                num = num / 10;



            }

            num = sum;
            while(num > 0)
            {
                no = num % 10;
                num = num / 10;

                switch (no)
                {
                    case 0:
                        Console.Write("Zero  ");
                        break;

                    case 1:
                        Console.Write("One  ");
                        break;

                    case 2:
                        Console.Write("Two  ");
                        break;
                    case 3:
                        Console.Write("Three  ");
                        break;
                    case 4:
                        Console.Write("Four  ");
                        break;
                    case 5:
                        Console.Write("Five  ");
                        break;
                    case 6:
                        Console.Write("Six  ");
                        break;
                    case 7:
                        Console.Write("Seven  ");
                        break;
                    case 8:
                        Console.Write("Eight  ");
                        break;
                    case 9:
                        Console.Write("Nine  ");
                        break;
                    default:
                        Console.Write("Invalid Input");
                        break;


                }

                
            }






        }
    }
}
