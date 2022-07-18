//Write a C# program to store the information of one student using structure.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assginment_28_2_22
{
    struct student
    {
        public int ID;
        public string Name;
        public int roll;
        public int marks;

    }
    class question14
    {
        int sid, roll, marks;
        string name;

        public void prgm()
        {
            student stu = new student();
            student stu2 = new student();

            Console.Write("Enter the student (1) id : ");
            sid = int.Parse(Console.ReadLine());
            Console.Write("Enter the name : ");
            name = Console.ReadLine();
            Console.Write("Enter the roll number : ");
            roll = int.Parse(Console.ReadLine());
            Console.Write("Enter the marks : ");
            marks = int.Parse(Console.ReadLine());

            stu.ID = sid;
            stu.Name = name;
            stu.roll = roll;
            stu.marks = marks;

            Console.Clear();

            //Console.Write("Enter the student id (2) : ");
            //sid = int.Parse(Console.ReadLine());
            //Console.Write("Enter the name : ");
            //name = Console.ReadLine();
            //Console.Write("Enter the roll number : ");
            //roll = int.Parse(Console.ReadLine());
            //Console.Write("Enter the marks : ");
            //marks = int.Parse(Console.ReadLine());

            //stu2.ID = sid;
            //stu2.Name = name;
            //stu2.roll = roll;
            //stu2.marks = marks;

            Console.Clear();


            Console.WriteLine("id : " + stu.ID);
            Console.WriteLine("Name : " + stu.Name);
            Console.WriteLine("Roll: " + stu.roll);
            Console.Write("Total Marks : " + stu.marks);

            Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            //Console.WriteLine("id : " + stu2.ID);
            //Console.WriteLine("Name : " + stu2.Name);
            //Console.WriteLine("Roll: " + stu2.roll);
            //Console.Write("Total Marks : " + stu2.marks);

            Console.WriteLine("\n");


        }



    }
}
