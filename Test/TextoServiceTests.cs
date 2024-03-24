using DesafioTeiaBackEnd.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesafioTeiaBackEnd.Tests
{
    [TestClass]
    public class TextoServiceTests
    {
        [TestMethod]
        public void EhPalindromo_DeveRetornarTrue_ParaPalindromo()
        {
            // Arrange
            var service = new ManipulacaoTexoService(); // Assumindo que TextoService implementa ITextoService

            // Act
            bool resultado = service.EhPalindromo("ana");

            // Assert
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void EhPalindromo_DeveRetornarFalse_ParaNaoPalindromo()
        {
            // Arrange
            var service = new ManipulacaoTexoService(); // Substitua pela implementação real

            // Act
            bool resultado = service.EhPalindromo("banana");

            // Assert
            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void EhPalindromo_DeveRetornarTrue_ParaStringVazia()
        {
            // Arrange
            var service = new ManipulacaoTexoService(); // Substitua pela implementação real

            // Act
            bool resultado = service.EhPalindromo("");

            // Assert
            Assert.IsTrue(resultado);
        }
    }
}
