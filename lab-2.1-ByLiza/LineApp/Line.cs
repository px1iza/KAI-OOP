using System;

namespace LineApp
{
    public class Line
    {
        private double _startX, _startY, _endX, _endY;

        public Line(double startX, double startY, double endX, double endY)
        {
            _startX = startX;
            _startY = startY;
            _endX = endX;
            _endY = endY;
        }
        public Line()
        {
            _startX = _startY = 0;
            _endX = _endY = 1;
        }
        public Line(Line other)
        {
            _startX = other._startX;
            _startY = other._startY;
            _endX = other._endX;
            _endY = other._endY;
        }

        public double StartX { get => _startX; }
        public double StartY { get => _startY; }
        public double EndX { get => _endX; }
        public double EndY { get => _endY; }

        public double GetLength()
        {
            return Math.Sqrt(Math.Pow(_endX - _startX, 2) + Math.Pow(_endY - _startY, 2));
        }
        public void SetEndCoordinates(double newEndX, double newEndY)
        {
            _endX = newEndX;
            _endY = newEndY;
        }
    }
}