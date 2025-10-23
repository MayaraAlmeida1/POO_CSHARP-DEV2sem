
namespace Atvidade_23._10_Classe_Pessoa
{
    public class PessoaJuridica : Pessoa
    {
        public string cnpj {get; set;} = string.Empty;
        public string RazaoSocial {get; set;} = string.Empty;

         public override void PagarImposto()
        {
           Console.WriteLine($"Pessoa Jurídica: {Nome}, CNPJ: {cnpj} - pagando imposto...");
        }
    }
}