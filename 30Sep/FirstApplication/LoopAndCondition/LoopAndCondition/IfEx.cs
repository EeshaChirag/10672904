using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopAndCondition
{
    class IfEx
    {
        static void Main()
        {
            int n1, n2, n3;
            Console.Write("1st Number:");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2nd Number:");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("3rd Number:");
            n3 = Convert.ToInt32(Console.ReadLine());

            if (n1 > n2)
            {
                if (n1 > n3)
                {
                    Console.WriteLine("{0} is the greatest among three numbers", n1);
                }
                else
                {
                    Console.WriteLine("{0} is the greatest among three numbers", n3);
                }
            }
            else if (n2 > n3)
            {
                Console.WriteLine("{0} is the greatest among three numbers", n2);
            }
            else
            {
                Console.WriteLine("{0} is the greatest among three numbers", n3);
            }
            Console.ReadLine();
        }
    }
}
