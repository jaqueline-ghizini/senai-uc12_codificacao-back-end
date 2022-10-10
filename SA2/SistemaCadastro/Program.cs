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

            static void BarraCarregamento(String mensagem){
                //Console.ResetColor();
                Console.Write(mensagem);
                Thread.Sleep(500);//tempo para fazer a proxima exibição
                
                for (var contador = 0; contador <10; contador++){
                    Console.Write("#");
                    Thread.Sleep(500);
                }
            }
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
            Console.ForegroundColor = ConsoleColor.Green;
            //Console.BackgroundColor = ConsoleColor.White;
            BarraCarregamento("Iniciando ");
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
                        //endereco pessoa fisica
                        Endereco endPfUm =  new Endereco();
                        endPfUm.logradouro = "Rua do Refresco de Tamarindo";
                        endPfUm.numero = 100;
                        endPfUm.complemento = "Barril";
                        endPfUm.enderecoComercial = false;

                        //instanciando pessoa fisica
                        PessoaFisica Chaves = new PessoaFisica();
                        Chaves.endereco = endPfUm;
                        Chaves.nome = "Chaves";
                        Chaves.cpf= "123456789";
                        Chaves.dataNascimento = new DateTime(2010, 05, 19);

                        String data = Chaves.dataNascimento.ToString("dd/MM/yyyy");
                        //concatenação
                        Console.WriteLine(@$"Nome: {Chaves.nome} 
CPF: {Chaves.cpf}
Nascido em: {data}
Endereco: {Chaves.endereco.logradouro} - {Chaves.endereco.numero}
Complemento: {Chaves.endereco.complemento}
Endereco comercial: {Chaves.endereco.enderecoComercial}");
                        /*//interpolação
                        Console.WriteLine($"O {PF.nome}, mora na {PF.endereco.logradouro} no {PF.endereco.complemento}"); //ocupa mais memória
                        //concatenação
                        Console.WriteLine("O "+ PF.nome + " mora no "+ PF.endereco.complemento);*/

                        //para exibir resultado da operação e do if chamadas e realizados
                        //Console.WriteLine(PF.ValidarDataNascimento(PF.dataNascimento));
                        
                        bool idadeValida = Chaves.ValidarDataNascimento(Chaves.dataNascimento);
                        //Console.WriteLine(idadeValida);//ou pode exibir assim

                        if(idadeValida == true)
                        {
                            System.Console.WriteLine("Cadastro Aprovado.Não desanime, se você é jovem ainda, jovem ainda, amanha deve e será.");
                        }else{
                            Console.WriteLine("Cadastro Reprovado. Você ainda é criança, vai brincar com a bola quadrada do Quico.");
                        }
                    
                    break;

                    case "2":
                         //instanciando pessoa juridica
                        PessoaJuridica PJ = new PessoaJuridica();

                        //endereco pessoa juridica
                        Endereco EndPj =  new Endereco();
                        EndPj.logradouro = "Rua do Refresco de Tamarindo";
                        EndPj.numero = 80;
                        EndPj.complemento = "Restaurante da esquina";
                        EndPj.enderecoComercial = true;

                        PJ.endereco = EndPj;
                        PJ.cnpj = "1234567899/0001";
                        PJ.razaoSocial = "Pessoa Juridica";
                        PJ.nome = "Restaurante da Dona Florinda";

                        Console.WriteLine(@$"Nome: {PJ.nome} 
Razão Social: {PJ.razaoSocial}
Endereco: {PJ.endereco.logradouro} - {PJ.endereco.numero}
Complemento: {PJ.endereco.complemento}
Endereco comercial: {PJ.endereco.enderecoComercial}
CNPJ: {PJ.cnpj}");

                        if(PJ.ValidarCnpj(PJ.cnpj)){
                            Console.WriteLine("CNPJ  válido");
                        }else{
                            Console.WriteLine("CNPJ inválido");
                        }

                    break;

                    case "0":
                        Console.WriteLine("Obrigada por utilizar o nosso sistema!");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        BarraCarregamento("Finalizando ");
                    break;

                    default:
                        Console.WriteLine("Por favor digite uma das opções disponíveis.");
                    break;
                }
            }while(opcao!="0");

            Console.ResetColor();
            
        }

    }
}
//auto identar = Shift + Alt + F



