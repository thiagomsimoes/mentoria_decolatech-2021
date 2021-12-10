using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace AgenciaBancaria.Dominio
{
    public class Documentos
    {
        public string CPF { get; private set; }
        public string RG { get; private set; }

        public Documentos(string cpf, string rg)
        {
            cpf.ValidaStringVaziaouNula();

            if (!Regex.IsMatch(cpf, @"(^\d{3}\.\d{3}\.\d{3}\-\d{2}$)"))
            {
                throw new Exception("CPF: Verifique o formato de inserção do dado");
            }

            CPF = cpf;


            RG = rg.ValidaStringVaziaouNula();

            if (!Regex.IsMatch(rg, @"(^\d{1,2}).?(\d{3}).?(\d{3})-?(\d{1}|X|x$)"))
            {
                throw new Exception("RG: Verifique o formato de inserção do dado");
            }

            RG = rg;
        }
    }
}
