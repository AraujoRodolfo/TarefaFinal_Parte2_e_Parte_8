using System;
class Program
{
    static void Main(string[] args)
    {
        const int N_lin = 10, N_col = 3;
        double[,] notas = new double[N_lin, N_col];
        string[] nome = new string[10];
        double[] media = new double[10];
        nome = CadastrarNomes(N_lin, N_col);
        notas = CadastrarNotas(N_lin, N_col, nome);
        media = CalcularMedias(N_lin, N_col, notas);
        Console.WriteLine("\n *** Notas Cadastradas na Matriz *** \n");
        ExibirDados(notas, nome, media);
        Console.ReadKey();
    }
    static string[] CadastrarNomes(int nlin, int ncol)
    {
        string[] nm = new string[10];

        for (int l = 0; l < nlin; l++)
        {
            Console.Write("Digite o nome do {0}º aluno: ", l + 1);
            nm[l] = Console.ReadLine();
        }
        Console.Clear();
        return nm;
    }
    static double[,] CadastrarNotas(int nlin, int ncol, string[] nome)
    {
        double[,] n = new double[nlin, ncol];
        for (int l = 0; l < nlin; l++)
        {
            Console.WriteLine("\nNotas do {0}º aluno ({1})", l + 1, nome[l]);
            for (int c = 0; c < ncol; c++)
            {
                Console.Write(" {0}º nota: ", c + 1);
                n[l, c] = double.Parse(Console.ReadLine());
            }
            Console.Clear();
        }
        return n;
    }
    static double[] CalcularMedias(int nlin, int ncol, double[,] notas)
    {
        double[] md = new double[10];
        for (int x = 0; x < 10; x++)
        {
            md[x] = (notas[x, 0] + notas[x, 1] + notas[x, 2]) / ncol;
        }
        return md;
    }
    static void ExibirDados(double[,] nt, string[] nome, double[] media)
    {
        Console.WriteLine("\nAluno \tNota 1 \t\tNota 2 \t\tNota 3 \t\tMédia \t\tAprovação \n");
        for (int i = 0; i < nt.GetLength(0); i++)
        {
            if (media[i] >= 7)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            Console.Write("{0}: ", nome[i]);
            for (int j = 0; j < nt.GetLength(1); j++)
            {
                Console.Write("\t{0:N1}\t", nt[i, j]);
            }
            Console.Write("\t{0:N1}\t", media[i]);
            if (media[i] >= 7)
            {
                Console.Write("\tAprovado");
            }
            else
            {
                Console.Write("\tReprovado");
            }
            Console.WriteLine();
        }
    }
}