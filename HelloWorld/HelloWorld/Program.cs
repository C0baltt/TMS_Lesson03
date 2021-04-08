using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadKey();

            //static void WriteDay(DayOfWeek day)
            for (var i = 1; i < 15; i++)
            {
                ConsoleColor colorOfTheDay = ConsoleColor.DarkBlue;
                //ConsoleColor colorOfTheDay = ConsoleColor[i];

                //Console.ForegroundColor = colorOfTheDay;
                Console.WriteLine(colorOfTheDay);
                Console.ResetColor();
            }

            /*public enum ConsoleColor
        {

            Black = 0,
            DarkBlue = 1,
            DarkGreen = 2,
            DarkCyan = 3,
            DarkRed = 4,
            DarkMagenta = 5,
            DarkYellow = 6,
            Gray = 7,
            DarkGray = 8,
            Blue = 9,
            Green = 10,
            Cyan = 11,
            Red = 12,
            Magenta = 13,
            Yellow = 14,
            White = 15
        }*/

        }
    }
}

