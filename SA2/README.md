
# SISTEMA DE CADASTRO DE CLIENTE #
## UC12 - SA2 - Atividade Online 3 - Back End ##

    Documentação técnica, por meio de um arquivo readme.md, do sistema de clientes que deverá cadastrar e armazenar cadastros de pessoas físicas e jurídicas em arquivos. Referente a Atividade Online 3.

___
## <img align="center" alt="Jaque-Csharp" height="30" width="30" src="https://img.icons8.com/color/48/000000/light.png"> Feature 

A ClientLab é uma empresa fictícia focada na gestão de clientes e, atualmente, mantém a sua base de registro em papel e não possui nenhuma automatização ou tecnologia que facilite o processo de busca de clientes e/ou registro de suas atividades. O Sistema de Cadastro foi feito vizando automatizar essas atividades, por meio da realização do cadastro por meio do usuário e da criação de um arquivo com o registro dos dados.


##  <img align="center" alt="Jaque-Csharp" height="30" width="30" src="https://raw.githubusercontent.com/devicons/devicon/master/icons/csharp/csharp-original.svg"> Tecnologias Utilizadas 
Foram escolhidas nesse projeto:
+ <img style="width: 20px;" src="" /> Linguagem C# (Csharp). Por ser uma linguagem de alto nível e orientada a objeto.
- <img style="width: 20px" src="">.NET (Donet). Por ser um framework que fornece diversos serviços como uma biblioteca de classes e mecanismo de execusão para aplicativos. 

## <img align="center" alt="Jaque-vscode" height="30" width="30" src="https://img.icons8.com/color/48/000000/note.png" /> Organização do Projeto ##
O projeto tem uma estrutura orientada a objeto com uma relação de Herança entre as Classes, sendo elas:
+ Classe Pessoa. Superclasse, ou classe Mãe/Pai, com os atributos 'nome' e 'endereço',  e o método 'pagar imposto'.
- Classe Pessoa Física. Subclasse, ou classe Filha, além de herdar as propriedades da mãe, também tem os atributos 'CPF' e 'data de nascimento'.
+ Classe Pessoa Jurídica. Subclasse, ou classe Filha, além de herdar as propriedades da mãe, também tem os atributos 'CNPJ' e 'razão social'. 

## <img align="center" alt="Jaque-vscode" height="30" width="30" src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/vscode/vscode-original.svg" /> Pré-requisitos de Instalação ##

Se você deseja baixar editar e/ou executar esse sistema, é preciso ter:
+ Visual Studio Code
- Extenções C#
+ .NET atualizado
- Acesso ao GitHub

## <img align="center" alt="Jaque-vscode" height="30" width="30" src="https://img.icons8.com/fluency/48/000000/run-command.png" /> Execução da Aplicação ##

- Executar por meio do donet run.
+ Para iniciar uma classe: Clicar com o botão direito no menu do projeto e selecionar a opção New C#, depois Class.

## <img align="center" alt="Jaque-vscode" height="30" width="30" src="https://img.icons8.com/color/48/000000/error--v1.png" /> Erros Comuns ##

+ Falta de Extensões.
- Ferramentas desatualizadas.
+ Falta de salvamento.

## <img align="center" alt="Jaque-vscode" height="30" width="30" src="https://img.icons8.com/fluency/48/000000/handshake.png" /> Contribuidores ##

Projeto elaborado em aula, por Jaqueline Ghizini, com orientação do professor Caique Zaneti.


