using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assginment_02_3_22
{
   public partial class question15
    {
        private String na;
        private int id;
        private int pmark=35;
        private int rol;
        private int sco;
        public string name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    Console.WriteLine("You can not have a Empty name");
                else
                    this.na = value;
            }
            get
            {
                if (string.IsNullOrEmpty(this.na))
                    return "no name";
                else
                {
                    return this.na;
                }
                
            }

        }
        public int idd
        {
            set
            { 
                if(value<0)
                {
                    Console.WriteLine("Invalid id");
                }
                this.id = value;
            }
            get 
            { 
                return this.id; 
            }
        }


    }
}
