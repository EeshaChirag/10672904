using System;

namespace Student
{
    class StudentDetails
    {
        static void Main()
        {
            string FName, LName;
            int Id, CNo;
            Console.WriteLine("Enter Student Id: ");
            Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Student First Name: ");
            FName = Console.ReadLine();
            Console.WriteLine("Enter Student Last Name: ");
            LName = Console.ReadLine();
            Console.WriteLine("Enter Contact Number: ");
            CNo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("Id: {0}||First Name: {1}|| Last Name: {2}|| Contact Number: {3}", Id, FName, LName, CNo);
            Console.ReadLine();
        }

    }
}
