using System;
//Scope of the vaiable, multiple methods in a class with return type
namespace BasicEg
{
    class Calculator
    {
		//global
		float num1 = 80, num2 = 25;
		//Method without return type
		void Add()
		{
			//Local to the method
			//float num1 = 80, num2 = 25, result;
			//New space is created for result
			//result = num1 + num2;
			//Console.WriteLine("Addition: {0}", result)	

			//Efficient way of coding
			Console.WriteLine("Addition: {0}", (num1 + num2));
		}
		// Method with return type
		float Sub()
		{
			return (num1 - num2);
		}
		static void Main()
        {
			//Object creation
			//Classname object = new classname()
			//Function+f9 key to set break point
			Calculator obj = new Calculator();
			obj.Add();
            //one way of creating object for return type method sub- not optimised
            //float Subtract = obj.Sub();
            //Console.WriteLine("Subtract: {0}", Subtract);
            //optimized
            Console.WriteLine("Subtract: {0}", obj.Sub());
			Console.ReadKey();
		}
	}
}
