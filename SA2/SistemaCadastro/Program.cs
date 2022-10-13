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
            //instanciando pessoa jurídica
            PessoaJuridica metodoPJ = new PessoaJuridica();//instancia pra metodo diferente da de atributo
            Endereco EndPJ = new Endereco();
            PessoaJuridica PJ = new PessoaJuridica();
                                    
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
                            Console.WriteLine("Cadastro Aprovado e Realizado");
                            listapf.Add(PF);
                            Console.WriteLine("Salario: "+PF.salario);
                            //chamando Pagar Imposto
                            float impostoPf = PF.PagarImposto(PF.salario);
                            Console.WriteLine("Imposto a pagar: "+impostoPf);
                            //passando o cadastro para um arquivo txt
                            StreamWriter sw = new StreamWriter($"{PF.nome}.txt");
                            sw.Write(@$"
Nome: {PF.nome}
CPF: {PF.cpf}
Nascido em: {data}
Endereco: {PF.endereco.logradouro} - {PF.endereco.numero}
Complemento: {PF.endereco.complemento}
Endereco comercial: {PF.endereco.enderecoComercial}
Salario: {PF.salario}
Imposto a pagar: {impostoPf}");
                            sw.Close();
                        }else{
                            Console.WriteLine("Cadastro reprovado, você ainda não tem idade.");
                        }

                        
                    break;

                    case "2":
                    //listar pessoa física
                        foreach(var cadaItem in listapf){
                            Console.WriteLine($"{cadaItem.nome}, {cadaItem.cpf}");
                        }
                        //lendo do arquivo txt
                        Console.WriteLine("Digite seu nome da pessoa que quer consultar: ");
                        string pessoa = Console.ReadLine();

                        using (StreamReader sr = new StreamReader($"{pessoa}.txt")){
                            string linha;
                            while ((linha = sr.ReadLine()) != null){
                                Console.WriteLine($"{linha}");
                            }
                        }
                        Console.WriteLine($"Aperte 'Enter' para continuar..." );
                        Console.ReadLine();

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
                        Console.WriteLine("Digite seu logradouro: ");
                        EndPJ.logradouro = Console.ReadLine();
                        Console.WriteLine("Digite o numero da residencia: ");
                        EndPJ.numero = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o complemento. Caso não exista, pressione ENTER parapular. ");
                        EndPJ.complemento = Console.ReadLine();
                        
                        //verificando se é endereco comercial
                        int cont = 0;
                        do{
                            Console.WriteLine("Esse endereço é comercial? Digite 1 pra Sim e 0 pra Não: ");
                            String numOpcao = Console.ReadLine();
                            if(numOpcao=="0"){
                                EndPJ.enderecoComercial = false;
                                cont=1;
                            }else if (numOpcao=="1"){
                                EndPJ.enderecoComercial = true;
                                cont= 1;
                            }else{
                                Console.WriteLine("Opcao informada invalida!");
                                cont =0;
                            }
                        }while(cont==0);

                         //instacia objeto pesssoa juridica
                        PJ.endereco = EndPJ;

                        Console.WriteLine("Digite seu nome: ");
                        PJ.nome = Console.ReadLine();

                        //valida cnpj
                        int validado = 0;
                        do{
                            Console.WriteLine("Digite o CNPJ: ");
                            PJ.cnpj = Console.ReadLine();
                            if(PJ.ValidarCnpj(PJ.cnpj)){
                                Console.WriteLine("CNPJ  válido. Continuando o cadastro...");
                                validado=1;
                            }else{
                                Console.WriteLine("CNPJ inválido. Informe os numeros corretamente.");
                                validado=0;
                            }
                        } while(validado==0);

                        Console.WriteLine("Digite a razão social: ");
                        PJ.razaoSocial = Console.ReadLine();
                    
                        //calcula imposto
                        Console.WriteLine("Digite o seu rendimento: ");
                        PJ.rendimento = float.Parse(Console.ReadLine());
                        float impostoPj = PJ.PagarImposto(PJ.rendimento);

                        Console.WriteLine(@$"
Nome: {PJ.nome}
CNPJ: {PJ.cnpj}
Razão social: {PJ.razaoSocial}
Endereco: {PJ.endereco.logradouro} - {PJ.endereco.numero}
Complemento: {PJ.endereco.complemento}
Endereco comercial: {PJ.endereco.enderecoComercial}
Rendimentos: {PJ.rendimento}
Imposto a pagar: {impostoPj}");

                        metodoPJ.Inserir(PJ);
                        
                    break;

                    case "5":
                    //listar pessoa jurídica
                        List<PessoaJuridica> listapj = metodoPJ.Ler();
                        foreach(PessoaJuridica cadaItem in listapj){
                            Console.WriteLine(@$"
Nome: {cadaItem.nome}
CNPJ: {cadaItem.cnpj}
Razão social: {cadaItem.razaoSocial}
                            ");
                        }
                        
                        Console.WriteLine($"Aperte 'Enter' para continuar..." );
                        Console.ReadLine();
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



