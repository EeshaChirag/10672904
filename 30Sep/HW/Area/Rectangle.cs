using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area
{
    class Rectangle
    {
        static void Main()
        {
            int width, height;
            Console.WriteLine("Enter Height: ");
            height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Width:");
            width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Area of Rectangle:{0}", (height * width));
            Console.ReadLine();

        }
    }

}
