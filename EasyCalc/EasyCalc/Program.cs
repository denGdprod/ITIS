using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Простой калькулятор");
        Console.WriteLine("Введите первое число:");
        double number1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите оператор (+, -, *, /):");
        char operation = Convert.ToChar(Console.ReadLine());

        Console.WriteLine("Введите второе число:");
        double number2 = Convert.ToDouble(Console.ReadLine());

        double result = 0;

        switch (operation)
        {
            case '+':
                result = number1 + number2;
                break;
            case '-':
                result = number1 - number2;
                break;
            case '*':
                result = number1 * number2;
                break;
            case '/':
                if (number2 == 0)
                {
                    Console.WriteLine("Ошибка: Деление на ноль невозможно.");
                    return;
                }
                result = number1 / number2;
                break;
            default:
                Console.WriteLine("Неверный оператор");
                return;
        }

        Console.WriteLine($"Результат: {number1} {operation} {number2} = {result}");
    }
}
