//Write a program to enter student marks and calculate percentage and grade.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assginment_23_2_22
{
    class studnet
    {
        
        byte c,cpp,csharp,java;
        float total, per, avg;
        char grade;
        public void getdata()
        {

            Console.WriteLine("Enter the marks for C");
            c = byte.Parse(Console.ReadLine());

            Console.WriteLine("Enter the marks for CPP");
            cpp = byte.Parse(Console.ReadLine());

            Console.WriteLine("Enter the marks for C#");
            csharp = byte.Parse(Console.ReadLine());

            Console.WriteLine("Enter the marks for JAVA");
            java = byte.Parse(Console.ReadLine());
            

        }
        public void cal()
        {
            total = c+cpp+csharp+java;
            avg = total/4.0f;
            per = (total / 400.0f) * 100f;

            if(avg>100 && avg<0)
            {
                Console.WriteLine("Invalid");
            }
            else if(avg >= 90)
            {
                grade = 'A';
            }
            else if(avg >=60 && avg <90)
            {
                grade = 'B';
            }
            else if (avg >= 30 && avg <60)
            {
                grade = 'C';
            }
            else if(avg < 30)
            {
                grade = 'E';


            }

            Console.Clear();
            if (c<30 || cpp< 30 || csharp<30 || java < 30)
            {

                Console.WriteLine("You are failed");
            }
            else if (avg < 30)
            {
                Console.WriteLine("C = " + c + "  CPP = " + cpp + "  C# = " + csharp + "  JAVA = " + java);
                Console.WriteLine("You have failed");
                Console.WriteLine("FULL MARKS : " + 400);
                Console.WriteLine("TOTAL MARKS : " + total);
                Console.WriteLine("GRADE : " + grade);
                Console.WriteLine("AVERAGE : " + avg);
                Console.WriteLine("PERCENTAGE : " + per + "%");
            }
            else
            {
                Console.WriteLine("C = " + c + "  CPP = " + cpp + "  C# = " + csharp + "  JAVA = " + java);
                Console.WriteLine("You have passed");
                Console.WriteLine("FULL MARKS : " + 400);
                Console.WriteLine("TOTAL MARKS : " + total);
                Console.WriteLine("GRADE : " + grade);
                Console.WriteLine("AVERAGE : " + avg);
                Console.WriteLine("PERCENTAGE : " + per + "%");
            }
          



        }

    }
}
