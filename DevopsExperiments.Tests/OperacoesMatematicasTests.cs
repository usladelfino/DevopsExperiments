using System;
using Xunit;

public class OperacoesMatematicasTests
{
    [Fact]
    public void TestePotenciaAleatoria()
    {
        OperacoesMatematicas operacoes = new OperacoesMatematicas();

        // Teste para potência 0
        int resultado1 = operacoes.PotenciaAleatoria(0);
        Assert.Equal(0, resultado1);

        // Teste para potência 1
        int resultado2 = operacoes.PotenciaAleatoria(1);
        Assert.Equal(1, resultado2);

        // Teste para potência aleatória entre 1 e 9 (inclusive)
        int resultado3 = operacoes.PotenciaAleatoria(5);
        Assert.InRange(resultado3, 5, 1953125); // 5^2 = 25 e 5^9 = 1953125
    }
}
