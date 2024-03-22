namespace DesafioTeiaBackEnd.Service
{
    public interface IManipulacaoTexoService
    {
        bool EhPalindromo(string texto);
        Dictionary<char, int> ContarOcorrenciasCaracteres(string texto);
    }
}
