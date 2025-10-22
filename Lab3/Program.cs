using System;

class P
{
    static void Main()
    {
        //Завдання 1
        
        double x1, y1, z1, r1;
        Console.Write("Введіть X: ");
        x1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введіть Y: ");
        y1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введіть Z: ");
        z1 = Convert.ToDouble(Console.ReadLine());
        double n1 = x1 * z1 + 3 * y1;
        double d1 = (y1 - z1) * Math.Cos(x1);
        r1 = n1 / d1;
        Console.WriteLine($"Результат 1 = {r1}");
         
        //Завдання 2
        
        double a2, b2, avg_ar, avg_sq;
        Console.Write("Введіть число A: ");
        a2 = Convert.ToDouble(Console.ReadLine());    
        Console.Write("Введіть число B: ");
        b2 = Convert.ToDouble(Console.ReadLine());
        avg_ar = (a2 + b2) / 2;
        avg_sq = Math.Sqrt((Math.Pow(a2, 2) + Math.Pow(b2, 2)) / 2);
        Console.WriteLine($"Сер. арифметичне = {avg_ar}");
        Console.WriteLine($"Сер. квадратичне = {avg_sq}");

        //Завлання 3
        double price, amount, dohid;
        Console.Write("Введіть середню ціну: ");
        price = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введіть кількість продукції: ");
        amount = Convert.ToDouble(Console.ReadLine());
        dohid = price * amount;        
        Console.WriteLine($"Сума доходу = {dohid}");
        Console.ReadKey();
    }
}