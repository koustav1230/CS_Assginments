//Write a program for ArrayList collection and demonstrate all the methods of ArrayList Class.
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assginment_02_3_22
{
     class question20
    {

        public void pgrm()
        {
            
            ArrayList oo = new ArrayList();

            Console.Write("\nHow Many Numbers You want to add Using arrayList : ");
            int num=int.Parse(Console.ReadLine());
            int[] ar = new int[num];
            int[] ar2 = new int[1];
            int[] ar3 = new int[1];
            Console.Write("\nEnter The Array Elemensts : ");
            for (int i=0;i<num;i++)
            {
                ar[i] = int.Parse(Console.ReadLine());

                oo.Add(ar[i]);

            }
            Console.Clear();

            foreach (int i in oo)
            {
                
                Console.Write(i+" ");
            }

            Console.WriteLine("Enter element you want to delete");
            ar2[0]=int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                if(ar[i]==ar2[0])
                {
                    oo.Remove(ar[i]);
                }
                else
                {
                    Console.WriteLine("Invalid Entry");
                    break;
                }
            }

            foreach(int i in oo)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("\nEnter element you want to insert");
            int el=int.Parse(Console.ReadLine());
            Console.WriteLine("\nEnter Index you want to insert");
            int pos=int.Parse(Console.ReadLine());

            for(int i = 0; i < num; i++)
            {
                if(pos==ar[i])
                {
                    oo.Insert(ar[i],el);
                }
                else
                {
                    Console.WriteLine("Invalid index");
                    break;
                }
                
            }

            foreach(int s in oo)
            {
                Console.Write(s+" ");
            }



        }


    }

}
