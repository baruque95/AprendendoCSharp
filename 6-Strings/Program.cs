using System;
class Program
{
    static void Main(string[] args)
    {
        string primeiraFrase = "Aprendendo C# novamente. Mais uma vez. De novo.";

        Console.WriteLine(primeiraFrase);

        string carros = @"Marcas de carro: 
        - VolksWagen
        - Ford
        - Chevrolet
        - Brasília";
        Console.WriteLine(carros);
        /*
        Observe que ao utilizar o @, pode-se fazer uma string de múltiplas linhas.
        Os espaços dados à esquerda das linhas abaixo da @ vão mudar o alinhamento
        das linhas da string, por isso fica esquisito em código. No caso da string
        carros, cada linha está afastada da margem esquerda do console.
        */
    }
}