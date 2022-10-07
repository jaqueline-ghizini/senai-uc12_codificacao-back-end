using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaCadastro
{
    public abstract class Pessoa // classe mae superclasse
    {
        //Atributos
        public string nome {get; set;} //ao colocar interrogação depois de string, quer dizer que é um campo de preenchimento não obrigatório

        public Endereco endereco { get; set; } // pega/recebe os atributos da classe Endereco

        //Metodo
        public abstract void PagarImposto(float rendimento);
    }
}