//Write a program to calculate profit or loss
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assginment_23_2_22
{
    class profit
    {
        int cprice,sprice;
        public void get()
        {
            Console.WriteLine("Enter The cost price and selling price");
            cprice =int.Parse(Console.ReadLine());
            sprice = int.Parse(Console.ReadLine()); 

            if(cprice < sprice)
            {
                Console.WriteLine("Total profit gain : "+(sprice-cprice)+" Rs");
            } 
            else if(cprice > sprice)
            {
                Console.WriteLine("total loss : " + (cprice - sprice)+" Rs");
            }
            else
            {
                Console.WriteLine("Neither loss nor profit");
            }
        }
    }
}
