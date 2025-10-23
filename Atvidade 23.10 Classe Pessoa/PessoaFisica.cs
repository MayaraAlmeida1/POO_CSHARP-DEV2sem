
namespace Atvidade_23._10_Classe_Pessoa
{
    public class PessoaFisica : Pessoa
    {
        public string cpf {get; set;} = string.Empty;
        public DateTime DataNascimento {get; set;}

        public override void PagarImposto()
        {
           Console.WriteLine($"Pessoa Física: {Nome}, CPF: {cpf} - pagando imposto...");
        }
    }
}