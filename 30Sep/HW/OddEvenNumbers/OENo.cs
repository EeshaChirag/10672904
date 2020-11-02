using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenNumbers
{
    class OENo
    {
		static void Main()
		{
			int number;
			Console.WriteLine("Enter the number to check if the number is odd or even: ");
			number = Convert.ToInt32(Console.ReadLine());
			if (number % 2 == 0)
			{
				Console.WriteLine("Number is even");
			}
			else
			{
				Console.WriteLine("Number is odd");
			}
			Console.ReadLine();
		}
	}

}
