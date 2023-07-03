// 1.	Создать две строки из длиною случайно выбранного числа, сложить их. Вывести на консоль 1ю строку и колтичество символов  в суммарной строке. Вывод выполнить одним оператором. C#

using System;

class Program
{
    static void Main()
    {
        Random random = new Random();

        int randomLength1 = random.Next(1, 13);
        int randomLength2 = random.Next(1, 13);

        string str1 = new string('A', randomLength1);
        string str2 = new string('B', randomLength2);

        string concatenatedString = str1 + str2;

        Console.WriteLine($"Первая строка: {str1}, Количество символов: {concatenatedString.Length}");
    }
}
