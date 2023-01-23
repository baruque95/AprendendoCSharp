using System;
class Programa
{
    static void Main(string[] args)
    {
        double salario;
        bool foiPromovido = true;
        if (foiPromovido)
        {
            // Caso salario seja declarado dentro do if, o que não foi o caso, ele se torna uma variável temporária.
            // Isso faria com que ao fim do programa, ao se pedir que imprima o salario, cause erro pois a variável já não existe mais.
            salario = 4200.0;
        }
        else
        {
            salario = 3800.0;
        }
        Console.WriteLine(salario);
    }
}
