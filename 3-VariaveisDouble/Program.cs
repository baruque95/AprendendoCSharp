class Program
{
    static void Main(string[] args)
    {
        double salario;

        /*
        Valores usados em operações matemáticas, caso deva-se considerar os decimais,  devem ser expressados com ponto decimal.
        Por exemplo, ao dividir 7 por 5 temos um resultado não-inteiro. Porém, se atribuirmos a operação 7/5, mesmo em uma variável double,
        o resultado dará 1, parte inteira da divisão. Por isso, deve-se atribuir a operação 7.0/5 ou 7/5.0 ou até 7.0/5.0, fazendo com que 
        o resultado apareça mostrando a casa decimal.
        */

        salario = 7000/5.1;
        Console.WriteLine("Salário é de " + salario);
        Console.WriteLine("Digite qualquer tecla para finalizar: ");
        Console.ReadLine();
    }
}