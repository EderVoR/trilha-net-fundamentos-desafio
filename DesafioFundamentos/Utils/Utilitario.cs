using System.Text.RegularExpressions;

namespace DesafioFundamentos.Utils
{
    public static class Utilitario
    {
        public static bool ValidaPlaca(string placa)
        {
            if (string.IsNullOrEmpty(placa)) 
            { 
                return false; 
            }
            else if (placa.Length > 8) 
            { 
                return false; 
            }

            placa = placa.Replace("-", "").Trim();

            if (char.IsLetter(placa, 4))
            {
                var padraoMercosul = new Regex("[a-zA-Z]{3}[0-9]{1}[a-zA-Z]{1}[0-9]{2}");
                return padraoMercosul.IsMatch(placa);
            }
            else
            {
                var padraoNormal = new Regex("[a-zA-Z]{3}[0-9]{4}");
                return padraoNormal.IsMatch(placa);
            }

        }
    }
}