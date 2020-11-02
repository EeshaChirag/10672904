using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area
{
    class Square
    {
        static void Main()
        {
            int side;
            Console.WriteLine("Enter Width: ");
            side = Convert.TInt32(Console.ReadLine());

            Console.WriteLine("Area of the Square: {0}", (side * side));
            Console.ReadLine();
        }

    }
}
