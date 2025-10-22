using System;
class Program
{
    static void Main()
    {
        const double x = 0.0399;
        const double y = 4.83;
        const double z = 0.072;
        double r = x * (y + z) / (y - y * z);
        Console.WriteLine(r);
        Console.ReadKey();
    }
}