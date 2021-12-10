using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaBancaria.Dominio
{
    public static class Validacoes
    {
        public static string ValidaStringVaziaouNula(this string texto)
        {
            if (string.IsNullOrEmpty(texto))
            {
                throw new Exception("Verificar dados de inserção.");
            }

            return texto;
        }
    }


}
