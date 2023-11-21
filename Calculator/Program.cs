using System;

namespace CalculatorApp
{
    class Program: Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в калькулятор");
            Console.WriteLine("Пожалуйста введите первое число:");

            double firstNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Пожалуйста введите второе число:");

            double secondNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Выберите математическую операцию:");
            Console.WriteLine("+: для сложения");
            Console.WriteLine("-: для вычитания");
            Console.WriteLine("*: для умножения");
            Console.WriteLine("/: для деления");

            char operand = char.Parse(Console.ReadLine());

            double result;

            switch (operand)
            {
                case '+':
                    result = Add(firstNumber, secondNumber);
                    Console.WriteLine($"Результат операции: {result}");
                    break;
                case '-':
                    result = Subtract(firstNumber, secondNumber);
                    Console.WriteLine($"Результат операции: {result}");
                    break;
                case '*':
                    result = Multiply(firstNumber, secondNumber);
                    Console.WriteLine($"Результат операции: {result}");
                    break;
                case '/':
                    if (secondNumber != 0)
                    {
                        result = Divide(firstNumber, secondNumber);
                        Console.WriteLine($"Результат операции: {result}");
                    }
                    else
                    {
                        Console.WriteLine("Попытка деления на нуль");
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("Неверный оператор");
                    break;
            }
        }
    }
}