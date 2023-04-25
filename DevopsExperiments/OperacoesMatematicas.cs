using System;

public class OperacoesMatematicas
{
    private readonly Random random = new Random();

    public int PotenciaAleatoria(int numero)
    {
        int outroNumero = random.Next(10); // Gera um número inteiro aleatório entre 0 e 9 (inclusive)
        int resultado = (int)Math.Pow(numero, outroNumero); // Eleva o número passado como parâmetro à potência do outro número
        return resultado;
    }
}
