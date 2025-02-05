
namespace TrapezoidApp
{
    public class Trapezoid
    {
        public double x1, y1;
        public double x2, y2;
        public double x3, y3;
        public double x4, y4;

        public Trapezoid()
        {
            x1 = y1 = x2 = y2 = x3 = y3 = x4 = y4 = 0.0;
        }

        public Trapezoid(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            this.x3 = x3;
            this.y3 = y3;
            this.x4 = x4;
            this.y4 = y4;
        }
        public Trapezoid(double x1, double y1)
        {
            this.x1 = x1;
            this.y1 = y1;
            x2 = y2 = x3 = y3 = x4 = y4 = 0.0;
        }

        public Trapezoid(double x1, double y1, double x2, double y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            x3 = y3 = x4 = y4 = 0.0;
        }

        public double GetPerimeter()
        {
            double sideA = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            double sideB = Math.Sqrt((x4 - x3) * (x4 - x3) + (y4 - y3) * (y4 - y3));
            double sideC = Math.Sqrt((x3 - x2) * (x3 - x2) + (y3 - y2) * (y3 - y2));
            double sideD = Math.Sqrt((x4 - x1) * (x4 - x1) + (y4 - y1) * (y4 - y1));

            return sideA + sideB + sideC + sideD;
        }

        public double GetArea()
        {
            double baseA = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            double baseB = Math.Sqrt((x4 - x3) * (x4 - x3) + (y4 - y3) * (y4 - y3));
            double height = Math.Abs(y3 - y1);
            return (baseA + baseB) * height / 2.0;
        }
    }
}

