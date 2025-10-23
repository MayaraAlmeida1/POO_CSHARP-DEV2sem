

namespace Atvidade_23._10_Classe_Pessoa
{
    public abstract class Pessoa //Não pode ser instanciada
    {
        public string Nome {get; set;} = string.Empty; //'string.Empty' - preencher espaço com vazio ao invés de nulo
        // A diferença entre nulo e vazio é que nulo o computador entende como erro e vazio estamos avisando que sabemos que está vazio, que foi proposital

        public List<Endereco> Enderecos {get; } = new List<Endereco>();

        public abstract void PagarImposto();

        public void AdicionarEndereco(Endereco parametro_endereco)
        {
            Enderecos.Add(parametro_endereco); //'add' é para adiconar algo
        }
    }
}