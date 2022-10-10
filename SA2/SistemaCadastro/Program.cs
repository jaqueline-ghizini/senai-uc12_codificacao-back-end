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
            //Console.ReadLine(); //insere(le) valor no terminal
            Console.ForegroundColor = ConsoleColor.Green;
            //Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine(@$"
======================================
!                                    !
!           Seja bem vindo!          !
!       Sistema de Cadastro de       !
!    Pessoas Físicas e Jurídicas     !                          !
!                                    !
======================================
            ");
            Console.Write("Iniciando ");
            Thread.Sleep(500);//tempo para fazer a proxima exibição
            for (var contador = 0; contador <10; contador++){
                Console.Write("#");
                Thread.Sleep(500);
            }

            Console.Clear();

            String? opcao;
            do{
                Console.WriteLine(@$"
======================================
!   Escolha uma das opções abaixo    !
======================================
!                                    !
!       1 - Pessoa Física            !
!       2 - Pessoa Jurídica          !
!                                    !
!       0 - Sair                     !                       
!                                    !
======================================
                ");
            
                opcao = Console.ReadLine();

                switch (opcao){
                    case "1":
                    break;

                    case "2":
                    break;

                    case "0":
                        Console.Write("Finalizando Sistema ");
                        Thread.Sleep(500);//tempo para fazer a proxima exibição
                        for (var cont = 0; cont <10; cont++){
                            Console.Write("#");
                            Thread.Sleep(500);
                        }
                    break;

                    default:
                        Console.WriteLine("Por favor digite uma das opções disponíveis.");
                    break;
                }
            }while(opcao!="0");

            Console.ResetColor();

        /*  //endereco pessoa fisica
            Endereco end =  new Endereco();
            end.logradouro = "Rua do Refresco de Tamarindo";
            end.numero = 100;
            end.complemento = "Barril";
            end.enderecoComercial = false;

            //instanciando pessoa fisica
            PessoaFisica PF = new PessoaFisica();
            PF.endereco = end;
            PF.nome = "Chaves";
            PF.cpf= "123456789";
            PF.dataNascimento = new DateTime(2010, 05, 19);

            //interpolação
            Console.WriteLine($"O {PF.nome}, mora na {PF.endereco.logradouro} no {PF.endereco.complemento}"); //ocupa mais memória
            //concatenação
            Console.WriteLine("O "+ PF.nome + " mora no "+ PF.endereco.complemento);
            //forma não inteligente de exibir
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
            }*/

             //instanciando pessoa juridica
            PessoaJuridica PJ = new PessoaJuridica();

            //endereco pessoa juridica
            Endereco End =  new Endereco();
            End.logradouro = "Rua do Refresco de Tamarindo";
            End.numero = 80;
            End.complemento = "Restaurante da esquina";
            End.enderecoComercial = true;

            PJ.endereco = End;
            PJ.cnpj = "1234567899/0001";
            PJ.razaoSocial = "Restaurante da Dona Florinda";

            if(PJ.ValidarCnpj(PJ.cnpj)){
                Console.WriteLine("CNPJ  válido");
            }else{
                Console.WriteLine("CNPJ inválido");
            }
        }

    }
}
//auto identar = Shift + Alt + F



