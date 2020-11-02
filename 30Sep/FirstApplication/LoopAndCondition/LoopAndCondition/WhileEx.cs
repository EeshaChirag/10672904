using System;

namespace LoopAndCondition
{
    class WhileEx
    {
        static void Main()
        {
            //Print all even number between 1...n
            /*While(Condition)
            {
                set of statements;
            }*/
            int endvalue, initialvalue = 1;
            Console.Write("Enter the number:");
            endvalue = Convert.ToInt32(Console.ReadLine());

            while (initialvalue <= endvalue)
            {
                //Console.WriteLine("InitialValue:{0}", initialvalue);
                initialvalue++;
                if (initialvalue % 2 == 0)
                {
                    Console.WriteLine("{0} is even number", initialvalue);
                }
            }
            Console.ReadLine();
        }
    }
}
