using System;

class Program
{
    static void Main(string[] args)
    {
        char caractere = 'a';
        // PERCEBA QUE ATRIBUIÇÃO DE CHAR DEVE SER FEITA COM ASPAS SIMPLES ''
        Console.WriteLine(caractere);

        char asciiNumerico = (char)70;
        // NESTE CASO, A ATRIBUIÇÃO É DE UM CARACTERE PELA TABELA ASCII. O OUTPUT É A LETRA 'F'
        Console.WriteLine(asciiNumerico);
    }
}