using System;

class Program
{
    static void Main(string[] args)
    {
        int idade = 27;
        int idadeGabriel = idade;

        Console.WriteLine(idadeGabriel);

        idade = 30;
        Console.WriteLine(idade);
        Console.WriteLine(idadeGabriel);

    }
}