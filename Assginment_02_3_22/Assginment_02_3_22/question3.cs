//Write a program which will demonstrate the use of static keyword with variables, methods, and constructor
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assginment_02_3_22
{
    class question3
    {
        static int count=0;
        int roll,id;
        string na;

        public question3(int r,int d,string n)
        {
            roll = r;
            id = d;
            na = n;
            count++;
        }

        public void show()
        {
            Console.Write("STUDENT\t\t\tID\t\t\tNAME\t\t\tROLL");
            Console.Write("\n"+count+"\t\t\t"+id+"\t\t\t"+na+"\t\t\t"+roll);
           
        }


    }
}
