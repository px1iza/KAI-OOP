namespace RhombusApp
{
    class Program
    {
        static void Main()
        {
            Rhombus P1 = new Rhombus();
            Rhombus P2 = new Rhombus(x1: 56, y4: 78, y3: 89, y2: 45, y1: 47, x2: 53, x3: 64, x4: 76);
            Rhombus P3 = new Rhombus(P2);

            Rhombus P4 = P3 * 3;
            Console.WriteLine(P4.GetCoordinates());
            P1 = P3 - P2;
            Console.WriteLine(P1.GetCoordinates());
        }

    }
}