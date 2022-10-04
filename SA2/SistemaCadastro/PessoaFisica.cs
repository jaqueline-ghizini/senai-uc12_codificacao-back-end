using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaCadastro
{
    public class PessoaFisica : Pessoa // os dois pontos indica que uma classe está herdando da outra
    {
        public string cpf {get;set;}

        public DateTime dataNascimento {get;set;}
    }
}