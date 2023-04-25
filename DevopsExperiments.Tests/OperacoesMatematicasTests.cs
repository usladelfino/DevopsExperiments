using System;
using Xunit;

public class OperacoesMatematicasTests
{
    [Fact]
    public void TestePotenciaAleatoria()
    {
        OperacoesMatematicas operacoes = new OperacoesMatematicas();

        // Teste para pot�ncia 0
        int resultado1 = operacoes.PotenciaAleatoria(5);
        Assert.Equal(1, resultado1);

        // Teste para pot�ncia 1
        int resultado2 = operacoes.PotenciaAleatoria(5);
        Assert.Equal(5, resultado2);

        // Teste para pot�ncia aleat�ria entre 2 e 9 (inclusive)
        int resultado3 = operacoes.PotenciaAleatoria(5);
        Assert.InRange(resultado3, 32, 1953125); // 5^2 = 25 e 5^9 = 1953125
    }
}