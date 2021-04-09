using System;

namespace DaysOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 9; i++)
            {
                /*//====================для отладки, в финальной версии удалить=============================================
                //Для автоматической проверки раскоментируй здесь, закомментируй стоку 46
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
                    case 8:
                        temp = "Error";
                        break;
                    default:
                        break;
                }//*/
                //===================================================================

                //Для ручной проверки раскоментируй здесь, закомментируй стоку 19
                Console.WriteLine($"{i}\nВведи день недели. Для выхода введи \"quit\" или \"exit\" или \"q\"");
                string temp = Console.ReadLine();//*/
                temp = temp.Trim().ToLower();

                DayOfWeek day = DayOfWeek.Monday;

                bool thisDayDoesNotExist = false;

                switch (temp)
                {
                    case "mon" or "monday":
                        day = DayOfWeek.Monday;
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case "tue" or "tuesday":
                        day = DayOfWeek.Tuesday;
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case "wed" or "wednesday":                        
                        day = DayOfWeek.Wednesday;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case "thu" or "thursday":
                        day = DayOfWeek.Thursday;
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        break;
                    case "fri" or "friday":
                        day = DayOfWeek.Friday;
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        break;
                    case "sat" or "saturday":
                        day = DayOfWeek.Saturday;
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        break;
                    case "sun" or "sunday":
                        day = DayOfWeek.Sunday;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    case "quit" or "exit" or "q":
                        return;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Write("Такого дня недели не существует\n");
                        thisDayDoesNotExist = true;
                        //Console.ResetColor();

                        break;
                }               
                
                if (thisDayDoesNotExist == false)
                {
                    Console.Write($"{day}");
                    var daysBeforeTheWeekend = DayOfWeek.Saturday - day;
                    
                    if ((daysBeforeTheWeekend < 0) || (daysBeforeTheWeekend > 5))
                    { 
                        daysBeforeTheWeekend = 0; 
                    }
                    Console.WriteLine($". Порядковый номер дня недели {(int)day}. До выходных осталось {daysBeforeTheWeekend} дней");

                    Console.ResetColor(); // сбрасываем в стандартный

                    var numderOfDaysOfTheWeek = 7;//чтобы не было магических чисел, создаю переменную
                    if (DateTime.Today.DayOfWeek == day)
                    {
                        
                        Console.WriteLine($"Сегодня как раз {DateTime.Today.DayOfWeek}, следующий будет {DateTime.Today.AddDays(numderOfDaysOfTheWeek).ToShortDateString()}");
                        DateTime.Today.AddDays((int)DayOfWeek.Sunday);
                    }
                    else
                    {
                        var diferent = day - DateTime.Today.DayOfWeek;
                        if (diferent < 0) 
                        {
                            diferent += numderOfDaysOfTheWeek; 
                        }
                        Console.WriteLine($"Следующий день недели {day} будет {DateTime.Today.AddDays(diferent).ToShortDateString()}");
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