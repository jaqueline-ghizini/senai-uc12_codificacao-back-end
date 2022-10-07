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

        public override void PagarImposto(float rendimento){ //o override faz pegar o método da classe mae e sobrecreve na classe filha
        }

        public bool ValidarDataNascimento(DateTime dataNascimento){
            DateTime dataAtual = DateTime.Today;

            double anos = (dataAtual - dataNascimento).TotalDays / 365;

            //verifica se tem mais que 18 anos pra retornar o valor booleano verdadeiro ou falso
            if(anos >= 18){
                return true;
            }else{
                return false;
            }
        }
    }
}