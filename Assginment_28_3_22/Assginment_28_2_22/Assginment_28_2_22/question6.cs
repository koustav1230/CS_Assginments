//Write down a menu driven program using switch to convert various distance from one unit to other
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assginment_28_2_22
{
    class question6
    {
        byte ch;
        float miles, km, me, cm, ft, inc;
        public void prgm()
        {

            Console.WriteLine("1.Convert Miles into Kilometer");
            Console.WriteLine("2.Convert Kilometer into Meter");
            Console.WriteLine("3.Convert Meter into Centimeter");
            Console.WriteLine("4.Convert Meter into Feet");
            Console.WriteLine("5.Convert Meter into Inch");
            Console.WriteLine("6.Convert Inch into Centimeter");
            Console.WriteLine("7.Convert Feet into Centimeter");
            Console.WriteLine("\n");
            Console.Write("Enter your choice:");
            ch = byte.Parse(Console.ReadLine());
            Console.Clear();

            switch (ch)
            {
                case 1:
                    Console.Write("MILES : ");
                    miles = float.Parse(Console.ReadLine());
                    km = miles * 1.60934f;
                    Console.Write("KILOMETER : " + km);
                    break;
                case 2:
                    Console.Write("KILOMETER : ");
                    km = float.Parse(Console.ReadLine());
                    me = km * 1000.0000f;
                    Console.Write("METER : " + me);
                    break;
                case 3:
                    Console.Write("METER : ");
                    me = float.Parse(Console.ReadLine());
                    cm = me * 100.0000f;
                    Console.Write("CENTIMETER : " + cm);
                    break;
                case 4:
                    Console.Write("METER : ");
                    me = float.Parse(Console.ReadLine());
                    ft = me * 3.28084f;
                    Console.Write("FEET : " + ft);
                    break;
                case 5:
                    Console.Write("METER : ");
                    me = float.Parse(Console.ReadLine());
                    inc = me * 39.3701f;
                    Console.Write("INCH : " + inc);
                    break;
                case 6:
                    Console.Write("INCH : ");
                    inc = float.Parse(Console.ReadLine());
                    cm = inc * 2.54f;
                    Console.Write("CENTIMETER : " + cm);
                    break;
                case 7:
                    Console.Write("FEET : ");
                    ft = float.Parse(Console.ReadLine());
                    cm = ft * 30.48f;
                    Console.Write("CENTIMETER : " + cm);
                    break;



            }



        }

    }
}
