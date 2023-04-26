// <copyright file="OperacoesMatematicas.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace DevopsExperiments.API
{
    /// <summary>
    /// Classe que contém métodos para realizar operações matemáticas.
    /// </summary>
    public class OperacoesMatematicas
    {
        /// <summary>
        /// Gera um número aleatório entre 1 e 10, e eleva o número passado como argumento a essa potência.
        /// </summary>
        /// <param name="numero">O número que será elevado a uma potência aleatória entre 1 e 10.</param>
        /// <returns>O resultado da elevação de número a uma potência aleatória entre 1 e 10.</returns>
        public int PotenciaAleatoria(int numero)
        {
            Random rand = new ();
            int potencia = rand.Next(1, 11);
            return (int)Math.Pow(numero, potencia);
        }
    }
}