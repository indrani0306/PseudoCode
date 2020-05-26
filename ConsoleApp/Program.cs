using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            I1 interobj1 = new A();
            interobj1.method1();
            I2 interobj2 = new A();
            interobj2.method1();
        }

        interface I1 { void method1(); }
        interface I2 { void method1(); }
        class A : I1, I2
        {
            //Explicit Interface application
            void I1.method1()
            {
                Console.WriteLine("You are inside interface 1 method implementation");
            }
            void I2.method1()
            {
                Console.WriteLine("You are inside interface 2 method implementation");
            }
        }
    }
}
