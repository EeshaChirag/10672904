using System;


namespace Area
{
    class AreaSR
    {
        static void Square()
        {
            int side;
            Console.WriteLine("Enter Width: ");
            side = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Area of the Square: {0}", (side * side));
        }
        static void Rectangle()
        {
            int width, height;
            Console.WriteLine("Enter Height: ");
            height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Width:");
            width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Area of Rectangle:{0}", (height* width));
        }
        static void Main()
        {
            Square();
            Rectangle();
            Console.ReadLine();
        }
    }
}
