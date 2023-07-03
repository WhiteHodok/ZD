// 2.   Создать вектор из всех базовых типов данных C# вывести на консоль
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> myVectorInt = new List<int>();               // Список целых чисел
        List<char> myVectorChar = new List<char>();             // Список символов
        List<bool> myVectorBool = new List<bool>();             // Список булевых значений
        List<float> myVectorFloat = new List<float>();           // Список чисел с плавающей точкой (одинарной точности)
        List<double> myVectorDouble = new List<double>();         // Список чисел с плавающей точкой (двойной точности)
        List<long> myVectorLong = new List<long>();             // Список длинных целых чисел

        // Заполняем списки примерными значениями
        myVectorInt.Add(1);
        myVectorChar.Add('a');
        myVectorBool.Add(true);
        myVectorFloat.Add(3.14f);
        myVectorDouble.Add(3.14159);
        myVectorLong.Add(1234567890);

        // Выводим содержимое списков на консоль
        foreach (int i in myVectorInt)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();

        foreach (char c in myVectorChar)
        {
            Console.Write(c + " ");
        }
        Console.WriteLine();

        foreach (bool b in myVectorBool)
        {
            Console.Write(b + " ");
        }
        Console.WriteLine();

        foreach (float f in myVectorFloat)
        {
            Console.Write(f + " ");
        }
        Console.WriteLine();

        foreach (double d in myVectorDouble)
        {
            Console.Write(d + " ");
        }
        Console.WriteLine();

        foreach (long l in myVectorLong)
        {
            Console.Write(l + " ");
        }
        Console.WriteLine();
    }
}