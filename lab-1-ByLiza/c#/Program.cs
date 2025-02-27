namespace TrapezoidApp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Якщо хочете обчислити площу та периметр, натисніть 1. Якщо ні, натисніть будь-яку іншу клавішу для виходу.");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("Введіть координати трапезоїда (x1, y1, x2, y2, x3, y3, x4, y4):");

                Console.Write("x1 = ");
                double x1 = Convert.ToDouble(Console.ReadLine() ?? "0");
                Console.Write("y1 = ");
                double y1 = Convert.ToDouble(Console.ReadLine() ?? "0");
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


                Trapezoid trapezoid1 = new Trapezoid();
                Trapezoid trapezoid2 = new Trapezoid(1.0, 2.0, 3.0, 4.0, 5.0, 6.0, 7.0, 8.0);
                Trapezoid trapezoid3 = new Trapezoid(trapezoid2);

                Trapezoid trapezoid = new Trapezoid(x1, y1, x2, y2, x3, y3, x4, y4);

                Console.WriteLine($"Введені координати:\n A({x1}, {y1}) \n B({x2}, {y2})\n C({x3}, {y3})\n D({x4}, {y4})");
                double perimeter = trapezoid.GetPerimeter();
                Console.WriteLine($"\nПериметр: {perimeter}");
                double area = trapezoid.GetArea();
                Console.WriteLine($"Площа: {area}");
            }
            else
            {
                Console.WriteLine("Програма завершена.");
            }
        }
    }
}