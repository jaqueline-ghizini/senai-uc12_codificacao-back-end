// See https://aka.ms/new-console-template for more information

/*
    COMANDOS TERMINAL
-------------------------
Comando para criar projeto:
- dotnet new console

Para rodar projeto:
-dotnet run
*/
namespace SistemaCadastro{//classe principal
    public class Program{
        static void Main(string[] args)
        {
            //Console.Beep(); //faz som de beep
            //Console.ReadLine(); //insere valor no terminal
            Console.WriteLine("**********************************");
            Console.WriteLine("*                                *");
            Console.WriteLine("*                                *");
            Console.WriteLine("*              ae                *");
            Console.WriteLine("*                                *");
            Console.WriteLine("*                                *");
            Console.WriteLine("**********************************");

            Endereco end =  new Endereco();
            end.logradouro = "Rua do Refresco de Tamarindo";
            end.numero = 100;
            end.complemento = "Barril";
            end.enderecoComercial = false;

            PessoaFisica PF = new PessoaFisica();
            PF.endereco = end;
            PF.nome = "Chaves";
            PF.cpf= "123456789";
            PF.dataNascimento = new DateTime(2010, 05, 19);

            //interpolação
            Console.WriteLine($"O {PF.nome}, mora na {PF.endereco.logradouro} no {PF.endereco.complemento}"); //ocupa mais memória
            //concatenação
            Console.WriteLine("O "+ PF.nome + " mora no "+ PF.endereco.complemento);
            //forma não inteligente
            Console.WriteLine(PF.nome);
            Console.WriteLine(PF.endereco.logradouro);
            Console.WriteLine(PF.endereco.numero);
            Console.WriteLine(PF.endereco.complemento);
            Console.WriteLine(PF.endereco.enderecoComercial);

            //para exibir resultado da operação e do if chamads e realizados
            Console.WriteLine(PF.ValidarDataNascimento(PF.dataNascimento));
            
            bool idadeValida = PF.ValidarDataNascimento(PF.dataNascimento);
            //Console.WriteLine(idadeValida);//ou pode exibir assim

            if(idadeValida == true)
            {
                System.Console.WriteLine("Cadastro Aprovado.Não desanime, se você é jovem ainda, jovem ainda, amanha deve e será.");
            }else{
                Console.WriteLine("Cadastro Reprovado. Você ainda é criança, vai brincar com a bola quadrada do Quico.");
            }
        }

    }
}




