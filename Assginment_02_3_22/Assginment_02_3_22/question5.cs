//Write the program which will implement the concept of properties in c#.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assginment_02_3_22
{
    class question5
    {
        
        private string n;
        private string dp;
        private byte ag;
        private int sal;




        public string name
        {
            get{return n;}
            set{n = value;}
        }

        public string dprt
        { 
            get { return dp; }
            set { dp = value; }
        }
        public byte age
        {
            get { return ag; }
            set { ag = value; }
        }
        public int salary
        {
            get { return sal; }
            set { sal = value; }
        }
        public void prgm()
        {
            Console.Clear();
            Console.Write("NAME\t\t\tAGE\t\t\tDEPARTMENT\t\t\tSALARY");
            Console.Write("\n" + n+"\t\t\t"+ag+"\t\t\t"+dp+"\t\t\t\t"+sal);
        }

    }
}
