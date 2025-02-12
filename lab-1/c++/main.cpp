#include <iostream>
#include "Triangle.h"

int main()
{
    // Змінні для зчитування координат
    double x1, y1, x2, y2, x3, y3;

    std::cout << "Введіть координати трикутника (x1, y1, x2, y2, x3, y3): ";
    std::cin >> x1 >> y1 >> x2 >> y2 >> x3 >> y3;

    // Створення об'єкта трикутника з введеними координатами
    Triangle triangle(x1, y1, x2, y2, x3, y3);
    Triangle triangle2(x1, y1, x2, y2, x3, y3);
    Triangle triangle3(x1, y1, x2, y2, x3, y3);

    // Виведення збережених координат
    std::cout << "\nТрикутник має координати:\n";
    std::cout << "  A(" << triangle.getX1() << ", " << triangle.getY1() << ")\n";
    std::cout << "  B(" << triangle.getX2() << ", " << triangle.getY2() << ")\n";
    std::cout << "  C(" << triangle.getX3() << ", " << triangle.getY3() << ")\n";

    // Обчислення та виведення периметра
    double perimeter = triangle.getPerimeter();
    std::cout << "\nПериметр: " << perimeter << std::endl;

    // Обчислення та виведення площі
    double area = triangle.getArea();
    std::cout << "Площа: " << area << std::endl;

    // Виклик деструктора в heap
    Triangle *triangle4 = new Triangle(x1, y1, x2, y2, x3, y3);
    delete triangle4;

    // // Виклик конструктора копії
    // Triangle triangle3 = triangle;
    //     // Виведення збережених координат
    // std::cout << "\nТрикутник копія має координати:\n";
    // std::cout << "  A(" << triangle3.getX1() << ", " << triangle3.getY1() << ")\n";
    // std::cout << "  B(" << triangle3.getX2() << ", " << triangle3.getY2() << ")\n";
    // std::cout << "  C(" << triangle3.getX3() << ", " << triangle3.getY3() << ")\n";

    return 0;
}
