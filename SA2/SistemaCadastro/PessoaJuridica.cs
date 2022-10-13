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

        public float rendimento {get;set;}

        //indicou o caminho pra salvar os arquivos.
        public string caminho {get; private set;} = "Database/PessoaJuridica.csv";

        public override float PagarImposto(float rendimento){ ////o override faz pegar o método da classe mae e sobrecreve na classe filha
            float impostotoal =0;
            if(rendimento <= 5000){
                impostotoal =rendimento*6/100;
            }else if((rendimento > 5000)&&(rendimento <= 10000)){
                impostotoal =rendimento*8/100;
            }else {
                impostotoal = rendimento*10/100;
            }
            return impostotoal;
        }

        //metodo de validar cnpj
        public bool ValidarCnpj(String cnpj){
            //minha resolução:
            cnpj = string.Join("", cnpj.Split('@', ',', '.', ';', '-', ' ', '|', '/', '\''));//remove espeços e caracteres especiais
            char[] numcnpj = cnpj.ToCharArray();//coloca os valores do cnpj separadamente em uma array 
            
            //verificando quantidade de números e verificando os numeros finais
            if((cnpj.Length == 14)&&(numcnpj[10]=='0') && (numcnpj[11]=='0') && (numcnpj[12]=='0') && (numcnpj[13]=='1')){  
                return true;
            }else{
                return false;
            }
            //resolução em aula
            /* if((cnpj.Length >=14) && ((cnpj.Substring(cnpj.Length - 4))=="0001")){///seleciona apenas os ultimos 4 numeros por meio do substring
                return true;
            }else{
                return false;
            }
            */
        }

        //executando o método puxado de pessoa
        public void Inserir(PessoaJuridica pj){
            verificarPastaArquivo(caminho);

            string[] pjstring = {$"{pj.nome}, {pj.cnpj}, {pj.razaoSocial}"};
            File.AppendAllLines(caminho, pjstring);//passa o caminho e a lista
        }
        public List<PessoaJuridica> Ler(){//lista paara ler os dados do arquivo na parte de consulta
            List<PessoaJuridica> listapj = new List<PessoaJuridica>();
            
            string[] linhas = File.ReadAllLines(caminho);
            
            foreach (string cadaLinha in linhas){
                string[] atributos = cadaLinha.Split(",");
                PessoaJuridica cadaPj = new PessoaJuridica();

                cadaPj.nome = atributos[0];
                cadaPj.cnpj = atributos[1];
                cadaPj.razaoSocial = atributos[2];
                listapj.Add(cadaPj);
            }
            return listapj;
        }
    }
}
/*
char[] numero = new char[4] {'0','0','0','1'}; //como declarar uma array, pode ser também com outros valores, como strings e int

sobrescrita - sobrecarga

sobrescrita (override)
Esse método X que fazia isso, agora faz esse outro

spbrecarga (overload)
Esse método X que faz isso, agora também faz isso aqui
*/