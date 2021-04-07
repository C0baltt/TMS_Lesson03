using System;

namespace DaysOfWeek
{
    class Program
    {
       /* enum DaysOfWeek
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }*/


        static void Main(string[] args)
        {
            Console.WriteLine("Введи день недели:");
            string temp = Console.ReadLine();

            string day;
            int numberOfDay;

            if ((temp == "Mon") || temp == "Monday")
            {
                day = "Monday = ";
                numberOfDay = 1;
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if ((temp == "Tue") || temp == "Tuesday")
            {
                day = "Tuesday = ";
                numberOfDay = 2;
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else if ((temp == "Wed") || temp == "Wednesday")
            {
                day = "Wednesday = ";
                numberOfDay = 3;
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else if ((temp == "Thu") || temp == "Thursday")
            {
                day = "Thursday = ";
                numberOfDay = 4;
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else if ((temp == "Fri") || temp == "Friday")
            {
                day = "Friday = ";
                numberOfDay = 5;
                Console.ForegroundColor = ConsoleColor.Magenta;
            }
            else if ((temp == "Sat") || temp == "Saturday")
            {
                day = "Saturday = ";
                numberOfDay = 6;
                Console.ForegroundColor = ConsoleColor.Cyan;
            }
            else if ((temp == "Sun") || temp == "Sunday")
            {
                day = "Sunday = ";
                numberOfDay = 7;
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            else 
            { 
                day = "Такого дня недели не существует!";
                numberOfDay = 0;
                Console.ForegroundColor = ConsoleColor.Red;
            }
            
            //Console.ForegroundColor = ConsoleColor.Green; // устанавливаем цвет
            Console.Write(day);
             if (numberOfDay != 0)
            {
                int daysBeforeTheWeekend = 6 - numberOfDay;
                if (daysBeforeTheWeekend < 0) daysBeforeTheWeekend = 0;
                Console.WriteLine($"{numberOfDay} До выходных осталось {daysBeforeTheWeekend} дней");
            }
            Console.ResetColor(); // сбрасываем в стандартный




            //var day = DayOfWeek.Friday;
            //Console.WriteLine("Hello World!");
        }
        
    }
}
