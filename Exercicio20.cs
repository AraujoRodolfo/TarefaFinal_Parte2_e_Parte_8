using System;
class Program
{
    static void Main(string[] args)
    {
        double r;
        Console.WriteLine("Escreva o valor em R$:");
        r = double.Parse(Console.ReadLine());
        Conver(r);
        Console.ReadKey();
    }
    static void Conver(double n1)
    {
        Console.WriteLine("A conversão ficou {0} Doláres", n1 / 5.24);
        Console.WriteLine("A conversão ficou {0} Euros", n1 / 5.52);
    }
}