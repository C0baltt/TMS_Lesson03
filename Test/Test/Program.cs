//Эта программа для проверки работы отдельных кусков кода и для удобства лежит вместе с домашней работой

using System;

namespace Test

{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string day = Console.ReadLine();
                bool isCorrect = true;
                DayOfWeek days = DayOfWeek.Monday; //создаем переменную days на основе enum DayOfWeek

                switch (day.ToLower())//приводим строку day к нижнему регистру
                {
                    case "monday" or "mon":
                        break;
                    case "tuesday" or "tue":
                        days = DayOfWeek.Tuesday;
                        break;
                    case "wednesday" or "wed":
                        days = DayOfWeek.Wednesday;
                        break;
                    case "thursday" or "thu":
                        days = DayOfWeek.Thursday;
                        break;
                    case "friday" or "fri":
                        days = DayOfWeek.Friday;
                        break;
                    case "saturday" or "sat":
                        days = DayOfWeek.Saturday;
                        break;
                    case "sunday" or "sun":
                        days = DayOfWeek.Sunday;
                        break;
                    default:
                        isCorrect = false;
                        break;
                }

                if (isCorrect)
                {
                    WriteDay(days);
                }
                else
                {
                    Console.WriteLine("There is no such day in week");
                }
            }
        }
        static void WriteDay(DayOfWeek day)//ConsoleColorv colorOfTheDay
        {
            var colorOfTheDay = day + 1;
            var todayDay = DateTime.Now.DayOfWeek;

            if (todayDay == day)
            {
                Console.Write("Today is ");
            }

            Console.ForegroundColor = (ConsoleColor)colorOfTheDay;
            Console.WriteLine($"{day} - {(int)day}");
            Console.ResetColor();
            
            if ((int)day != 6 && day != 0)
            {
                Console.WriteLine($"{(int)(6 - day)} days till weekends");
            }
            else
            {
                Console.WriteLine($"You are on the weekends!");
            }

            int daysTillNext = todayDay >= day ? day + 7 - todayDay : day - todayDay;
            Console.Write($"The next {day} will be on ");
            Console.WriteLine(DateTime.Now.AddDays(daysTillNext).ToShortDateString());
        }
    }
}


/* 
            Operation op;
            op = Operation.Subtract;
            Console.WriteLine($"{op} - {(int)op}"); // Add

            Console.WriteLine($"DateTime.Now -- {DateTime.Now}");//07.04.2021 10:54:30
            Console.WriteLine($"DateTime.UtcNow -- {DateTime.UtcNow}");//07.04.2021 7:54:30
            Console.WriteLine($"DateTime.Today -- {DateTime.Today}");//07.04.2021 0:00:00
            
            Console.WriteLine($"DateTime.Today.DayOfWeek -- {(int)DateTime.Today.DayOfWeek}");

            Console.ReadLine();


 Operation op;
 op = Operation.Subtract;
 Console.WriteLine($"{op} - {(int)op}"); // Add


 //op = Operation.Multiply;
// Console.WriteLine((int)op);*/