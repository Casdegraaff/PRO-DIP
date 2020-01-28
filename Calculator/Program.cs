using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter num1: ");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter operator: ");
string op = Console.ReadLine();

Console.Write("Enter num2: ");
double num2 = Convert.ToDouble(Console.ReadLine());

if (op == "+"){
     Console.WriteLine(num1 + num2);
} else if (op == "-"){
     Console.WriteLine(num1 - num2);
} else if (op == "/"){
     Console.WriteLine(num1 / num2);
} else if (op == "*"){
     Console.WriteLine(num1 * num2);
} else {
     Console.WriteLine("Invalid Operator");
}
        }
    }
}
