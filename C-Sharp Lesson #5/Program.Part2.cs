using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifthLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());

            try
            {
                if (number == 2)
                    throw new ArgumentException("OMG! Number = 2");

                if (number == 4)
                    throw new ArgumentException("OMG! Number = 4");
            }
            catch (ArgumentException ex) when (ex.Message == "OMG! Number = 2")
            {
                Console.WriteLine("Number = 2");
            }
            catch (ArgumentException ex) when (ex.Message == "OMG! Number = 4")
            {
                Console.WriteLine("Number = 4");
            }

            Console.ReadKey();
        }
    }
}
