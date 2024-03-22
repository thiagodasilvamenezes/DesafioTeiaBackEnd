namespace DesafioTeiaBackEnd.Model
{
    public class ManipulacaoStringRequest
    {
        public string Texto { get; set; } = string.Empty;
    }

    public class ManipulacaoStringResponse
    {
        public bool Palindromo { get; set; }
        public Dictionary<char, int> OcorrenciasCaracteres { get; set; } = new Dictionary<char, int>();
    }



}
