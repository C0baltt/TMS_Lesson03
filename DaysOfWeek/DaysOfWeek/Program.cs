﻿using System;

namespace DaysOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i =1; i < 8; i++)
            {
                /* Для ручной проверки раскоментируй здесь, закомментируй стоку 19
                Console.WriteLine($"{i}\nВведи день недели:");
                string temp = Console.ReadLine();//*/

                 //Для автоматической проверки раскоментируй здесь, закомментируй стоку 15
                 string temp = null;
                switch (i)
                {
                    case 1:
                        temp = "Mon";
                        break;
                    case 2:
                        temp = "Tue";
                        break;
                    case 3:
                        temp = "Wed";
                        break;
                    case 4:
                        temp = "Thu";
                        break;
                    case 5:
                        temp = "Fri";
                        break;
                    case 6:
                        temp = "Sat";
                        break;
                    case 7:
                        temp = "Sun";
                        break;
                    default:
                        break;
                }//*/

                string day;
                int numberOfDay;

                if ((temp == "Mon") || temp == "Monday")
                {
                    day = "Monday";
                    numberOfDay = 1;
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else if ((temp == "Tue") || temp == "Tuesday")
                {
                    day = "Tuesday";
                    numberOfDay = 2;
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else if ((temp == "Wed") || temp == "Wednesday")
                {
                    day = "Wednesday";
                    numberOfDay = 3;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else if ((temp == "Thu") || temp == "Thursday")
                {
                    day = "Thursday";
                    numberOfDay = 4;
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                else if ((temp == "Fri") || temp == "Friday")
                {
                    day = "Friday";
                    numberOfDay = 5;
                    Console.ForegroundColor = ConsoleColor.Magenta;
                }
                else if ((temp == "Sat") || temp == "Saturday")
                {
                    day = "Saturday";
                    numberOfDay = 6;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                else if ((temp == "Sun") || temp == "Sunday")
                {
                    day = "Sunday";
                    numberOfDay = 7;
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                else
                {
                    day = "Такого дня недели не существует!";
                    numberOfDay = 0;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                }

                Console.Write($"{day} = ");
                if (numberOfDay != 0)
                {
                    int daysBeforeTheWeekend = 6 - numberOfDay;
                    if (daysBeforeTheWeekend < 0) daysBeforeTheWeekend = 0;
                    Console.WriteLine($"{numberOfDay} До выходных осталось {daysBeforeTheWeekend} дней");

                    Console.ResetColor(); // сбрасываем в стандартный

                    if ((int)DateTime.Today.DayOfWeek == numberOfDay)
                    {
                        Console.WriteLine($"Сегодня как раз {DateTime.Today.DayOfWeek}, следующий будет {DateTime.Today.AddDays(7)}");
                    }
                    else
                    {
                        int diferent = numberOfDay - (int)DateTime.Today.DayOfWeek;
                        if (diferent < 0) diferent += 7;
                        Console.WriteLine($"Следующий день недели {day} будет {DateTime.Today.AddDays(diferent)}");
                    }
                }
                Console.ResetColor(); // сбрасываем в стандартный
                Console.WriteLine();
            }
            
        }

    }
}
/*
     (*) если введенный день сегодня - вывести "{xx} - это сегодня"
     (**) вывести дату ближайшего дня недели который совпадает с введенным. 
    Если день сегодняшний, то дата нужна через неделю.
    */