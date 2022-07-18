using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assginment_02_3_22
{
    internal class main
    {
        static void Main()
        {

            string a;

            do
            {
                Console.WriteLine("\nWANT TO RUN THE PROGRAM?");
                Console.WriteLine("Y.Yes\tN.No");
                a = Console.ReadLine();
                Console.Clear();
                if (a == "y")
                {


                    //question 1.
                    //string x, y;
                    //int x1, y1, ch;
                    //float x2, y2;

                    //question1 obj = new question1();

                    //Console.WriteLine("1.(INT)+(INT)");
                    //Console.WriteLine("2.(FLOAT)+(FLOAT)");
                    //Console.WriteLine("3.(STRING)+(STRING)");
                    //ch = int.Parse(Console.ReadLine());

                    //if (ch == 1)
                    //{
                    //    Console.Write("Enter the two Integer to Add : ");
                    //    x1 = int.Parse(Console.ReadLine());
                    //    y1 = int.Parse(Console.ReadLine());
                    //    obj.prgm(x1, y1);
                    //}
                    //else if (ch == 2)
                    //{
                    //    Console.Write("Enter the two Float to Add : ");
                    //    x2 = float.Parse(Console.ReadLine());
                    //    y2 = float.Parse(Console.ReadLine());
                    //    obj.prgm(x2, y2);
                    //}
                    //else if (ch == 3)
                    //{
                    //    Console.Write("Enter the two string to concate : ");
                    //    x = Console.ReadLine();
                    //    y = Console.ReadLine();
                    //    obj.prgm(x, y);
                    //}


                    //question 2.
                    //Console.Write("Enter the value of x anb y: ");
                    //int x = int.Parse(Console.ReadLine());
                    //int y = int.Parse(Console.ReadLine());

                    //question2 obj = new question2(x, y);
                    //question2 onj2 = new question2(obj);



                    //question3.
                    //int rl, idd;
                    //string naa;
                    //Console.Write("HOW MANY RECORD YOU WANT TO STORE : ");
                    //int rec = int.Parse(Console.ReadLine());

                    //question3[] obj = new question3[rec];
                    //for (int i = 0; i < rec; i++)
                    //{
                    //    int j = i + 1;
                    //    Console.Write("\nEnter student " + j + " info");
                    //    Console.Write("\nID: ");
                    //    idd = int.Parse(Console.ReadLine());
                    //    Console.Write("\nName: ");
                    //    naa = Console.ReadLine();
                    //    Console.Write("\nRoll: ");
                    //    rl = int.Parse(Console.ReadLine());


                    //    obj[i] = new question3(rl, idd, naa);
                    //    obj[i].show();


                    //}
                    //static method..


                    //question 4.
                    //string text;
                    //Console.Write("Enter a Word : ");
                    //text = Console.ReadLine();
                    //Console.Clear();
                    //question4 obj = new question4(text);
                    //obj.pgrm();



                    //question 5.
                    //string name, deprt;
                    //byte age;
                    //int sal1;

                    //Console.Write("Enter the name : ");
                    //name = Console.ReadLine();
                    //Console.Write("\nEnte the age : ");
                    //age = byte.Parse(Console.ReadLine());
                    //Console.Write("\nEnter the depertment : ");
                    //deprt = Console.ReadLine();
                    //Console.Write("\nEnter the salary : ");
                    //sal1 = int.Parse(Console.ReadLine());

                    //question5 obj = new question5();
                    //obj.name = name;
                    //obj.age = age;
                    //obj.dprt = deprt;
                    //obj.salary = sal1;
                    //obj.prgm();



                    //question 6.
                    //Console.WriteLine("Bird info");
                    //Console.Write("1.PARROT\t2.EAGLE\t\t3.KINGFISHER");
                    //Console.Write("\nYour choice : ");
                    //byte ch = byte.Parse(Console.ReadLine());
                    //if (ch == 1)
                    //{
                    //    parrot obj = new parrot();
                    //    obj.b();
                    //    obj.p();
                    //}
                    //else if (ch == 2)
                    //{
                    //    ealge obj2 = new ealge();
                    //    obj2.b();
                    //    obj2.e();
                    //}
                    //else if (ch == 3)
                    //{
                    //    kingfisher obj3 = new kingfisher();
                    //    obj3.b();
                    //    obj3.k();
                    //}


                    //question 7.
                    //Eagle obj = new Eagle();
                    //obj.brd();
                    //obj.fb();
                    //obj.eg();



                    //question 8.
                    //current obj = new current();
                    //saving obj1 = new saving();
                    //string text = "\t\t\t\tWelcome To The ABC Bank";
                    //string text2 = "\t\t\t\tLoging is required....";
                    //for (int i = 0; i < text.Length; i++)
                    //{
                    //    Console.Write(text[i]);
                    //    Thread.Sleep(100);
                    //}



                    //while (true)
                    //{
                    //    Console.Write("\n\t\t\t\tPlease Choose Account Type S.saving C.current");

                    //    char cht=char.Parse(Console.ReadLine());

                    //    while (cht == 'c')
                    //    {

                    //        Console.WriteLine();
                    //        Console.Write("\t\t\t\tEnter Your Choice...");
                    //        Console.WriteLine();
                    //        Console.Write("\t\t\t\t  1.Withdraw");
                    //        Console.WriteLine();
                    //        Console.Write("\t\t\t\t  2.Diposit");
                    //        Console.WriteLine();
                    //        Console.Write("\t\t\t\t  3.check balance");
                    //        Console.WriteLine();
                    //        Console.Write("\t\t\t\t  4.exit");
                    //        Console.WriteLine();
                    //        Console.Write("\t\t\t\t  Selecton: ");

                    //        int choice = int.Parse(Console.ReadLine());



                    //        if (choice == 1)
                    //        {

                    //            for (int i = 0; i < text2.Length; i++)
                    //            {
                    //                Console.Write(text2[i]);
                    //                Thread.Sleep(100);

                    //            }

                    //            Console.Write("\n\t\t\t\tPress Any key to Login..\n");
                    //            Console.ReadKey();
                    //            Console.Clear();
                    //            obj.details();
                    //            obj.wtdr();


                    //        }
                    //        if (choice == 2)
                    //        {
                    //            for (int i = 0; i < text2.Length; i++)
                    //            {
                    //                Console.Write(text2[i]);
                    //                Thread.Sleep(100);

                    //            }

                    //            Console.Write("\n\t\t\t\tPress Any key to Login..\n");
                    //            Console.ReadKey();
                    //            Console.Clear();
                    //            obj.details();

                    //                obj.dipo();


                    //        }
                    //        if (choice == 3)
                    //        {
                    //            obj.baldis();
                    //        }
                    //        if (choice == 4)
                    //        {
                    //            break;
                    //        }
                    //    }


                    //    while (cht == 's')
                    //    {


                    //        Console.WriteLine();
                    //        Console.Write("\t\t\t\tEnter Your Choice...");
                    //        Console.WriteLine();
                    //        Console.Write("\t\t\t\t  1.Withdraw");
                    //        Console.WriteLine();
                    //        Console.Write("\t\t\t\t  2.Diposit");
                    //        Console.WriteLine();
                    //        Console.Write("\t\t\t\t  3.check balance");
                    //        Console.WriteLine();
                    //        Console.Write("\t\t\t\t  4.exit");
                    //        Console.WriteLine();
                    //        Console.Write("\t\t\t\t  Selecton: ");

                    //        int choice1 = int.Parse(Console.ReadLine());
                    //        if (choice1 == 1)
                    //        {

                    //            for (int i = 0; i < text2.Length; i++)
                    //            {
                    //                Console.Write(text2[i]);
                    //                Thread.Sleep(100);

                    //            }

                    //            Console.Write("\n\t\t\t\tPress Any key to Login..\n");
                    //            Console.ReadKey();
                    //            Console.Clear();
                    //            obj1.details();
                    //            obj1.swit();


                    //        }
                    //        if (choice1 == 2)
                    //        {
                    //            for (int i = 0; i < text2.Length; i++)
                    //            {
                    //                Console.Write(text2[i]);
                    //                Thread.Sleep(100);

                    //            }

                    //            Console.Write("\n\t\t\t\tPress Any key to Login..\n");
                    //            Console.ReadKey();
                    //            Console.Clear();
                    //            obj1.details();
                    //            obj1.sdipo();


                    //        }
                    //        if (choice1 == 3)
                    //        {
                    //            obj1.sdis();
                    //        }
                    //        if (choice1 == 4)
                    //        {
                    //            break;
                    //        }
                    //    }


                    //}



                    //question1 9.
                    //Console.WriteLine("1.ADDITION\n2.SUBSTRACTION\n3.MULTIPLICATIOn\n4.DIVISON");
                    //Console.Write("\nEnter your choice : ");
                    //byte temp = byte.Parse(Console.ReadLine());
                    //Console.Clear();
                    //if (temp == 1)
                    //{
                    //    Console.Write("Enter two Numbers you want to add : ");
                    //    double temp2 = double.Parse(Console.ReadLine());
                    //    double temp3 = double.Parse(Console.ReadLine());
                    //    MyCalculator obj = new MyCalculator();
                    //    obj.add(temp2, temp3);
                    //}
                    //else if (temp == 2)
                    //{
                    //    Console.Write("Enter two Numbers you want to Substract : ");
                    //    double temp2 = double.Parse(Console.ReadLine());
                    //    double temp3 = double.Parse(Console.ReadLine());
                    //    MyCalculator obj = new MyCalculator();
                    //    obj.subtract(temp2, temp3);
                    //}
                    //else if (temp == 3)
                    //{
                    //    Console.Write("Enter two Numbers you want to multiplay : ");
                    //    double temp2 = double.Parse(Console.ReadLine());
                    //    double temp3 = double.Parse(Console.ReadLine());
                    //    MyCalculator obj = new MyCalculator();
                    //    obj.multiply(temp2, temp3);
                    //}
                    //else if (temp == 4)
                    //{
                    //    Console.Write("Enter two Numbers you want to divide : ");
                    //    double temp2 = double.Parse(Console.ReadLine());
                    //    double temp3 = double.Parse(Console.ReadLine());
                    //    MyCalculator obj = new MyCalculator();
                    //    obj.divide(temp2, temp3);
                    //}


                    //question 10.
                    //Console.Write("How many car deatils you want to store : ");
                    //int store=int.Parse(Console.ReadLine());            
                    //B ko1 =new B(store);                   
                    //ko1.getb();
                    //Console.Clear();
                    //ko1.showb();
                    //Console.Write("\nEnter any any key.......");
                    //Console.ReadKey();
                    //Console.WriteLine();
                    //A ko2 = new A(store);



                    //question 11.
                    //Temp temp = new Temp();
                    //temp.get();
                    //temp.func();
                    //Console.Clear();
                    //temp.show();    





                    //quetion 12.
                    //question12 obj = new Demo();
                    //obj.mrthod();





                    //question 13.
                    //child obj =new child();
                    //string text = "\t\t\t\tHello Welcome To The ABC Shop....";
                    //for(int i = 0; i < text.Length; i++)
                    //{
                    //    Console.ForegroundColor = ConsoleColor.Cyan;


                    //    Console.Write(text[i]);
                    //    Thread.Sleep(100);
                    //}
                    //Console.ForegroundColor = ConsoleColor.DarkCyan;

                    //Console.Write("\n\t\t\t\tPress Any To continue Purchase..");
                    //Console.ReadKey();
                    //Console.Clear();
                    //while (true)
                    //{
                    //    Console.Write("\n\t\t\t\t  Please Select the pc you want to buy");
                    //    Console.WriteLine();
                    //    Console.ForegroundColor = ConsoleColor.Gray;
                    //    Console.Write("\n\t\t\t\t1.DEL");
                    //    Console.ForegroundColor = ConsoleColor.Yellow;
                    //    Console.Write("\t2.HP");
                    //    Console.ForegroundColor = ConsoleColor.Green;
                    //    Console.Write("\t3.LENOVO");
                    //    Console.ForegroundColor = ConsoleColor.Red;
                    //    Console.Write("\t4.SAMSUNG");
                    //    Console.ForegroundColor = ConsoleColor.DarkRed;
                    //    Console.Write("\t5.DONE SHOPPING");

                    //    Console.WriteLine("                    ");
                    //    byte bt = byte.Parse(Console.ReadLine());

                    //    if (bt == 1)
                    //    {
                    //        obj.del();
                    //    }
                    //    if (bt == 2)
                    //    {
                    //        obj.hp();

                    //    }
                    //    if (bt == 3)
                    //    {
                    //        obj.len();
                    //    }
                    //    if (bt == 4)
                    //    {
                    //        obj.sam();
                    //    }
                    //    if(bt == 5)
                    //    {
                    //        break;
                    //    }
                    //}


                    //question 14.
                    //question14 obj = new question14();
                    //Console.ForegroundColor = ConsoleColor.Yellow;
                    //Console.Write("\t\t\t\tEnter your choice");
                    //Console.ForegroundColor = ConsoleColor.Cyan;
                    //Console.Write("\n\t\t\t\t1.Add 2.Concate");

                    //byte choi=byte.Parse(Console.ReadLine());
                    //Console.Clear();
                    //if(choi == 1)
                    //{
                    //    obj.gpm();

                    //}
                    //if (choi == 2)
                    //{
                    //    obj.prgrm();
                    //} 



                    //question 15.
                    //question15 obj = new question15();
                    //Console.Write("\nEnter the student name : ");
                    //string nam = Console.ReadLine();
                    //Console.Write("\nEnter the student id : ");
                    //int id = int.Parse(Console.ReadLine());
                    //Console.Write("\nEnter the roll number : ");
                    //int rlm = int.Parse(Console.ReadLine());
                    //obj.name = nam;
                    //obj.idd = id;
                    //obj.roll = rlm;
                    //obj.pgm();



                    //question1 16.                   
                    //string txt = "\t\t\t\tGreertings Sir Press Any Key to run the program";
                    //string txt2 = "\t\t\t\tPYRAMID IS LOADING PLEASE WAIT.......";
                    //int r;
                    //string pat;
                    //for(int i = 0; i < txt.Length; i++)
                    //{
                    //    Console.ForegroundColor = ConsoleColor.Cyan;
                    //    Console.Write
                    //        (txt[i]);
                    //    Thread.Sleep(100);
                    //}
                    //Console.ReadKey();
                    //Console.Clear();

                    //Console.ForegroundColor = ConsoleColor.DarkRed;

                    //Console.Write("\n\t\t\t\t\tEnter your choice");
                    //Console.ForegroundColor = ConsoleColor.Yellow;
                    //Console.Write("\n\n\t\t\t\t1.PYRAMID  2.INVERTED PYRAMID");
                    //byte b=byte.Parse(Console.ReadLine());
                    //Console.Clear();

                    //if (b == 1)
                    //{
                    //    Console.Write("\n\t\t\t\tEnter The Row Size : ");
                    //    r = int.Parse(Console.ReadLine());
                    //    Console.Write("\n\t\t\t\tEnter The Element Type : ");
                    //    pat = Console.ReadLine();
                    //    for (int i = 0; i < txt2.Length; i++)
                    //    {

                    //        Console.ForegroundColor = ConsoleColor.Cyan;
                    //        Console.Write
                    //            (txt2[i]);
                    //        Thread.Sleep(100);

                    //    }
                    //    Console.Clear();
                    //    question16 obj = new question16(r, pat);
                    //    obj.pyra();

                    //}
                    //if(b == 2)
                    //{
                    //    Console.Write("\n\t\t\t\tEnter The Row Size : ");
                    //    r = int.Parse(Console.ReadLine());
                    //    Console.Write("\n\t\t\t\tEnter The Element Type : ");
                    //    pat = Console.ReadLine();
                    //    for (int i = 0; i < txt2.Length; i++)
                    //    {
                    //        Console.ForegroundColor = ConsoleColor.Cyan;
                    //        Console.Write
                    //            (txt2[i]);
                    //        Thread.Sleep(100);
                    //    }

                    //    Console.Clear();
                    //    question16 obj = new question16(r, pat);
                    //    obj.inv();
                    //}




                    //queation 17.
                    //string s = "This Is Just A Progrgam To Find armstrong Numbers using extention method";
                    //for(int i = 0; i < s.Length; i++)
                    //{
                    //    Console.Write(s[i]);
                    //    Thread.Sleep(40);
                    //}
                    //Console.Clear();
                    //Console.Write("\nEnter any key To continue");
                    //Console.ReadKey();

                    //Console.Clear();
                    //Console.WriteLine("Enter The Number you want to check");
                    //int num=int.Parse(Console.ReadLine());
                    //Console.Clear();
                    //num.pgrm();



                    //question 18.
                    //Int32 call=0;
                    //call.max_x();
                    


                    //question1 19.
                    //int f=0;
                    //f.demo();


                    //question 20.
                    //question20 obj = new question20();
                    //obj.pgrm();





















































                }
                else if (a == "n")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Selection");
                }
            }
            while (true);
        }



    }  
}

