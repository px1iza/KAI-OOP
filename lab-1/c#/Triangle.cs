using System;

namespace TriangleApp
{
    public class Triangle
    {
        // Властивості для координат вершин
        public double x1, y1;
        private double x2, y2;
        private double x3, y3;

        private double X1 { get; }
        private double Y1 { get; }
        private double X2 { get; }
        private double Y2 { get; }
        private double X3 { get; }
        private double Y3 { get; }

        // Конструктор за замовчуванням
        public Triangle()
        {
            x1 = y1 = x2 = y2 = x3 = y3 = 0.0;
        }

        // Конструктор з параметрами
        public Triangle(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            this.x3 = x3;
            this.y3 = y3;
        }

        // Конструктор копії
        public Triangle(Triangle other)
        {
            this.x1 = other.x1;
            this.y1 = other.y1;
            this.x2 = other.x2;
            this.y2 = other.y2;
            this.x3 = other.x3;
            this.y3 = other.y3;
        }

        // Делегування конструктора
        public Triangle(double x1, double y1) : this(x1, y1, 0, 0, 0, 0)
        {
        }

        // Деструктор
        ~Triangle()
        {
        }

        // Метод для встановлення координат
        public void SetCoordinates(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            this.x3 = x3;
            this.y3 = y3;
        }

        // Гетери (властивості) для читання координат
        // public double X1 => x1;
        // public double Y1 => y1;
        // public double X2 => x2;
        // public double Y2 => y2;
        // public double X3 => x3;
        // public double Y3 => y3;

        // Метод обчислення периметра
        public double GetPerimeter()
        {
            double sideA = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            double sideB = Math.Sqrt((x3 - x2) * (x3 - x2) + (y3 - y2) * (y3 - y2));
            double sideC = Math.Sqrt((x1 - x3) * (x1 - x3) + (y1 - y3) * (y1 - y3));

            return sideA + sideB + sideC;
        }

        // Метод обчислення площі (за формулою Герона)
        public double GetArea()
        {
            double sideA = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            double sideB = Math.Sqrt((x3 - x2) * (x3 - x2) + (y3 - y2) * (y3 - y2));
            double sideC = Math.Sqrt((x1 - x3) * (x1 - x3) + (y1 - y3) * (y1 - y3));

            double p = (sideA + sideB + sideC) / 2.0; // півпериметр
            return Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
        }
    }
}
