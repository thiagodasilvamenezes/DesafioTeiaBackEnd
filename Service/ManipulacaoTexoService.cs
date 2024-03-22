namespace DesafioTeiaBackEnd.Service
{
    public class ManipulacaoTexoService: IManipulacaoTexoService
    {

        public bool EhPalindromo(string texto)
        {
            for (int i = 0, j = texto.Length - 1; i < j; i++, j--)
            {
                if (texto[i] != texto[j])
                    return false;
            }
            return true;
        }

        public Dictionary<char, int> ContarOcorrenciasCaracteres(string texto)
        {
            return texto.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());
        }

    }
}
