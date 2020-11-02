using System;


namespace LoopAndCondition
{
    class SwitchEx
    {
		static void Main()
		{
			/*Switch(Case)
			{
				Case 1:
					Statements;
					break;
				....
				Case n:
					Statements;
					break;
				default:
					Statements:
					break;
			}*/
			//Code for days of the week
			int num;
			Console.Write("Enter the Number to find the week: ");
			num = Convert.ToInt32(Console.ReadLine());

			switch (num)
			{
				case 1:
					Console.WriteLine("Monday");
					break;
				case 2:
					Console.WriteLine("Tuesday");
					break;
				case 3:
					Console.WriteLine("Wednesday");
					break;
				case 4:
					Console.WriteLine("Thursday");
					break;
				case 5:
					Console.WriteLine("Friday");
					break;
				case 6:
					Console.WriteLine("Saturday");
					break;
				case 7:
					Console.WriteLine("Sunday");
					break;
				default:
					Console.WriteLine("Enter the number between 1 to 7");
					break;
			}
			Console.ReadLine();
		}
	}
}
