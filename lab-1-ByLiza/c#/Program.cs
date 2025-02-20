namespace TrapezoidApp
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Введіть координати трапезоїда (x1, y1, x2, y2, x3, y3, x4, y4):");

            Console.Write("x1 = ");
            double x1 = Convert.ToDouble(Console.ReadLine() ?? "0");
            Console.Write("y1 = ");
            int y1 = TryParseToInt(Console.ReadLine() ?? "0");
            Console.Write("x2 = ");
            double x2 = Convert.ToDouble(Console.ReadLine() ?? "0");
            Console.Write("y2 = ");
            double y2 = Convert.ToDouble(Console.ReadLine() ?? "0");
            Console.Write("x3 = ");
            double x3 = Convert.ToDouble(Console.ReadLine() ?? "0");
            Console.Write("y3 = ");
            double y3 = Convert.ToDouble(Console.ReadLine() ?? "0");
            Console.Write("x4 = ");
            double x4 = Convert.ToDouble(Console.ReadLine() ?? "0");
            Console.Write("y4 = ");
            double y4 = Convert.ToDouble(Console.ReadLine() ?? "0");

            Trapezoid trapezoid = new Trapezoid(x1, y1, x2, y2, x3, y3, x4, y4);

            Console.WriteLine($"Введені координати:\n A({x1}, {y1}) \n B({x2}, {y2})\n C({x3}, {y3})\n D({x4}, {y4})");

            double perimeter = trapezoid.GetPerimeter();
            Console.WriteLine($"\nПериметр: {perimeter}");

            double area = trapezoid.GetArea();
            Console.WriteLine($"Площа: {area}");

        }
    }
}