using System;

namespace LineApp
{
    class Program
    {
        static void Main()
        {
            Segment segment = new Segment(1, 2, 3, 4);
            Segment segment1 = new Segment(segment);

            Console.WriteLine("Дані відрізка:");
            Console.WriteLine(segment.GetSegmentData());

            double length = segment.GetLength();
            Console.WriteLine($"Довжина відрізка: {length}");

            segment.ReduceLengthBy5();
            double newLength = segment.GetLength();
            if (newLength < 5)
            {
                Console.WriteLine("Довжина відрізка не зменшена.");
            }
            else
            {
                Console.WriteLine("Довжина відрізка зменшена на 5.");
            }
            Console.WriteLine(segment.GetSegmentData());

        }
    }
}