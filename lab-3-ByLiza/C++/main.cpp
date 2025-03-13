#include <iostream>
#include "Rhombus.h"

using namespace std;

int main()
{
    Rhombus P1;
    Rhombus P2(56, 47, 53, 45, 64, 89, 76, 78);
    Rhombus P3(P2);
    // три об'єкти P1, P2, P3, використовуючи різні конструктори
    Rhombus P4 = P3 * 3;
    cout << P4.GetCoordinates() << endl;
    P1 = P3 - P2;
    cout << P1.GetCoordinates() << endl;

    return 0;
}