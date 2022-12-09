using System;
class Program
{
    static void Main(string[] args)
    {
        string[] n1 = new string[5];
        int i;
        for (i = 0; i <= 4; i++)
        {
            Console.WriteLine("Escreva o {0}° nome", i + 1);
            n1[i] = Console.ReadLine();
        }
        for (i = 0; i <= 4; i++)
        {
            Console.WriteLine("Nome da {0}° pessoa: {1}", i + 1, n1[i]);
        }
        Array.Reverse(n1);
        Inversa(n1);
    }
    static void Inversa(string[] nome1)
    {
        int x;
        Console.WriteLine("\n Ordem inversa dos Nomes \n");
        for (x = 0; x <= 4; x++)
        {
            Console.WriteLine("Nome da {0}° pessoa: {1}", x + 1, nome1[x]);
        }
    }
}