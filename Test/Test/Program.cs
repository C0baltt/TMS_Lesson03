using System;

//Эта программа для проверки работы отдельных кусков кода и для удобства лежит вместе с домашней работой

namespace Test
{
   
    class Program
    {
        static void Main(string[] args)
        {
            Operation op;
            op = Operation.Subtract;
            Console.WriteLine($"{op} - {(int)op}"); // Add

           
            //op = Operation.Multiply;
           // Console.WriteLine((int)op);

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
