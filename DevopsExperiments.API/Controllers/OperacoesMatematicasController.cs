// <copyright file="OperacoesMatematicasController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace DevopsExperiments.API.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;

    /// <summary>
    /// Controlador responsável por gerenciar as operações matemáticas disponíveis.
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class OperacoesMatematicasController : ControllerBase
    {
        private readonly OperacoesMatematicas operacoes;

        /// <summary>
        /// Cria uma nova instância de OperacoesMatematicasController.
        /// </summary>
        /// <param name="operacoes">As operações matemáticas a serem executadas.</param>
        public OperacoesMatematicasController(OperacoesMatematicas operacoes)
        {
            this.operacoes = operacoes;
        }

        /// <summary>
        /// Obtém o resultado da operação de potência aleatória e do fatorial do número especificado.
        /// </summary>
        /// <param name="numero">O número cujo fatorial e potência aleatória serão calculados.</param>
        /// <returns>Um objeto contendo o resultado da operação de potência aleatória e do fatorial.</returns>
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