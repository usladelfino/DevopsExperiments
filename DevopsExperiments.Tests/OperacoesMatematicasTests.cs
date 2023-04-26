// <copyright file="OperacoesMatematicasTests.cs" company="Delfino Devops">
// Copyright (c) Delfino Devops. All rights reserved.
// </copyright>

using System;
using DevopsExperiments;
using Xunit;

/// <summary>
/// Classe de testes para a classe OperacoesMatematicas.
/// </summary>
public class OperacoesMatematicasTests
{
    /// <summary>
    /// Testa o m�todo PotenciaAleatoria da classe OperacoesMatematicas.
    /// </summary>
    [Fact]
    public void TestePotenciaAleatoria()
    {
        OperacoesMatematicas operacoes = new OperacoesMatematicas();

        // Teste para pot�ncia 0
        int resultado1 = operacoes.PotenciaAleatoria(0);
        Assert.Equal(0, resultado1);

        // Teste para pot�ncia 1
        int resultado2 = operacoes.PotenciaAleatoria(1);
        Assert.Equal(1, resultado2);

        // Teste para pot�ncia aleat�ria entre 1 e 9 (inclusive)
        int resultado3 = operacoes.PotenciaAleatoria(5);
        Assert.InRange(resultado3, 5, 1953125); // 5^2 = 25 e 5^9 = 1953125
    }
}
