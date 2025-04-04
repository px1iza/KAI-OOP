#pragma once
#include "Line.h" 
#include <string>

class Segment : public Line {
public:
    Segment();
    Segment(double startX, double startY, double endX, double endY);
    Segment(const Segment& other);
    std::string GetSegmentData();
    void ReduceLengthBy5();
};