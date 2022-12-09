using System;
class Program
{
    static void Main(string[] args)
    {
        int[] n1 = new int[10];
        int i;
        for (i = 0; i <= 9; i++)
        {
            Console.WriteLine("Escreva o {0}° número", i + 1);
            n1[i] = int.Parse(Console.ReadLine());
            Console.Clear();
        }
        for (i = 0; i <= 9; i++)
        {
            Console.WriteLine("{0}° número : {1}  x5: {2}", i + 1, n1[i], n1[i] * 5);
        }
    }
}