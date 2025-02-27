#include <iostream>
#include "trapezoid.h"
#include <cmath>

Trapezoid::Trapezoid()
{
    x1 = y1 = x2 = y2 = x3 = y3 = x4 = y4 = 0.0;
}

Trapezoid::Trapezoid(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
{
    this->x1 = x1;
    this->y1 = y1;
    this->x2 = x2;
    this->y2 = y2;
    this->x3 = x3;
    this->y3 = y3;
    this->x4 = x4;
    this->y4 = y4;
}

Trapezoid::Trapezoid(const Trapezoid &other)
{
    x1 = other.x1;
    y1 = other.y1;
    x2 = other.x2;
    y2 = other.y2;
    x3 = other.x3;
    y3 = other.y3;
    x4 = other.x4;
    y4 = other.y4;
}

Trapezoid::~Trapezoid()
{
    std::cout << "Трапеція знищена" << std::endl;
}

double Trapezoid::getX1() const { return x1; }
double Trapezoid::getY1() const { return y1; }
double Trapezoid::getX2() const { return x2; }
double Trapezoid::getY2() const { return y2; }
double Trapezoid::getX3() const { return x3; }
double Trapezoid::getY3() const { return y3; }
double Trapezoid::getX4() const { return x4; }
double Trapezoid::getY4() const { return y4; }

double Trapezoid::getPerimeter()
{
    double sideA = std::sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
    double sideB = std::sqrt((x4 - x3) * (x4 - x3) + (y4 - y3) * (y4 - y3));
    double sideC = std::sqrt((x3 - x2) * (x3 - x2) + (y3 - y2) * (y3 - y2));
    double sideD = std::sqrt((x4 - x1) * (x4 - x1) + (y4 - y1) * (y4 - y1));

    return sideA + sideB + sideC + sideD;
}

double Trapezoid::getArea()
{
    double baseA = std::sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
    double baseB = std::sqrt((x4 - x3) * (x4 - x3) + (y4 - y3) * (y4 - y3));
    double height = std::abs(y3 - y1);
    return (baseA + baseB) * height / 2.0;
}
