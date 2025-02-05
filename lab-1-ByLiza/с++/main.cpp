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
    cout << "  A(" << trapezoid.x1 << ", " << trapezoid.y1 << ")\n";
    cout << "  B(" << trapezoid.x2 << ", " << trapezoid.y2 << ")\n";
    cout << "  C(" << trapezoid.x3 << ", " << trapezoid.y3 << ")\n";
    cout << "  D(" << trapezoid.x4 << ", " << trapezoid.y4 << ")\n";

    double perimeter = trapezoid.getPerimeter();
    cout << "\nПериметр: " << perimeter << endl;

    double area = trapezoid.getArea();
    cout << "Площа: " << area << endl;

    return 0;
}