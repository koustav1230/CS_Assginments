using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assginment_02_3_22
{
   public partial class question15
    {

       public int roll
        {
            set
            {
                if(value<0&& value>100)
                {
                    Console.WriteLine("Invalid entry");
                }

                this.rol=value;
            }
            get
            {
                return this.rol;
            }
        }

       
        public void pgm()
        {
            Console.Write("\nEnter the subject score : ");
            sco=int.Parse(Console.ReadLine());

            if(sco<id)
            {
                Console.Clear();
                Console.WriteLine("pass mark : "+pmark);
                Console.WriteLine("student score : "+sco);
                Console.WriteLine("student failed");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Name :"+name);
                Console.WriteLine("ID   : "+idd);
                Console.WriteLine("ROLL : "+roll);
                Console.WriteLine("pass mark : " + pmark);
                Console.WriteLine("student score : " + sco);
                Console.WriteLine("student passed");
            }
        }
    }
}
