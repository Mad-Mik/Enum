using System;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Enum
            DayTime dayTime = DayTime.Morning;

            if (dayTime == DayTime.Morning)
                Console.WriteLine("Good Morning");
            else
                Console.WriteLine("Hello");
        }
        enum DayTime
        {
            Morning,
            Afternoon,
            Evening,
            Night
        }
    }
}
