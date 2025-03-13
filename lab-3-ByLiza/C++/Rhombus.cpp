#include "Rhombus.h"

Rhombus::Rhombus() : _x1(0), _y1(0), _x2(0), _y2(0), _x3(0), _y3(0), _x4(0), _y4(0) {}

Rhombus::Rhombus(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
{
    this->_x1 = x1;
    this->_y1 = y1;
    this->_x2 = x2;
    this->_y2 = y2;
    this->_x3 = x3;
    this->_y3 = y3;
    this->_x4 = x4;
    this->_y4 = y4;
}

Rhombus::Rhombus(const Rhombus &other)
{
    this->_x1 = other._x1;
    this->_y1 = other._y1;
    this->_x2 = other._x2;
    this->_y2 = other._y2;
    this->_x3 = other._x3;
    this->_y3 = other._y3;
    this->_x4 = other._x4;
    this->_y4 = other._y4;
}
double Rhombus::Area()
{
    double d1 = std::sqrt(std::pow(_x3 - _x1, 2) + std::pow(_y3 - _y1, 2));
    double d2 = std::sqrt(std::pow(_x4 - _x2, 2) + std::pow(_y4 - _y2, 2));
    return (d1 * d2) / 2.0;
}

double Rhombus::Perimeter()
{
    double side = std::sqrt(std::pow(_x2 - _x1, 2) + std::pow(_y2 - _y1, 2));
    return 4 * side;
}

std::string Rhombus::GetCoordinates()
{
    return std::string("Координати точок ромба:\n") +
           "Точка 1: (" + std::to_string(_x1) + ", " + std::to_string(_y1) + ")\n" +
           "Точка 2: (" + std::to_string(_x2) + ", " + std::to_string(_y2) + ")\n" +
           "Точка 3: (" + std::to_string(_x3) + ", " + std::to_string(_y3) + ")\n" +
           "Точка 4: (" + std::to_string(_x4) + ", " + std::to_string(_y4) + ")";
}
void Rhombus::Scale(double factor)
{
    _x1 *= factor;
    _y1 *= factor;
    _x2 *= factor;
    _y2 *= factor;
    _x3 *= factor;
    _y3 *= factor;
    _x4 *= factor;
    _y4 *= factor;
}

Rhombus Rhombus::operator*(double scalar)
{
    return Rhombus(_x1 * scalar, _y1 * scalar, _x2 * scalar, _y2 * scalar, _x3 * scalar, _y3 * scalar, _x4 * scalar, _y4 * scalar);
}

Rhombus Rhombus::operator-(Rhombus other)
{
    return Rhombus(
        _x1 - other._x1, _y1 - other._y1,
        _x2 - other._x2, _y2 - other._y2,
        _x3 - other._x3, _y3 - other._y3,
        _x4 - other._x4, _y4 - other._y4);
}