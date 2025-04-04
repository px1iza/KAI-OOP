using System;

namespace LineApp
{
    public class Segment : Line
    {
        public Segment() : base()
        {
        }

        public Segment(double startX, double startY, double endX, double endY)
            : base(startX, startY, endX, endY)
        {
        }

        public Segment(Segment other)
            : base(other)
        {
        }
        public string GetSegmentData()
        {
            return $"Початкова точка: ({StartX}, {StartY}), Кінцева точка: ({EndX}, {EndY})";
        }

        public void ReduceLengthBy5()
        {
            double length = GetLength();

            if (length == 5)
            {
                Console.WriteLine("Помилка: довжина відрізка дорівнює 5, тому зменшити на 5 неможливо.");
                return; 
            }

            if (length <= 5)
            {
                Console.WriteLine("Довжина відрізка занадто мала, щоб зменшити її на 5.");
                return;
            }
            else
            {
                double scale = (length - 5) / length;

                double newEndX = StartX + (EndX - StartX) * scale;
                double newEndY = StartY + (EndY - StartY) * scale;

                SetEndCoordinates(newEndX, newEndY);
                Console.WriteLine("Довжина відрізка зменшена на 5.");
            }

            
        }
    }
}