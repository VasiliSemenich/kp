public class GigaChat
{
    public static void Swap(ref double X, ref double Y)
    {
        double temp = X;
        X = Y;
        Y = temp;
    }
    public static void Main(string[] args)
    {
        double A = 1.0, B = 2.0, C = 3.0, D = 4.0;

        Console.WriteLine($"Исходные значения: A = {A}, B = {B}, C = {C}, D = {D}");

        Swap(ref A, ref B); // Меняем A и B
        Console.WriteLine($"После смены A и B: A = {A}, B = {B}, C = {C}, D = {D}");

        Swap(ref C, ref D); // Меняем C и D
        Console.WriteLine($"После смены C и D: A = {A}, B = {B}, C = {C}, D = {D}");

        Swap(ref B, ref C); // Меняем B и C
        Console.WriteLine($"После смены B и C: A = {A}, B = {B}, C = {C}, D = {D}");
    }
}