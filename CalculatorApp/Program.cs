using System;

class Program
{
    static void Main()
    {
        ICalculator calculator = new Calculator();
        double? previousResult = null;

        while (true)
        {
            double num1;
            if (previousResult == null)
            {
                Console.WriteLine("\nВведите первое число:");
                if (!double.TryParse(Console.ReadLine(), out num1))
                {
                    Console.WriteLine("Ошибка! Введите корректное число.");
                    continue;
                }
            }
            else
            {
                num1 = previousResult.Value;
                Console.WriteLine($"\nПервое число: {num1} (используется предыдущий результат)");
            }

            Console.WriteLine("Введите второе число:");
            if (!double.TryParse(Console.ReadLine(), out double num2))
            {
                Console.WriteLine("Ошибка! Введите корректное число.");
                continue;
            }

            Console.WriteLine("Выберите операцию (+, -, *, /, %), или 'exit' для выхода:");
            string operation = Console.ReadLine();

            double result = 0;
            bool validOperation = true;

            switch (operation)
            {
                case "+":
                    result = calculator.Add(num1, num2);
                    break;
                case "-":
                    result = calculator.Subtract(num1, num2);
                    break;
                case "*":
                    result = calculator.Multiply(num1, num2);
                    break;
                case "/":
                    result = calculator.Divide(num1, num2);
                    break;
                case "%":
                    result = calculator.Modulo(num1, num2);
                    break;
                case "exit":
                    Console.WriteLine("Выход из программы.");
                    return;
                default:
                    Console.WriteLine("Ошибка! Неверная операция.");
                    validOperation = false;
                    break;
            }

            if (validOperation)
            {
                Console.WriteLine($"Результат: {result}");
                previousResult = result; // Запоминаем результат для следующей операции
            }

            Console.WriteLine("Хотите сбросить результат? (y/n):");
            if (Console.ReadLine().ToLower() == "y")
                previousResult = null; // Сбрасываем результат, если нужно
        }
    }
}
