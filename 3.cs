// Создать две строки из  случайного числа  в переделах 12 на языке C#
using System;

class Program
{
    static void Main()
    {
        Random random = new Random();

        int randomNumber1 = random.Next(1, 13);
        int randomNumber2 = random.Next(1, 13);

        string str1 = randomNumber1.ToString();
        string str2 = randomNumber2.ToString();

        Console.WriteLine("Строка 1: " + str1);
        Console.WriteLine("Строка 2: " + str2);
    }
}
