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

        public override void PagarImposto(float rendimento){ ////o override faz pegar o método da classe mae e sobrecreve na classe filha

        }
    }
}
/*
sobrescrita - sobrecarga

sobrescrita (override)
Esse método X que fazia isso, agora faz esse outro

spbrecarga (overload)
Esse método X que faz isso, agora também faz isso aqui
*/