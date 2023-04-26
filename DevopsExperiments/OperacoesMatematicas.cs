// <copyright file="OperacoesMatematicas.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace DevopsExperiments
{
    using System;

    /// <summary>
    /// Classe que contém operações matemáticas.
    /// </summary>
    public class OperacoesMatematicas
    {
        private readonly Random random = new ();

        /// <summary>
        /// Calcula a potência de um número elevado a um número aleatório entre 0 e 9.
        /// </summary>
        /// <param name="numero">O número que será elevado à potência.</param>
        /// <returns>O resultado da potência.</returns>
        public int PotenciaAleatoria(int numero)
        {
            int outroNumero = this.random.Next(10); // Gera um número inteiro aleatório entre 0 e 9 (inclusive)
            int resultado = (int)Math.Pow(numero, outroNumero); // Eleva o número passado como parâmetro à potência do outro número
            return resultado;
        }
    }
}
