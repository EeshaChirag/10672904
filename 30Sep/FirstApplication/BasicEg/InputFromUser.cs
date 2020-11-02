using System;


namespace BasicEg
{
    class InputFromUser
    {
		static void Main()
		{
			string Name, City;
			int Age;
			Console.Write("Enter your Name: ");
			Name = Console.ReadLine(); //Console.Read; - Input from User
			Console.Write("Enter your City: ");
			City = Console.ReadLine();
			Console.Write("Enter your Age: ");
			Age = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("-----------------");
			Console.WriteLine("Name: {0} ||City: {1} ||Age: {2} ", Name, City, Age);
			Console.Read();
		}
	}
}
