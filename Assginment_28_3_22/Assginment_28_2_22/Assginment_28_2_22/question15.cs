//Write a C# program to store the information of 5 employees using structure and array.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assginment_28_2_22
{
    struct emp
    {
        public int id;
        public string name;
        public int age;
        public int salary;


        public void get()
        {
            Console.Write("ENTER THE EMPLOYEE ID : ");
            id = int.Parse(Console.ReadLine());
            Console.Write("Enter THE EMPLOYEE NAME : ");
            name = Console.ReadLine();
            Console.Write("ENTER THE EMPLOYEE AGE : ");
            lbl:
            age = int.Parse(Console.ReadLine());
            if(age < 0 || age > 100)
            {
                
                Console.WriteLine("Invalid AGE ENTER AGAIN!");
                
                goto lbl;
            }
            else
            {
                Console.Write("ENTER THE SALARY : ");
                salary = int.Parse(Console.ReadLine());
            }
            
            
            


            

        }

        public void show()
        {
            

            Console.Write("\nID       : " + id);
            Console.Write("\nNAME     : " + name);
            Console.Write("\nAGE      : " + age);
            Console.Write("\nSALARY   : " +salary);

        }
    }
    class question15
    {
        int i, store,a=1;
        public void prgm()
        {

            Console.Write("The Number of Employee You Wnat to store :: ");
            store = int.Parse(Console.ReadLine());
            emp[] obj = new emp[store];

            for (i = 0; i < store; i++)
            {
                Console.WriteLine("EMPPLOYEE : (" + a + ")");
                obj[i].get();
                a++;
                Console.Clear();

            }
            if (i == store)
            {
                for(i = 0; i < obj.Length; i++)
                {
                    obj[i].show();
                    Console.WriteLine("");
                }

            }





        }


    }


}
