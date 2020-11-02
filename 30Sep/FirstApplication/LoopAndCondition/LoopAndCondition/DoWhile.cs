using System;


namespace LoopAndCondition
{
    class DoWhile
    {
        static void Main()
        {
            /*do
            {
            } while (condition) ;*/
            int endvalue, initialvalue = 1;
            Console.Write("Enter the number:");
            endvalue = Convert.ToInt32(Console.ReadLine());
            while (initialvalue > endvalue)
            {
                Console.WriteLine("Inside While");
            }
            Console.WriteLine("--------------------");
            do
            {
                Console.WriteLine("Initial Value:{0}", initialvalue);
                initialvalue++;
            } while (initialvalue > endvalue);
            Console.Read();
        }
    }
}
