using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixthLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter temperature: ");
            int temp = int.Parse(Console.ReadLine());

            //if (temp > 25)
            //    Console.WriteLine("Temp is perfect!");
            //else if (temp == 20)
            //    Console.WriteLine("Temp is good!");
            //else
            //    Console.WriteLine("Temp is cold!");

            //bool isCold = false;

            //if (!isCold)
            //    Console.WriteLine("Temp is good!");

            Console.WriteLine($"Temp is {(temp > 25 ? "Good" : "Cold")}");

            Console.ReadKey();
        }
    }
}
