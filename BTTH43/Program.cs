using System;

class Program
{
    int a = 5, b = 7;
    double c = 3.4, d = 2.5;

    public static void Main()
    {
        Program program = new Program();

        Console.WriteLine($"Before swapping: a = {program.a}, b = {program.b}");
        Swap<int>(ref program.a, ref program.b);
        Console.WriteLine($"After swapping: a = {program.a}, b = {program.b}");

        Console.WriteLine($"Before swapping: c = {program.c}, d = {program.d}");
        Swap<double>(ref program.c, ref program.d);
        Console.WriteLine($"After swapping: c = {program.c}, d = {program.d}");
    }

    public static void Swap<T>(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }
}
