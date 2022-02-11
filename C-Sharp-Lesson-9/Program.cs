using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            for (i = 0, Console.WriteLine("Cycle start"); i < 5; i++, Console.WriteLine(i))
            {
                //if (i == 2)
                //    break;

                if (i % 2 == 0)
                    continue;
            }

            int n = 0;

            do
            {
                Console.WriteLine("Do");
                n++;
            }
            while (n < 0);

            n = 0;

            while (n < 0)
            {
                Console.WriteLine("While");
                n++;
            }

            Console.ReadKey();
        }
    }
}
