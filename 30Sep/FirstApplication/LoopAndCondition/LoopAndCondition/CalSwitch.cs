using System;


namespace LoopAndCondition
{
    class CalSwitch
    {
		static void Main()
		{
			Console.Write("Enter the operation to be performed: ");
			string operation = Console.ReadLine();
			Console.Write("Input 1: ");
			int n1 = Convert.ToInt32(Console.ReadLine());
			Console.Write("Input 2: ");
			int n2 = Convert.ToInt32(Console.ReadLine());
			switch (operation)
			{
				case "+":
					Console.WriteLine("Addition: {0} ", (n1 + n2));
					break;
				case "-":
					Console.WriteLine("Subtraction: {0} ", (n1 - n2));
					break;
				case "*":
					Console.WriteLine("Multiplication: {0} ", (n1 * n2));
					break;
				case "%":
					Console.WriteLine("Division: {0} ", (n1 % n2));
					break;
				case "/":
					Console.WriteLine("Modulo: {0} ", (n1 / n2));
					break;
				default:
					Console.WriteLine("Invalid Operation");
					break;
			}
			Console.ReadLine();
		}
    }
}
