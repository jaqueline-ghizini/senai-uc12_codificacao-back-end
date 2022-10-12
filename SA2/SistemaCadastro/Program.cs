/* COMANDOS TERMINAL
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
            List<PessoaFisica> listapf = new List<PessoaFisica>();
            static void BarraCarregamento(String mensagem){
                //Console.ResetColor();
                Console.Write(mensagem);
                Thread.Sleep(300);//tempo para fazer a proxima exibição
                
                for (var contador = 0; contador <10; contador++){
                    Console.Write("#");
                    Thread.Sleep(450);
                }
            }
            Console.WriteLine(@$"
===========================================
!                                         !
!              Seja bem vindo!            !
!          Sistema de Cadastro de         !
!       Pessoas Físicas e Jurídicas       !
!                                         !
===========================================
            ");
            Console.ForegroundColor = ConsoleColor.Green;
            BarraCarregamento("Iniciando ");
            Console.Clear();

            String? opcao;
            do{
                Console.WriteLine(@$"
====================================================
!         Escolha uma das opções abaixo            !
====================================================
!                                                  !
!                  Pessoa Física                   !
!           1- Cadastrar Pessoa Física             !
!           2- Listar Pessoa Física                !
!           3 - Remover Pessoa Física              !
!                                                  !
!                 Pessoa Jurídica                  !
!           4 - Cadastrar Pessoa Jurídica          !
!           5 - Listar Pessoa Jurídica             !
!           6 - Remover Pessoa Juríddica           !
!                                                  !
====================================================
!                      0 - Sair                    !  
====================================================
                ");
            
                opcao = Console.ReadLine();

                switch (opcao){
                    case "1":
                    //cadastrar pessoa física
                        Endereco EndPF = new Endereco();
                        Console.WriteLine("Digite seu logradouro: ");
                        EndPF.logradouro = Console.ReadLine();
                        Console.WriteLine("Digite o numero da residencia: ");
                        EndPF.numero = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o complemento. Caso não exista, pressione ENTER parapular. ");
                        EndPF.complemento = Console.ReadLine();
                        
                        //verificando se é endereco comercial
                        int contador = 0;
                        do{
                            Console.WriteLine("Esse endereço é comercial? Digite 1 pra Sim e 0 pra Não: ");
                            String numOpcao = Console.ReadLine();
                            if(numOpcao=="0"){
                                EndPF.enderecoComercial = false;
                                contador=1;
                            }else if (numOpcao=="1"){
                                EndPF.enderecoComercial = true;
                                contador= 1;
                            }else{
                                Console.WriteLine("Opcao informada invalida!");
                                contador =0;
                            }
                        }while(contador==0);
                         
                        //instacia objeto pesssoa fisica
                        PessoaFisica PF = new PessoaFisica();
                        PF.endereco = EndPF;
                        //cpf só com numeros
                        Console.WriteLine("Digite o CPF: ");
                        String cpf = Console.ReadLine();
                        PF.cpf = string.Join("", cpf.Split('@', ',', '.', ';', '-', ' ', '|', '/', '\''));//remove espeços e caracteres especiais
                        
                        Console.WriteLine("Digite seu nome: ");
                        PF.nome = Console.ReadLine();

                        Console.WriteLine("Digite o seu salario: ");
                        PF.salario = float.Parse(Console.ReadLine());
                        //chama pagar imposto
                        //float impostoapagar = PF.PagarImposto(PF.salario);
                        
                        //validar idade
                        Console.WriteLine("Digite sua data de aniversario [AAAA, MM, DD]");
                        PF.dataNascimento = DateTime.Parse(Console.ReadLine()); 
                        String data = PF.dataNascimento.ToString("dd/MM/yyyy");
                        bool idadeValida = PF.ValidarDataNascimento(PF.dataNascimento);
                        
                        //exibição
                        Console.WriteLine(@$"
Nome: {PF.nome}
CPF: {PF.cpf}
Nascido em: {data}
Endereco: {PF.endereco.logradouro} - {PF.endereco.numero}
Complemento: {PF.endereco.complemento}
Endereco comercial: {PF.endereco.enderecoComercial}");
                        
                        //validacao de idade,pagar imposto e exibicao
                        if(idadeValida == true){
                            Console.WriteLine("Cadastro Aprovado");
                            listapf.Add(PF);
                            Console.WriteLine("Salario: "+PF.salario);
                            Console.WriteLine("Imposto: "+PF.PagarImposto(PF.salario));
                        }else{
                            Console.WriteLine("Cadastro reprovado, você ainda não tem idade.");
                        }

                    break;

                    case "2":
                    //listar pessoa física
                        foreach(var cadaItem in listapf){
                            Console.WriteLine($"{cadaItem.nome}, {cadaItem.cpf}");
                        }
                    break;

                    case "3":
                    //remover pessoa física
                        Console.WriteLine("Digite o CPF que deseja remover.");
                        string cpfProcurado = Console.ReadLine();
                        PessoaFisica pessoaEncontrada = listapf.Find(cadaItem => cadaItem.cpf == cpfProcurado);

                        if (pessoaEncontrada != null){
                            listapf.Remove(pessoaEncontrada);
                            Console.WriteLine("Pessoa removida.");
                        }else{
                            Console.WriteLine("CPF não encontrado.");
                        }
                    break;

                    case "4":
                    //cadastrar pessoa jurídica

                    break;

                    case "5":
                    //listar pessoa jurídica
                    
                    break;

                    case "6":
                    //remover pessoa jurídica
                        
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



