﻿using System;

//Эта программа для проверки работы отдельных кусков кода и для удобства лежит вместе с домашней работой

namespace Test
{
    /*
     (*) если введенный день сегодня - вывести "{xx} - это сегодня"
     (**) вывести дату ближайшего дня недели который совпадает с введенным. 
    Если день сегодняшний, то дата нужна через неделю.
    */
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"DateTime.Now -- {DateTime.Now}");//07.04.2021 10:54:30
            Console.WriteLine($"DateTime.UtcNow -- {DateTime.UtcNow}");//07.04.2021 7:54:30
            Console.WriteLine($"DateTime.Today -- {DateTime.Today}");//07.04.2021 0:00:00
            
            Console.WriteLine($"DateTime.Today.DayOfWeek -- {DateTime.Today.DayOfWeek}");

            Console.ReadLine();
        }
    }
    enum Operation
    {
        Add = 1,
        Subtract,
        Multiply,
        Divide
    }

}

/* Operation op;
 op = Operation.Subtract;
 Console.WriteLine($"{op} - {(int)op}"); // Add


 //op = Operation.Multiply;
// Console.WriteLine((int)op);*/