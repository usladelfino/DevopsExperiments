using DevopsExperiments.API;
using DevopsExperiments.API.Controllers;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace DevopsExperiments.Tests
{
    /// <summary>
    /// Classe de teste para OperacoesMatematicasController.
    /// </summary>
    public class OperacoesMatematicasTests
    {
        /// <summary>
        /// Testa o método GetPotenciaAleatoria do controlador OperacoesMatematicasController.
        /// </summary>
        [Fact]
        public void TestGetPotenciaAleatoria()
        {
            // Arrange
            var controller = new OperacoesMatematicasController(new OperacoesMatematicas());

            // Act
            var result = controller.Get(2);

            // Assert
            Assert.IsType<OkObjectResult>(result);
        }
    }
}
