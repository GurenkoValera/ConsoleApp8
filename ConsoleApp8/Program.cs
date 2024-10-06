using System;

class Program
{
    static void Main()
    {
        // Ввод действительного числа x
        Console.Write("Введите действительное число x: ");
        double x = Convert.ToDouble(Console.ReadLine());

        // Вычисление выражения 3x^4 - 5x^3 + 2x^2 - x + 7
        double x2 = x * x;
        double x3 = x2 * x;
        double x4 = x2 * x2;
        double result = 3 * x4 - 5 * x3 + 2 * x2 - x + 7;

        // Вывод результата
        Console.WriteLine("Результат: " + result);
    }
}
