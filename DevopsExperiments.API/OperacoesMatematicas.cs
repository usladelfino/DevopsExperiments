// <copyright file="OperacoesMatematicas.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace DevopsExperiments.API
{
    /// <summary>
    /// Classe que cont�m m�todos para realizar opera��es matem�ticas.
    /// </summary>
    public class OperacoesMatematicas
    {
        /// <summary>
        /// Gera um n�mero aleat�rio entre 1 e 10, e eleva o n�mero passado como argumento a essa pot�ncia.
        /// </summary>
        /// <param name="numero">O n�mero que ser� elevado a uma pot�ncia aleat�ria entre 1 e 10.</param>
        /// <returns>O resultado da eleva��o de n�mero a uma pot�ncia aleat�ria entre 1 e 10.</returns>
        public int PotenciaAleatoria(int numero)
        {
            Random rand = new ();
            int potencia = rand.Next(1, 11);
            return (int)Math.Pow(numero, potencia);
        }
    }
}