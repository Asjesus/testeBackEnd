// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Olá, mundo!Hello, World!");

namespace Teste
{

class Program 
{

static void Main (string[]args)
{
    Endereco endPf = new Endereco();

    endPf.logradouro = "Rua x";
    endPf.numero = 100;
    endPf.complemento = "Proxímo ao Senai";
    endPf.enderecoComercial = true;

    Endereco endPJ = new Endereco();
    endPJ.logradouro = "Rua Niteroi";
    endPJ.numero = 5000;
    endPJ.complemento = "Próximo à estação";
    endPJ.enderecoComercial = true;


    PessoaFisica newpf = new PessoaFisica();

    newpf.cpf = 1239456789;
    newpf.dataNascimento = new DateTime(2000,02,20);
    newpf.nome = "Pessoa Fisica";
    newpf.endereco = endPf;
    newpf.salario = 7000;


    PessoaJuridica pj = new PessoaJuridica();

    PessoaJuridica newpj = new PessoaJuridica();

    newpj.cnpj = "12345678900001";
    newpj.razaoSocial = "Pessoa Juridica";
    newpj.endereco = endPJ;
    newpj.salario = 20000;

    Console.WriteLine($"Rua:{newpf.endereco.logradouro}, {newpf.endereco.numero}");

    Console.WriteLine($"Sua data de nascimento é: {newpf.dataNascimento}");

    bool idadeValida = newpf.ValidarDataNascimento(newpf.dataNascimento);
    Console.WriteLine (idadeValida);

    if(idadeValida == true){
        System.Console.WriteLine($"Cadastro Arpovado");
    } else {
        System.Console.WriteLine($"Cadastro Reprovado");
    }



   pj.ValidarCNPJ(newpj.cnpj);

   if(pj.ValidarCNPJ(newpj.cnpj)){
    Console.WriteLine("CNPJ é  válido");
   } else{
    Console.WriteLine("CNPJ é invalido");
   }


}  
 }
  }

  // esse código já serve para entregar nas aulas e atividade dês do encontro remoto 1 até 6. 