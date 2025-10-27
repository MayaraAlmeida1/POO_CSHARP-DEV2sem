using System.Runtime.CompilerServices;

namespace Ativdade_27._10;

class Program
{
    static void Main(string[] args)
    {
        //* SEM CONSTRUTOR - traz valores vazios
    //     Livro novolivro = new Livro();

    //     Console.WriteLine($"Titulo: {novolivro.Titulo}");
    //     Console.WriteLine($"Ano: {novolivro.AnoPublicacao}");
    //     Console.WriteLine($"Disponível: {novolivro.EstaDisponivel}");

    //     //* Colocando valores manualmente
         
    //     novolivro.Titulo = "O Poder do Construtor";
    //     novolivro.Autor = "Parceiro de programação";
    //     novolivro.AnoPublicacao = 2025;
    //     novolivro.Preco = 59.90;
    //     novolivro.EstaDisponivel = true;
        
    //     Console.WriteLine("Exibindo detalhes: ");
    //     novolivro.ExibirDetalhes();
    // 

    //* COM CONSTRUTOR - Ao ter um construtor é necessário passar os parâmetros para ele
    Console.WriteLine(">>>>> Sistema de controle de biblioteca <<<<<"); 

    //Criando objeto novo com construtor
    Livro livro1 = new Livro("A Arte da Guerra", "Suz Tzu", 1950, 45.90);
    Livro livro2 = new Livro("Dom Casmurro", "Machado de Assis", 1889, 30.50);

    // Interação com os livros - Emprestar/ Ver detalhes (métodos)

    Console.WriteLine("Interagindo com o livro 1.");
    livro1.ExibirDetalhes();
    livro1.Emprestar();
    livro1.ExibirDetalhes();
    livro1.Emprestar(); // Ao tentar emprestar dnv não é possível pois já está emprestado

    Console.WriteLine("\n Interagindo com o livro 2.");
    livro2.ExibirDetalhes();
    livro2.Preco = 32.99;
    Console.WriteLine($"Atualização de preço: {livro2.Titulo} ajustado para R${livro2.Preco:F2}");
    livro2.ExibirDetalhes();
    }
}
