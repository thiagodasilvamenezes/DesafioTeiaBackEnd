using Moq;
using Xunit;
using Microsoft.AspNetCore.Mvc;
using DesafioTeiaBackEnd.Service; // Use o namespace correto
using DesafioTeiaBackEnd.Controllers;
using DesafioTeiaBackEnd.Model;

namespace DesafioTeiaBackEnd.Tests
{
    public class ManipulacaoStringControllerTests
    {
        private readonly Mock<IManipulacaoTexoService> _mockService;
        private readonly ManipulacaoStringController _controller;

        public ManipulacaoStringControllerTests()
        {
            _mockService = new Mock<IManipulacaoTexoService>();
            _controller = new ManipulacaoStringController(_mockService.Object);
        }

        [Theory]
        [InlineData("banana", false, new char[] { 'b', 'a', 'n' }, new int[] { 1, 3, 2 })]
        [InlineData("ana", true, new char[] { 'a', 'n' }, new int[] { 2, 1 })]
        [InlineData("", true, new char[] { }, new int[] { })]
        [InlineData("!@#$$#@!", true, new char[] { '!', '@', '#', '$' }, new int[] { 2, 2, 2, 2 })]
        public async Task PostAsync_HandlesVariousInputs(string input, bool isPalindrome, char[] chars, int[] counts)
        {
            // Arrange
            var expectedOccurrences = new Dictionary<char, int>();
            for (int i = 0; i < chars.Length; i++)
            {
                expectedOccurrences.Add(chars[i], counts[i]);
            }

            _mockService.Setup(service => service.EhPalindromo(input)).Returns(isPalindrome);
            _mockService.Setup(service => service.ContarOcorrenciasCaracteres(input)).Returns(expectedOccurrences);

            var request = new ManipulacaoStringRequest { Texto = input };

            // Act
            var result = await _controller.PostAsync(request);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            var response = Assert.IsType<ManipulacaoStringResponse>(okResult.Value);
            Assert.Equal(isPalindrome, response.Palindromo);
            Assert.Equal(expectedOccurrences, response.OcorrenciasCaracteres);
        }
    }
}