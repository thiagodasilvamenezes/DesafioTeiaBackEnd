namespace DesafioTeiaBackEnd.Model
{
    public class ManipulacaoStringRequest
    {
        public string Texto { get; set; }
    }

    public class ManipulacaoStringResponse
    {
        public bool Palindromo { get; set; }
        public Dictionary<char, int> OcorrenciasCaracteres { get; set; }
    }



}
