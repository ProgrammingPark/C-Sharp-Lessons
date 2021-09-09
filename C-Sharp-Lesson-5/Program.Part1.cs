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
            int dividend = 0, divisor = 0, result = 0;
            
            try
            {
                Console.Write("Enter dividend: ");
                dividend = int.Parse(Console.ReadLine());

                Console.Write("Enter divisor: ");
                divisor = int.Parse(Console.ReadLine());

                result = dividend / divisor;
            }
            catch (DivideByZeroException ex)
            {
                divisor++;
            }
            catch (FormatException ex)
            {
                divisor = dividend;
            }
            finally
            {
                result = dividend / divisor;
                Console.WriteLine($"Result: {result}");
            }

            Console.ReadKey();
        }
    }
}

//P.S I removed code duplication. I moved code "result = dividend / divisor" to block finally;
