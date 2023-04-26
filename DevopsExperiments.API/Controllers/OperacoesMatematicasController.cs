// <copyright file="OperacoesMatematicasController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace DevopsExperiments.API.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;

    /// <summary>
    /// Controlador respons�vel por gerenciar as opera��es matem�ticas dispon�veis.
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class OperacoesMatematicasController : ControllerBase
    {
        private readonly OperacoesMatematicas operacoes;

        /// <summary>
        /// Cria uma nova inst�ncia de OperacoesMatematicasController.
        /// </summary>
        /// <param name="operacoes">As opera��es matem�ticas a serem executadas.</param>
        public OperacoesMatematicasController(OperacoesMatematicas operacoes)
        {
            this.operacoes = operacoes;
        }

        /// <summary>
        /// Obt�m o resultado da opera��o de pot�ncia aleat�ria e do fatorial do n�mero especificado.
        /// </summary>
        /// <param name="numero">O n�mero cujo fatorial e pot�ncia aleat�ria ser�o calculados.</param>
        /// <returns>Um objeto contendo o resultado da opera��o de pot�ncia aleat�ria e do fatorial.</returns>
        [HttpGet("{numero}")]
        public IActionResult Get(int numero)
        {
            int resultadoPotencia = this.operacoes.PotenciaAleatoria(numero);

            return this.Ok(new
            {
                PotenciaAleatoria = resultadoPotencia,
            });
        }
    }
}