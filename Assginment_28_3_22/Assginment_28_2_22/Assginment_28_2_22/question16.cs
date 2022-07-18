using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assginment_28_2_22
{
    //public.
    public class Student
    {

        public int rollNo;
        public string name;
        
        public Student()
        {

        }
        


    }

    public class Z:Student
    {
        public Z(int r, string na)
        {
            rollNo = r;
            name = na;
        }
        public void getRollNo()
        {
            Console.WriteLine("From the getrollno method........");
            Console.WriteLine("ROll number is " + rollNo);
        }
        public void getName()
        {
            Console.WriteLine("From the getName method............ ");
            Console.WriteLine("Name is " + name);
        }
    }



    //protected.
    class Base
    {

        protected int x;

        public Base()
        {
            x = 10;
        }
    }

    class child : Base
    {
        public void getX()
        {
            Console.WriteLine("from the child class");
            Console.WriteLine("The value of x is : " + x);

        }
    }



    //private.
    class Parent
    {


        private int value;
        public void setValue(int v)
        {
            value = v;
        }

        public int getValue()
        {
            return value;
        }
    }
    class Child : Parent
    {

        public void showValue()
        {
            Parent parent = new Parent();
            /* parent.Value;*///even with inherit cant fetch it 
        }

    }

    //internal.
    internal class Complex
    {

        internal int real;
        internal int img;

        public void setData(int r, int i)
        {
            real = r;
            img = i;
        }

        public void displayData()
        {
            Console.WriteLine("Real = {0}", real);
            Console.WriteLine("Imaginary = {0}", img);
        }
    }



}