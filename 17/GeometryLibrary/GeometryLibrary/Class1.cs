namespace GeometryLibrary
{
    public class Triangle
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public Triangle(double a, double b, double c)
        {
            SideA = a;
            SideB = b;
            SideC = c;
        }

        public bool IsValid()
        {
            return SideA + SideB > SideC &&
                   SideA + SideC > SideB &&
                   SideB + SideC > SideA;
        }

        public double GetPerimeter()
        {
            return SideA + SideB + SideC;
        }

        public double GetArea()
        {
            double s = GetPerimeter() / 2;
            return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
        }

        public string GetTriangleType()
        {
            if (SideA == SideB && SideB == SideC)
                return "Равносторонний";
            if (SideA == SideB || SideA == SideC || SideB == SideC)
                return "Равнобедренный";
            return "Разносторонний";
        }
    }
    public class Rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double GetPerimeter()
        {
            return 2 * (Width + Height);
        }

        public double GetArea()
        {
            return Width * Height;
        }
    }
}
 