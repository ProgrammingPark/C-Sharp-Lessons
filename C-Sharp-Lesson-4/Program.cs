using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthLesson
{
    class Program
    {
        static void Main()
        {
            double number = 5;

            int convertedNumber = Convert.ToInt32(number);
            int parsedNumber = int.Parse(number.ToString());

            Console.WriteLine($"Converted number {convertedNumber}");
            Console.WriteLine($"Parsed number {parsedNumber}");

            Console.ReadKey();
        }
    }
}
