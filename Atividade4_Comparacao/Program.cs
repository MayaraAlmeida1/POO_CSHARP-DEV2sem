namespace Atividade4_Comparacao;

class Program
{
    static void Main(string[] args)
    {
        //* Instanciar programador

        Programador dev = new Programador {Nome = "Lucas"};
        dev.Trabalhar();
        dev.ExecutarTarefa();

        Pessoa p = new Pessoa {Nome = "Pedro"};
        p.Falar();

        //* Não posso criar objeto a partir de classe abstrata
        // Funcionario f = new Funcionario {Nome = "Guilherme"};
        // f.Trabalhar();
    }
}
