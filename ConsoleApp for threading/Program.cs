using System;
using System.Threading;


namespace ConsoleApp_for_threading
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //function1();
            //function2();
            //Foregrund Thread Application
            Thread tina = new Thread(function1);
            tina.Start();
            Thread Mina = new Thread(function2);
            Mina.Start();
            tina.IsBackground = true;

            Console.WriteLine("Main Application Exited");

        }
        static void function1()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Function1 executed "  +i.ToString());
                Console.ReadLine();
                Console.WriteLine("Function1 completed for " + i.ToString());
                //Thread.Sleep(3000);
            }
        }
        static void function2()
         {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Function2 executed "  +i.ToString());
                Thread.Sleep(3000);
            }
        }


    }
}
