using System;

class Calculator
{
    static void Main(string[] args)
    {
        if (args.Length != 3)
        {
            Console.WriteLine("Требуется ввести <число1> <действие +-*/> <число2>");
            return;
        }

        double num1, num2, result;
        char operation;

        if (!double.TryParse(args[0], out num1) || !double.TryParse(args[2], out num2) || args[1].Length != 1)
        {
            Console.WriteLine("Ввод только чисел!");
            return;
        }

        operation = args[1][0];

        switch (operation)
        {
            case '+':
                result = num1 + num2;
                Console.WriteLine($"Result: {num1} + {num2} = {result}");
                break;
            case '-':
                result = num1 - num2;
                Console.WriteLine($"Result: {num1} - {num2} = {result}");
                break;
            case '*':
                result = num1 * num2;
                Console.WriteLine($"Result: {num1} * {num2} = {result}");
                break;
            case '/':
                if (num2 == 0)
                {
                    Console.WriteLine("На ноль делить нельзя!");
                    return;
                }
                result = num1 / num2;
                Console.WriteLine($"Result: {num1} / {num2} = {result}");
                break;
            default:
                Console.WriteLine("Не верное действие, только +-*/!");
                break;
        }
    }
}