#ifndef LINE_H
#define LINE_H

class Line {
private:
    double startX, startY, endX, endY;

public:
    Line(double startX, double startY, double endX, double endY);
    Line();
    Line(const Line& other);
    double GetStartX();
    double GetStartY();
    double GetEndX();
    double GetEndY();
    double GetLength();
    void SetEndCoordinates(double newEndX, double newEndY);
};
#endif 