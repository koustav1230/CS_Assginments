//Write a program to convert 24-hour time format to 12-hour time format with am or pm appropriate
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assginment_23_2_22
{
    class time
    {
        int hour, minute, second,hr;
        string pm="PM",am="AM";
        public void gettime()
        {
            Console.WriteLine("Enter the time in 24 hour format");
            hour =byte.Parse(Console.ReadLine());
            minute =byte.Parse(Console.ReadLine());
            second =byte.Parse(Console.ReadLine());
    
        }
    
        public void modification()
        {
            if(hour > 12 && hour <=24 && minute <=59 && minute >=0 && second <=59 && second >=0)
            {
                am = pm;
                hr= hour-12;
                Console.WriteLine(hr+":"+minute+":"+second+" "+am);
                
            }
            //else if(hour == 12)
            //{

            //}
            else if(hour <= 12)
            {
                pm = am;
                Console.WriteLine(hour + ":" + minute + ":" + second + " " + pm);
            }
            else
            {
                Console.WriteLine("invalid");
            }
           
        }
    
    }

}
