//Demonstrate multiple inheritance with the use of interface with suitable example.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assginment_02_3_22
{
    
        interface Add_Sub
        {
            public void add(double x, double y);
            public void subtract(double x, double y);
        }


        interface Mul_Div
        {
            public void multiply(double x, double y);
            public void divide(double x, double y);
        }

        interface Calculator : Add_Sub, Mul_Div
        {
            public void printResult(double result);
        }

        public class MyCalculator : Calculator
        {
            public void add(double x, double y)
            {
                double result = x + y;
            Console.Clear();
            Console.Write(x+" + "+y+" = ");
            printResult(result);
            }

           
            public void subtract(double x, double y)
            {
                double result = x - y;
            Console.Clear();
            Console.Write(x + " - " + y + " = ");
            printResult(result);
            }

            public void multiply(double x, double y)
            {
                double result = x * y;
            Console.Clear();
            Console.Write(x + " x " + y + " = ");
            printResult(result);
            }

            public void divide(double x, double y)
            {
                double result = x / y;
            Console.Clear();
            Console.Write(x + " / " + y + " = ");
            printResult(result);
            }

            public void printResult(double result)
            {
                Console.Write(result);
            }
        }
    
}