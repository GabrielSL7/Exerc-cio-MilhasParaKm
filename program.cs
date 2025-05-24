using System;

class Program
{
    static void Main()
    {
        Console.Write("Entre com a medida (em milhas): ");
        double milhas = double.Parse(Console.ReadLine()!);

        double km = milhas * 1.609;

        Console.WriteLine($"{km:F3} Km");
    }
}
