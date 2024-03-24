using DesafioTeiaBackEnd.Model;
using DesafioTeiaBackEnd.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace DesafioTeiaBackEnd.Controllers
{
    [Route("api/manipulacao-string")]
    [ApiController]
    public class ManipulacaoStringController : ControllerBase
    {
        private readonly IManipulacaoTexoService _textoService;

        public ManipulacaoStringController(IManipulacaoTexoService textoService)
        {
            _textoService = textoService ?? throw new ArgumentNullException(nameof(textoService));
        }

        [HttpPost]
        public async Task<ActionResult<ManipulacaoStringResponse>> PostAsync([FromBody] ManipulacaoStringRequest request)
        {
            if (request == null)
            {
                return BadRequest("A requisição não pode ser vazia.");
            }
           
            if (string.IsNullOrWhiteSpace(request.Texto))
            {
                return BadRequest("O texto para análise não pode ser vazio.");
            }

            return await Task.Run(() =>
            {
                var ehPalindromo = _textoService.EhPalindromo(request.Texto.ToLower());
                var ocorrenciasCaracteres = _textoService.ContarOcorrenciasCaracteres(request.Texto.ToLower());

                return Ok(new ManipulacaoStringResponse
                {
                    Palindromo = ehPalindromo,
                    OcorrenciasCaracteres = ocorrenciasCaracteres
                });
            });
        }
    }
}
