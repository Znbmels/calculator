using System;

public class Calculator : ICalculator
{
    public double Add(double a, double b) => a + b;
    public double Subtract(double a, double b) => a - b;
    public double Multiply(double a, double b) => a * b;

    public double Divide(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("Ошибка: Деление на ноль!");
            return double.NaN;
        }
        return a / b;
    }

    public double Modulo(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("Ошибка: Деление на ноль!");
            return double.NaN;
        }
        return a % b;
    }
}
