using DesafioTeiaBackEnd.Model;
using DesafioTeiaBackEnd.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DesafioTeiaBackEnd.Controllers
{
    [Route("api/manipulacao-string")]
    [ApiController]
    public class ManipulacaoStringController : ControllerBase
    {
        private readonly ManipulacaoTexoService _textoService = new ManipulacaoTexoService();

        [HttpPost]
        public async Task<ActionResult<ManipulacaoStringResponse>> PostAsync([FromBody] ManipulacaoStringRequest request)
        {
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
