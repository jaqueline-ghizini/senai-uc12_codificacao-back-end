using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaCadastro
{
    public abstract class Pessoa // classe mae superclasse
    {
        public string nome {get; set;}

        public string endereco { get; set; }

        public bool enderecoComercial { get; set;}

        //metodo
        public void PagarImposto(){}
    }
}