using System;

class P
{
    static void Main()
    {
        //Завд 1
        const double x1 = 12.743;
        const double y1 = 0.654;
        const double z1 = 0.0208;
        
        double n1 = x1 * y1 - 4 * z1;
        double d1 = Math.Log(x1) + 4 * y1 + Math.Sqrt(z1);
        double r1 = n1 / d1;
        Console.WriteLine("завд 1");
        Console.WriteLine(x1);
        Console.WriteLine(y1);
        Console.WriteLine(z1);
        Console.WriteLine(r1);

        //Завд 2
        const double c2 = 4.5;
        const double d2 = 2.21;
        double x2, y2, Z2;
        double x2n = Math.Log(Math.Abs(c2 + d2));
        double x2d = Math.Cos(Math.PI / d2);
        x2 = x2n / x2d + 0.17;
        double y2n_t1 = Math.Sin(3 * Math.Pow(d2, 3) / 2);
        double y2n_t2 = Math.Cos(c2 / 4);
        double y2n = y2n_t1 - y2n_t2;
        double y2d = Math.Log(Math.Abs(d2)) + Math.Log(Math.Sqrt(Math.Pow(c2, 2)));
        y2 = y2n / y2d;
        double Z2t1 = c2 * Math.Exp(-2.5 * x2 + Math.Pow(y2, 2));
        double Z2t2 = Math.Pow(c2 * x2, 1.0 / 3.0);
        Z2 = Z2t1 - Z2t2;
        Console.WriteLine("завд 2");
        Console.WriteLine(c2);
        Console.WriteLine(d2);
        Console.WriteLine(x2);
        Console.WriteLine(y2);
        Console.WriteLine(Z2);
        Console.ReadKey();
    }
}