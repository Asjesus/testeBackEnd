namespace Teste
{
    public abstract class Pessoa
    {
      public string? nome {get;set;}
      public Endereco? endereco { get; set; } 

      public float salario {get; set;}
      public abstract float PagarImposto(float salario);
        
       
    }
}