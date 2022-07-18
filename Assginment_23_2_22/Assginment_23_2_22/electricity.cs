//Write a program to input electricity unit charge and calculate the total electricity bill according to the given condition:
//For first 50 units Rs. 0.50/unit
//For next 100 units Rs. 0.75/unit
//For next 100 units Rs. 1.20/unit
//For unit above 250 Rs. 1.50/unit
//An additional surcharge of 20% is added to the bill.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assginment_23_2_22
{
    class electricity
    {
        byte unit;
        float res,sc,total;
        public void getvalue()
        {
            Console.WriteLine("Enter the unit value");
            unit =byte.Parse(Console.ReadLine());

            if(unit > 0 && unit <= 50)
            {
                res = unit*0.50f;
            }
            else if(unit <= 150)
            {
                res = 25 + (unit - 50) * 0.75f;  
            }
            else if(unit <=250)
            {
                res = 100 + (unit - 150) * 1.20f;
            }
            else 
            {
                res = 25 + 75 + 120 + (unit - 250) * 1.50f;
            }
        
            sc = res*0.20f;
            total = res + sc;
            Console.WriteLine("final amount is : "+total);
        }

    }
}
