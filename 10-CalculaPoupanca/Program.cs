using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando 10 - Calcula poupança: ");

        double investimento;
        int meses;

        Console.WriteLine("Digite o quanto quer investir na poupança: ");
        investimento = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite a quantidade de meses que o dinheiro ficará investido:");
        meses = Convert.ToInt32(Console.ReadLine());

        Program renda = new Program();

        Rende(investimento, meses);

        Console.WriteLine("Tecle enter para finalizar o aplicativo.");
        Console.ReadLine();
    }

    static void Rende(double investimento, int meses)
    {
        for (int i = 0; i < meses; i++)
        {
            investimento = investimento + (investimento * 0.005);
        }
        double montante = investimento;
        Console.WriteLine("{0:F2}", montante);
    }
}