using System;

class Program
{
    static void Main()
    {
        OperacoesMatematicas operacoes = new OperacoesMatematicas();

        int numero = 3;
        int resultado = operacoes.PotenciaAleatoria(numero);

        Console.WriteLine($"Resultado: {resultado}");
    }
}
