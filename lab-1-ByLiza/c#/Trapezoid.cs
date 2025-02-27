namespace TrapezoidApp
{
    public class Trapezoid
    {
        private double _x1, _y1;
        private double _x2, _y2;
        private double _x3, _y3;
        private double _x4, _y4;

        public double X1 { get; private set; }
        public double Y1 { get; private set; }
        public double X2 { get; private set; }
        public double Y2 { get; private set; }
        public double X3 { get; private set; }
        public double Y3 { get; private set; }
        public double X4 { get; private set; }
        public double Y4 { get; private set; }

        public Trapezoid()
        {
            _x1 = _y1 = _x2 = _y2 = _x3 = _y3 = _x4 = _y4 = 0.0;
        }

        public Trapezoid(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            _x1 = x1;
            _y1 = y1;
            _x2 = x2;
            _y2 = y2;
            _x3 = x3;
            _y3 = y3;
            _x4 = x4;
            _y4 = y4;
        }
        public Trapezoid(Trapezoid other)
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
        ~Trapezoid()
        {
            Console.WriteLine("Об'єкт Trapezoid знищено.");
        }

        public double GetPerimeter()
        {
            double sideA = Math.Sqrt((_x2 - _x1) * (_x2 - _x1) + (_y2 - _y1) * (_y2 - _y1));
            double sideB = Math.Sqrt((_x4 - _x3) * (_x4 - _x3) + (_y4 - _y3) * (_y4 - _y3));
            double sideC = Math.Sqrt((_x3 - _x2) * (_x3 - _x2) + (_y3 - _y2) * (_y3 - _y2));
            double sideD = Math.Sqrt((_x4 - _x1) * (_x4 - _x1) + (_y4 - _y1) * (_y4 - _y1));

            return sideA + sideB + sideC + sideD;
        }

        public double GetArea()
        {
            double baseA = Math.Sqrt((_x2 - _x1) * (_x2 - _x1) + (_y2 - _y1) * (_y2 - _y1));
            double baseB = Math.Sqrt((_x4 - _x3) * (_x4 - _x3) + (_y4 - _y3) * (_y4 - _y3));
            double height = Math.Abs(_y3 - _y1);
            return (baseA + baseB) * height / 2.0;
        }
    }
}