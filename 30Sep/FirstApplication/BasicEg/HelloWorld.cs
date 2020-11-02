//Header file in .net we call this as namespace
using System;

namespace BasicEg
{
    class HelloWorld
    {
        static void Main()
        {
            //to print in console window
            Console.Write("Hello World");
            Console.WriteLine("--------------------------------");

            Console.WriteLine("Hello World now a new line");

            //Print your name
            String myname = "Eesha ", FatherName = "Chirag";
            Console.WriteLine(myname);

            //concatenation
            Console.WriteLine("Concatenation");
            Console.WriteLine("MyName:" + myname);
            Console.WriteLine("--------------------------------");

            //Place holder
            Console.WriteLine("Place Holder");
            Console.WriteLine("MyName:{0} ||Fathername:{1}", myname, FatherName);
            Console.WriteLine("MyName:{1}{0}", myname, FatherName);
           
            //to read in a console window
            Console.Read(); 
        }
    }
}
