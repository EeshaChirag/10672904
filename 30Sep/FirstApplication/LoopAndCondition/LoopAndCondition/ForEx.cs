using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopAndCondition
{
    class ForEx
    {
        //Print the table.
        static void Main()
        {
            int table,n;
            Console.Write("Enter the table to be printed: ");
            table = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number: ");
            n = Convert.ToInt32(Console.ReadLine());
            //for(Initialization; condition ; increment/decrement)
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}*{1}={2}", table, i, (i * table));
            }
            Console.Read();
        }
    }
}
