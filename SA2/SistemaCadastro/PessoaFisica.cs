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
        public float salario {get;set;}

        public override float PagarImposto(float salario){ //o override faz pegar o método da classe mae e sobrecreve na classe filha
            if(salario <= 1500){
                return 0;
            }else if((salario >1500)&&(salario <= 5000)){
                return salario*3/100;
            }else {
                return salario*5/100;
            }
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