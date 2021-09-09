using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            //var num = 10;

            //Console.WriteLine($"Result {num}");

            //var num1 = 10; var num2 = 5;

            //Console.WriteLine($"\n\nResult {num1} + {num2} = {num1 + num2}");
            //Console.WriteLine("\n\nResult " + (num1 + num2).ToString());

            //Console.Write("\nEnter num1 value: ");

            //num1 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("\nEnter num2- value: ");

            //num2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine($"\nResult {num1} + {num2} = {num1 + num2}");

            Console.WriteLine($"Integer: {int.MaxValue}");
            Console.WriteLine($"Long: {long.MaxValue}");

            uint num1 = 20;

            var num2 = 21.2m;

            bool num3 = num2 > num1;

            Console.WriteLine($"{num3.ToString()}");

            char num4 = 'a';
            string num5 = "top";

            Console.WriteLine(num5);
            Console.Write("Enter value: ");

            num5 = Console.ReadLine();

            Console.WriteLine(num5);

            Console.ReadKey();
        }
    }
}
