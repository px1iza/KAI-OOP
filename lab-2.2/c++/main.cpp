#include <iostream>
#include "Ironman.h"

int main() {
    // Створення об'єктів
    Human human("John Doe", 30);
    Ironman tony("Tony Stark", 38, "Mark L", 9000);

    // Демонстрація поліморфізму через вказівник
    Human* ptr1 = &human;
    Human* ptr2 = &tony;

    std::cout << "1. Pointers case" << std::endl;
    std::cout << ptr1->identify() << std::endl; // Виклик методу Human
    std::cout << ptr2->identify() << std::endl; // Виклик методу Ironman (поліморфізм)

    // Демонстрація поліморфізму через посилання
    Human& ref1 = human;  // Посилання на Human
    Human& ref2 = tony;   // Посилання на Ironman

    std::cout << "\n2. References case" << std::endl;
    std::cout << ref1.identify() << std::endl; // Виклик методу Human
    std::cout << ref2.identify() << std::endl; // Виклик методу Ironman (поліморфізм)


    // Демонстрація поліморфізму через посилання
    Human humanPointless = human;  // Посилання на Human
    Human tonyPointless = tony;   // Посилання на Ironman

    std::cout << "\n3. Without References case" << std::endl;
    std::cout << humanPointless.identify() << std::endl; // Виклик методу Human
    std::cout << tonyPointless.identify() << std::endl; // Виклик методу Ironman (поліморфізм не працює)

    return 0;
}
