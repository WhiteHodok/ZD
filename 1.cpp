// 1.   Создать вектор из всех базовых типов данных с++, вывести на консоль
#include <iostream>
#include <vector>

int main() {
    std::vector<int> myVector;              // Вектор целых чисел
    std::vector<char> myVectorChar;         // Вектор символов
    std::vector<bool> myVectorBool;         // Вектор булевых значений
    std::vector<float> myVectorFloat;       // Вектор чисел с плавающей точкой (одинарной точности)
    std::vector<double> myVectorDouble;     // Вектор чисел с плавающей точкой (двойной точности)
    std::vector<long> myVectorLong;         // Вектор длинных целых чисел
    std::vector<long long> myVectorLongLong; // Вектор очень длинных целых чисел

    // Заполняем векторы примерными значениями
    myVector.push_back(1);
    myVectorChar.push_back('a');
    myVectorBool.push_back(true);
    myVectorFloat.push_back(3.14f);
    myVectorDouble.push_back(3.14159);
    myVectorLong.push_back(1234567890);
    myVectorLongLong.push_back(9876543210987654321LL);

    // Выводим содержимое векторов на консоль
    for (int i : myVector) {
        std::cout << i << " ";
    }
    std::cout << std::endl;

    for (char c : myVectorChar) {
        std::cout << c << " ";
    }
    std::cout << std::endl;

    for (bool b : myVectorBool) {
        std::cout << std::boolalpha << b << " ";
    }
    std::cout << std::endl;

    for (float f : myVectorFloat) {
        std::cout << f << " ";
    }
    std::cout << std::endl;

    for (double d : myVectorDouble) {
        std::cout << d << " ";
    }
    std::cout << std::endl;

    for (long l : myVectorLong) {
        std::cout << l << " ";
    }
    std::cout << std::endl;

    for (long long ll : myVectorLongLong) {
        std::cout << ll << " ";
    }
    std::cout << std::endl;

    return 0;
}

