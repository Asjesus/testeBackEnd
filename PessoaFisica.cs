namespace Teste
{
    public class PessoaFisica : Pessoa
    {
        public int cpf { get; set; }

        public DateTime dataNascimento {get; set;}

        public override float PagarImposto (float salario)
        {
            if(salario <= 1500)
            {

                return 0;
            }
            else if (salario > 1500 && salario <= 5000)
            {
                return (salario / 100) * 3;
            }

            else
            {
                return (salario / 100) * 5;
            }

        }

        public bool ValidarDataNascimento (DateTime dataNasc){

            DateTime dataAtual = DateTime.Today;

            double anos = (dataAtual - dataNasc).TotalDays / 350;

            if (anos >= 18) {
                return true;
            } else {
                return false;
            }
        }
    }
}