using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaBancaria.Dominio
{
    public class Cliente
    {
        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public Endereco Endereco { get; private set; }

        public Documentos Documentos { get; private set; }


        public Cliente (string nome, string sobrenome, Endereco endereco, Documentos documentos)
        {
            Nome =nome.ValidaStringVaziaouNula();
            Sobrenome = sobrenome.ValidaStringVaziaouNula();
            Endereco = endereco;
            Documentos = documentos;
            
                   
        }
        
    }
}
