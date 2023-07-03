// Задать 4 случайных числа (любого числового типа), найти максимальное и вывести на консоль текстовое и числовое значение одним оператором используя формат. С++

#include <iostream>
#include <cstdlib>
#include <ctime>

int main()
{
    std::srand(static_cast<unsigned>(std::time(nullptr)));

    // Генерация 4 случайных чисел
    int number1 = std::rand();
    int number2 = std::rand();
    int number3 = std::rand();
    int number4 = std::rand();

    // Нахождение максимального числа
    int maxNumber = std::max({number1, number2, number3, number4});

    // Вывод на консоль с текстовым и числовым значением
    std::cout << "Максимальное число: " << maxNumber << " (" << maxNumber << ")" << std::endl;

    return 0;
}
