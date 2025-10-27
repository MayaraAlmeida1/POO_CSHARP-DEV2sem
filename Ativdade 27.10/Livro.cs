
namespace Ativdade_27._10
{
    public class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int AnoPublicacao {get; set; }
        // {
        //     get
        //     {
        //         return AnoPublicacao;
        //     }
        //     set
        //     {
        //         if (value > 0)
        //         {
        //             AnoPublicacao = value;
        //         }

        //         else
        //         {
        //             Console.WriteLine("Erro! Ano de publicação é inválido!");
        //         }
        //     }
        // }
        public double Preco { get; set; }
        public bool EstaDisponivel { get; set; } = true;

        //* CONSTRUTOR
        // é um método especial usado para inicializar o estado do objeto.

        public Livro(string TituloConstrutor, string AutorConstrutor, int AnoConstrutor, double PrecoConstrutor){ //msm nome da classe é o do construtor
            Titulo = TituloConstrutor; // this.Titulo = titulo
            Autor = AutorConstrutor;
            AnoPublicacao = AnoConstrutor;
            Preco = PrecoConstrutor;
            
            // Definindo o valor inicial como true
            EstaDisponivel = true;

            Console.WriteLine($"Novo Livro: {TituloConstrutor} criado e disponível.");
        } 

        //* CRIANDO MÉTODOS
        public void ExibirDetalhes()
        {
            Console.WriteLine("***** DETALHES DO LIVRO *****");
            Console.WriteLine($"Titulo: {Titulo}");
            Console.WriteLine($"Autor: {Autor}");
            Console.WriteLine($"Publicação: {AnoPublicacao}");
            Console.WriteLine($"Preço: {Preco:F2}"); // :F2 Formata com duas casas decimais

            if(EstaDisponivel){
                Console.WriteLine("Status: Disponível para empréstimo.");
            }
            else{
                Console.WriteLine("Status: Emprestado! (indisponível)");

            }
        }

        public void Emprestar()
        {
            if(EstaDisponivel){
                EstaDisponivel = false;
                Console.WriteLine($"O livro {Titulo} foi emprestado.");
            }
            else{
                Console.WriteLine($"O livro {Titulo} já está emprestado.");
            }
            
        }
    }
}