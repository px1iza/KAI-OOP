#include <iostream>
#include <cmath>
#ifndef RHOMBUS_H
#define RHOMBUS_H

class Rhombus
{
private:
    double _x1, _y1, _x2, _y2, _x3, _y3, _x4, _y4;

public:
    Rhombus();
    Rhombus(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4);
    Rhombus(const Rhombus &other);

    double Area();
    double Perimeter();
    std::string GetCoordinates();
    void Scale(double factor = 1.5);

    Rhombus operator*(double scalar);
    Rhombus operator-(Rhombus other);
};

#endif