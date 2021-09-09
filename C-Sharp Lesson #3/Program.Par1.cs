using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdLesson
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter value: ");
            string value = Console.ReadLine();

            var enumValue = Enum.Parse(typeof(Season), value);

            Console.WriteLine($"\n\nValue {(int)enumValue} name is {enumValue}");
            Console.ReadKey();
        }

        public enum Season
        {
            Winter = 5,
            Spring = 10,
            Summer = 15,
            Autumn = 20
        }
    }
}
