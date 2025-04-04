#include "Segment.h"
#include <iostream>
#include <cmath>
#include <string>

Segment::Segment() : Line() {}

Segment::Segment(double startX, double startY, double endX, double endY)
    : Line(startX, startY, endX, endY) {}

Segment::Segment(const Segment& other) : Line(other) {}

std::string Segment::GetSegmentData() {
    return "Start Point: (" + std::to_string(GetStartX()) + ", " + std::to_string(GetStartY()) +
           "), End Point: (" + std::to_string(GetEndX()) + ", " + std::to_string(GetEndY()) + ")";
}

void Segment::ReduceLengthBy5() {
    double length = GetLength();

    if (length <= 5) {
        std::cout << "Довжина відрізка занадто мала, щоб зменшити її на 5." << std::endl;
        return; 
    } else {
        double scale = (length - 5) / length;

        double newEndX = GetStartX() + (GetEndX() - GetStartX()) * scale;
        double newEndY = GetStartY() + (GetEndY() - GetStartY()) * scale;

        SetEndCoordinates(newEndX, newEndY);
        std::cout << "Довжина відрізка зменшена на 5." << std::endl;
    }
}