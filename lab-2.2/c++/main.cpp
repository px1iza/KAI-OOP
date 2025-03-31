#include <iostream>
#include "Ironman.h"

int main() {
    // Створення об'єктів
    Human human("John Doe", 30);
    Ironman tony("Tony Stark", 38, "Mark L", 9000);

    // Демонстрація поліморфізму через вказівник
    Human* ptr1 = &human;
    Human* ptr2 = &tony;

    std::cout << ptr1->identify() << std::endl; // Виклик методу Human
    std::cout << ptr2->identify() << std::endl; // Виклик методу Ironman (поліморфізм)

    return 0;
}
