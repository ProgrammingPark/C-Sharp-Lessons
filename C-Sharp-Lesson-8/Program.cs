using System;

namespace EightLesson
{
    class Program
    {
        static int Main(string[] args)
        {
            Console.Write("Today:");
            int temperature = int.Parse(Console.ReadLine());
            Console.Write("Prev day:");
            int prevDayTemperature = int.Parse(Console.ReadLine());

            switch ((temperature, prevDayTemperature))
            {
                case (> 0, > 0) when temperature == prevDayTemperature:
                    return 0;
                case (> 0, > 0):
                    return 1;
                default:
                    return 2;
            }
        }
    }
}
