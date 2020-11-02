using System;


namespace BasicEg
{
    class Addition
    {
        static void Main()
        {
            int num1 = 30, num2 = 40, result;
            //Addition
            result = num1 + num2;
            Console.WriteLine("Addition of {0} and {1} is {2}", num1, num2, result);

            //Subtraction
            result = num2 - num1;
            Console.WriteLine("Subtraction of {1} from {0} is {2}",num1,num2, result);
            Console.ReadKey();
        }
    }
}
