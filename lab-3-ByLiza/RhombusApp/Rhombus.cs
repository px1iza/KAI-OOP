namespace RhombusApp
{
    public class Rhombus
    {
        private double _x1, _y1, _x2, _y2, _x3, _y3, _x4, _y4;
        public double X1 { get => _x1; }
        public double Y1 { get => _y1; }
        public double X2 { get => _x2; }
        public double Y2 { get => _y2; }
        public double X3 { get => _x3; }
        public double Y3 { get => _y3; }
        public double X4 { get => _x4; }
        public double Y4 { get => _y4; }
        public Rhombus()
        {
            _x1 = _y1 = _x2 = _y2 = _x3 = _y3 = _x4 = _y4 = 0;
        }

        public Rhombus(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            _x1 = x1; _y1 = y1;
            _x2 = x2; _y2 = y2;
            _x3 = x3; _y3 = y3;
            _x4 = x4; _y4 = y4;
        }

        public Rhombus(Rhombus other)
        {
            _x1 = other._x1;
            _y1 = other._y1;
            _x2 = other._x2;
            _y2 = other._y2;
            _x3 = other._x3;
            _y3 = other._y3;
            _x4 = other._x4;
            _y4 = other._y4;
        }

        public double Area()
        {
            double d1 = Math.Sqrt(Math.Pow(_x3 - _x1, 2) + Math.Pow(_y3 - _y1, 2));
            double d2 = Math.Sqrt(Math.Pow(_x4 - _x2, 2) + Math.Pow(_y4 - _y2, 2));
            return (d1 * d2) / 2.0;
        }

        public double Perimeter()
        {
            double side = Math.Sqrt(Math.Pow(_x2 - _x1, 2) + Math.Pow(_y2 - _y1, 2));
            return 4 * side;
        }

        public string GetCoordinates()
        {
            return $"Координати точок ромба:\n" +
                   $"Точка 1: ({_x1}, {_y1})\n" +
                   $"Точка 2: ({_x2}, {_y2})\n" +
                   $"Точка 3: ({_x3}, {_y3})\n" +
                   $"Точка 4: ({_x4}, {_y4})";
        }
        public void Scale(double factor = 1.5)
        {
            _x1 *= factor; _y1 *= factor;
            _x2 *= factor; _y2 *= factor;
            _x3 *= factor; _y3 *= factor;
            _x4 *= factor; _y4 *= factor;
        }

        public static Rhombus operator *(Rhombus rhombus, double scalar)
        {
            return new Rhombus(
                rhombus._x1 * scalar, rhombus._y1 * scalar,
                rhombus._x2 * scalar, rhombus._y2 * scalar,
                rhombus._x3 * scalar, rhombus._y3 * scalar,
                rhombus._x4 * scalar, rhombus._y4 * scalar
            );
        }
        public static Rhombus operator -(Rhombus rhombus1, Rhombus rhombus2)
        {
            return new Rhombus(
                rhombus1._x1 - rhombus2._x1, rhombus1._y1 - rhombus2._y1,
                rhombus1._x2 - rhombus2._x2, rhombus1._y2 - rhombus2._y2,
                rhombus1._x3 - rhombus2._x3, rhombus1._y3 - rhombus2._y3,
                rhombus1._x4 - rhombus2._x4, rhombus1._y4 - rhombus2._y4
            );
        }
    }
}
