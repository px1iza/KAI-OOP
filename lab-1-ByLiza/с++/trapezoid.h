#include <iostream>
#include <cmath>

#ifndef TRAPEZOID_H
#define TRAPEZOID_H

class Trapezoid
{
private:
    double x1, y1;
    double x2, y2;
    double x3, y3;
    double x4, y4;

public:
    Trapezoid();
    Trapezoid(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4);
    Trapezoid(const Trapezoid &other);
    ~Trapezoid();

    double getX1() const;
    double getY1() const;
    double getX2() const;
    double getY2() const;
    double getX3() const;
    double getY3() const;
    double getX4() const;
    double getY4() const;

    double getPerimeter();
    double getArea();
};

#endif
