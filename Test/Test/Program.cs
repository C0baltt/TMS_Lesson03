using System;

namespace Test
{
    enum Operation
    {
        Add = 1,
        Subtract,
        Multiply,
        Divide
    }
    class Program
    {
        static void Main(string[] args)
        {
            Operation op;
            op = Operation.Add;
            Console.WriteLine(op); // Add

            Console.ReadLine();
        }
    }

}
