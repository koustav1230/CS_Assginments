using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assginment_28_2_22;


namespace pub
{

        public class Student
        {

            public int rollNo;
            public string name;

            public Student(int r, string na)
            {
                rollNo = r;
                name = na;
            }

            public void getRollNo()
            {
                Console.WriteLine("From the Function ");
                Console.WriteLine("ROll number is " + rollNo);
            }
            public void getName()
            {
                Console.WriteLine("From the Function ");
                Console.WriteLine("Name is " + name);
            }
        }

    
}
