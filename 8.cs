// Задать 6 случайных числа (любого числового типа), найти максимальное и вывести на консоль текстовое и числовое значение одним оператором используя формат.. C#
using System;

class Program
{
    static void Main()
    {
        Random random = new Random();

        // Генерация 6 случайных чисел
        int number1 = random.Next();
        int number2 = random.Next();
        int number3 = random.Next();
        int number4 = random.Next();
        int number5 = random.Next();
        int number6 = random.Next();

        // Нахождение максимального числа
        int maxNumber = Math.Max(Math.Max(Math.Max(Math.Max(number1, number2), number3), Math.Max(number4, number5)), number6);

        // Вывод на консоль с текстовым и числовым значением
        Console.WriteLine($"Максимальное число: {maxNumber} ({maxNumber})");
    }
}
