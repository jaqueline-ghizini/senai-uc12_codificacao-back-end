using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaCadastro
{
    public class PessoaJuridica : Pessoa //classe herdeira
    {
        public string cnpj {get;set;}

        public string razaoSocial {get;set;}
    }
}