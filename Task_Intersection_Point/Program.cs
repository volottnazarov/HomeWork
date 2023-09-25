// Напишите программу, которая найдёт точку пересечения двух прямых
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем

internal class Program
{
    private static void Main(string[] args)
    {
        double pointX;
        double pointY;

        Console.Write("Введите b1, k1, b2 и k2 c пробелом: ");
        int[] arr = Console.ReadLine()!
            .Split(' ')
            .Select(int.Parse)
            .ToArray();
        int a = arr[1];
        int b = arr[3];
        int c = arr[0];
        int d = arr[2];

        if (a == b)
        {
            Console.WriteLine("Прямые паралельны");
        }
        //if (c == d)
        //{
        //  Console.WriteLine("Прямые совпадают");
        //}
        else
        {
            pointX = (double)(d - c) / (a - b);
            pointY = (double)a * (d - c) / (a - b) + c;
            Console.WriteLine("Координаты точки пересечения двух прямых:");
            Console.WriteLine($"Х: {pointX:0.00}");
            Console.WriteLine($"Y: {pointY:0.00}");
        }
    }
}