using System;

class Program
{
	static double GetNumberFromUser(string prompt)
	{
		while (true)
		{
			Console.WriteLine(prompt);
			string input = Console.ReadLine();

			if (double.TryParse(input, out number))
			{
				return number;
			}
			else
			{
				Console.WriteLine("Ошибка: Введите корректное число.");
			}
		}
	}
	static void Main(string[] args)
	{
		Console.WriteLine("Простой калькулятор");

		double number1 = GetNumberFromUser("Введите первое число:");

		Console.WriteLine("Введите оператор (+, -, *, /):");

		char operation = Convert.ToChar(Console.ReadLine());

		double number2 = GetNumberFromUser("Введите второе число:");

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
