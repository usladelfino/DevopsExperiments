using System;
using DevopsExperiments;

/// <summary>
/// Classe responsável por iniciar a aplicação.
/// </summary>
internal class Program
{
        private static void Main()
    {
        OperacoesMatematicas operacoes = new OperacoesMatematicas();

        int numero = 3;
        int resultado = operacoes.PotenciaAleatoria(numero);

        Console.WriteLine($"Resultado: {resultado}");
    }
}
