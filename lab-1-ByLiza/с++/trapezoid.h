#include <iostream>
#include <cmath>

#ifndef TRAPEZOID_H
#define TRAPEZOID_H

class Trapezoid
{

public:
    double x1, y1;
    double x2, y2;
    double x3, y3;
    double x4, y4;

    Trapezoid();
    Trapezoid(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4);

    double getPerimeter();
    double getArea();
};

#endif // TRAPEZOID_H