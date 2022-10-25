// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Olá, mundo!Hello, World!");

using System.Threading;
using System.Collections.Generic;

namespace Teste
{

class Program 
{

static void Main (string[]args)

{
   List<PessoaFisica> ListPf = new List<PessoaFisica>();
   Console.Clear();
   Console.ForegroundColor = ConsoleColor.DarkBlue;
   Console.BackgroundColor = ConsoleColor.White;
   Console.WriteLine(@$"
======================================
|Bem vindo ao sistema de cadastro de |
|pessoa física e pessoa jurídica     |
======================================
");
   
   BarraCarregamento("Iniciando");

   string? opcao;

   
   do
   {

    Console.WriteLine(@$" 
=====================================
|  Escolha umas das opções abaixo   |
|                                   |
|        PESSOA FÍSICA              |
|                                   |
|   1 - Cadastar Pessoa Física      |
|   2 - Listar Pessoa Física        |
|   3 - Remover Pessoa Física       |
|                                   |
|        PESSOA JURÍDICA            |
|                                   |
|   1 - Cadastrar Pessoa Jurídica   | 
|   2 - Listar Pessoa Jurídica      |
|   3 - Remover Pessoa Jurídica     | 
|                                   |
|      0 - Sair                     |
=====================================
");
  
    opcao = Console.ReadLine();

   switch (opcao)
   {
    case "1":

      Endereco endPf = new Endereco();

   Console.WriteLine($"Digite seu logradouro");
   endPf.logradouro = Console.ReadLine();

   Console.WriteLine($"Digite o número");
   endPf.numero = int.Parse(Console.ReadLine());

   Console.WriteLine($"Digite o complemento (aperte ENTER para vazio");
   endPf.complemento = Console.ReadLine();

   Console.WriteLine($"Este endereço é comercial? S/N");
   string endComercial = Console.ReadLine().ToUpper();


   if (endComercial == "s"){

    endPf.enderecoComercial = true;
   } else{
    endPf.enderecoComercial = false;
   }




    PessoaFisica newpf = new PessoaFisica();

   Console.WriteLine($"Digite seu CPF (somente números)");
    newpf.cpf = Console.ReadLine();
   Console.WriteLine($"Digite seu noome");
    newpf.nome = Console.ReadLine();
   Console.WriteLine($"Digite sua data de nascimento");
    newpf.dataNascimento = DateTime.Parse(Console.ReadLine());
    newpf.salario = 7000;


   

    Console.WriteLine($"Rua:{newpf.endereco.logradouro}, {newpf.endereco.numero}");

    Console.WriteLine($"Sua data de nascimento é: {newpf.dataNascimento}");

    bool idadeValida = newpf.ValidarDataNascimento(newpf.dataNascimento);
    Console.WriteLine (idadeValida);

    if(idadeValida == true){

        System.Console.WriteLine($"Cadastro Arpovado");
        ListPf.Add(newpf);
       

    } 
    
    else {
        System.Console.WriteLine($"Cadastro Reprovado");
    }

      break;

     case"2":

     foreach (var cadaItem in ListPf)
     {
      Console.WriteLine($"{cadaItem.nome}, {cadaItem.cpf}, {cadaItem.dataNascimento}");
     }
      break;

    case "3":

    Console.WriteLine($"Digite o CPF que deseja remover");
    string cpfProcurado = Console.ReadLine();

    PessoaFisica pessoaEncontrada =  ListPf.Find(cadaItem => cadaItem.cpf == cpfProcurado);

    if (pessoaEncontrada != null){

      ListPf.Remove(pessoaEncontrada);
      Console.WriteLine($"Cadastron Removido");

    } else {
      Console.WriteLine($"CPF não encontrado");
    }

    break;

     case "4":
   
    PessoaJuridica pj = new PessoaJuridica();

    PessoaJuridica newpj = new PessoaJuridica();

      Endereco endPJ = new Endereco();
    endPJ.logradouro = "Rua Niteroi";
    endPJ.numero = 5000;
    endPJ.complemento = "Próximo à estação";
    endPJ.enderecoComercial = true;

    newpj.cnpj = "41012440000146";
    newpj.razaoSocial = "Pessoa Juridica";
    newpj.endereco = endPJ;
    newpj.salario = 20000;

     
   pj.ValidarCNPJ(newpj.cnpj);

   if(pj.ValidarCNPJ(newpj.cnpj)){
   Console.WriteLine("CNPJ é  válido");
   } else{
    Console.WriteLine("CNPJ é invalido");
   }



      break;


   case "0": 

    BarraCarregamento ("Finalizando");
   
    break;

    default:
    Console.WriteLine($"opção invalida, digite uma opção válida");
      break;
   }
    
   } while (opcao != "0");














    //Endereco endPf = new Endereco();

    //endPf.logradouro = "Rua x";
    //endPf.logradouro = "Rua x";
    //endPf.numero = 100;
    //endPf.complemento = "Proxímo ao Senai";
    //endPf.enderecoComercial = true;

    //Endereco endPJ = new Endereco();
    //endPJ.logradouro = "Rua Niteroi";
    //endPJ.numero = 5000;
    //endPJ.complemento = "Próximo à estação";
    //endPJ.enderecoComercial = true;


    //PessoaFisica newpf = new PessoaFisica();

    //newpf.cpf = 1239456789;
    //newpf.dataNascimento = new DateTime(2000,02,20);
    //newpf.nome = "Pessoa Fisica";
    //newpf.endereco = endPf;
    //newpf.salario = 7000;


    //PessoaJuridica pj = new PessoaJuridica();

    //PessoaJuridica newpj = new PessoaJuridica();

    //newpj.cnpj = "12345678900001";
    //newpj.razaoSocial = "Pessoa Juridica";
    //newpj.endereco = endPJ;
    //newpj.salario = 20000;

    //Console.WriteLine($"Rua:{newpf.endereco.logradouro}, {newpf.endereco.numero}");

    //Console.WriteLine($"Sua data de nascimento é: {newpf.dataNascimento}");

    //bool idadeValida = newpf.ValidarDataNascimento(newpf.dataNascimento);
    //Console.WriteLine (idadeValida);

    //if(idadeValida == true){
      //  System.Console.WriteLine($"Cadastro Arpovado");
    //} else {
      //  System.Console.WriteLine($"Cadastro Reprovado");
    //}



   //pj.ValidarCNPJ(newpj.cnpj);

   //if(pj.ValidarCNPJ(newpj.cnpj)){
  //  Console.WriteLine("CNPJ é  válido");
   //} else{
    //Console.WriteLine("CNPJ é invalido");
   //}


//}  
 }
 
 static void BarraCarregamento( string textoCarregamento){

   Console.ResetColor();
   Console.ForegroundColor = ConsoleColor.DarkRed;
   Console.Write(textoCarregamento);
   Thread.Sleep(500);
   for (int contador = 0; contador < 10; contador++)
   {

  
   Console.Write($".");
   Thread.Sleep(500);
   
   }

   Console.ResetColor();
 }
 
 }
}

  // esse código já serve para entregar nas aulas e atividade dês do encontro remoto 1 até 7. 