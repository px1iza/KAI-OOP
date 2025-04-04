#include "Line.h"
#include <cmath>

Line::Line(double startX, double startY, double endX, double endY)
    : startX(startX), startY(startY), endX(endX), endY(endY) {}

Line::Line() : startX(0), startY(0), endX(1), endY(1) {}

Line::Line(const Line& other)
    : startX(other.startX), startY(other.startY), endX(other.endX), endY(other.endY) {}

double Line::GetStartX(){ return startX; }
double Line::GetStartY(){ return startY; }
double Line::GetEndX(){ return endX; }
double Line::GetEndY(){ return endY; }

double Line::GetLength(){
    return sqrt(pow(endX - startX, 2) + pow(endY - startY, 2));
}

void Line::SetEndCoordinates(double newEndX, double newEndY) {
    endX = newEndX;
    endY = newEndY;
}