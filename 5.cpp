// Создать две строки из длиною случайно выбранного числа, сложить их. Вывести на консоль 1ю строку и колтичество символов  в суммарной строке. Вывод выполнить одним оператором. C++
#include <iostream>
#include <string>
#include <cstdlib>
#include <ctime>

int main()
{
    std::srand(std::time(nullptr));

    int randomLength1 = std::rand() % 12 + 1;
    int randomLength2 = std::rand() % 12 + 1;

    std::string str1(randomLength1, 'A');
    std::string str2(randomLength2, 'B');

    std::string concatenatedString = str1 + str2;

    std::cout << "Первая строка: " << str1 << ", Количество символов: " << concatenatedString.length() << std::endl;

    return 0;
}
