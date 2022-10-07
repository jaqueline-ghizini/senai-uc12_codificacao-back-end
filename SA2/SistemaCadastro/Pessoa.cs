using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaCadastro
{
    public abstract class Pessoa // classe mae superclasse
    {
        //Atributos
        public string? nome {get; set;} //ao colocar interrogação depois de string, quer dizer que é um campo de preenchimento não obrigatório

        public string? endereco { get; set; }

        public bool enderecoComercial { get; set;}

        //Metodo
        public void PagarImposto(){}
    }
}