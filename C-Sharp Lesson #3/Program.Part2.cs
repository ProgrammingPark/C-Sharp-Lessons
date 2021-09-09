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
            var schoolGradeLevel = GradeLevel.Elementary | GradeLevel.High | GradeLevel.Middle;

            Console.WriteLine($"School gradelevel value - {(int)schoolGradeLevel}");
            Console.ReadKey();
        }

        public enum Season
        {
            Winter = 5,
            Spring = 10,
            Summer = 15,
            Autumn = 20
        }

        [Flags]
        public enum GradeLevel
        {
            Elementary = 1,
            Middle = 2,
            High = 4
        }
    }
}
