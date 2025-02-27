#include <iostream>
#include "trapezoid.h"
#include <cmath>

using namespace std;

int main()
{
    double x1, y1, x2, y2, x3, y3, x4, y4;

    cout << "Введіть координати трапеції (кожну пару чисел через пробіл):\n";

    cout << "  Вершина A (x1, y1): ";
    cin >> x1 >> y1;
    cout << "  Вершина B (x2, y2): ";
    cin >> x2 >> y2;
    cout << "  Вершина C (x3, y3): ";
    cin >> x3 >> y3;
    cout << "  Вершина D (x4, y4): ";
    cin >> x4 >> y4;

    Trapezoid trapezoid(x1, y1, x2, y2, x3, y3, x4, y4);

    cout << "\nТрапеція має координати:\n";
    cout << "  A(" << trapezoid.getX1() << ", " << trapezoid.getY1() << ")\n";
    cout << "  B(" << trapezoid.getX2() << ", " << trapezoid.getY2() << ")\n";
    cout << "  C(" << trapezoid.getX3() << ", " << trapezoid.getY3() << ")\n";
    cout << "  D(" << trapezoid.getX4() << ", " << trapezoid.getY4() << ")\n";
    double perimeter = trapezoid.getPerimeter();
    cout << "\nПериметр: " << perimeter << endl;

    double area = trapezoid.getArea();
    cout << "Площа: " << area << endl;

        Trapezoid copyTrapezoid(trapezoid);
    cout << "\nКопія трапеції створена.\n";
    cout << "\nКопія трапеції має координати:\n";
    cout << "  A(" << copyTrapezoid.getX1() << ", " << copyTrapezoid.getY1() << ")\n";
    cout << "  B(" << copyTrapezoid.getX2() << ", " << copyTrapezoid.getY2() << ")\n";
    cout << "  C(" << copyTrapezoid.getX3() << ", " << copyTrapezoid.getY3() << ")\n";
    cout << "  D(" << copyTrapezoid.getX4() << ", " << copyTrapezoid.getY4() << ")\n";
}
