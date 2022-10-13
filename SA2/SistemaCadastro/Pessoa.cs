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

        //Metodos
        public abstract float PagarImposto(float rendimento);
    
        //metodo para verificar se já tem a pasta e o arquivo do cadastro criado
        public void verificarPastaArquivo(string caminho){
            string pasta = caminho.Split("/")[0];

            if(!Directory.Exists(pasta)){
                Directory.CreateDirectory(pasta);
            }
            if(!File.Exists(caminho)){
                using(File.Create(caminho)){}
            }
        }
    }
}