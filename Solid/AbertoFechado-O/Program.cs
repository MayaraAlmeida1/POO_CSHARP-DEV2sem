namespace AbertoFechado_O;

class Program
{
    static void Main(string[] args)
    {
        Desconto d1 = new DescontoNatal();
        Desconto d2 = new DescontoBlackFriday();

        Console.WriteLine($"Natal: {d1.Calcular(1000):C}"); //':C traz o formato monetário do sistema da máquina'
        Console.WriteLine($"Black Fridar: {d2.Calcular(1000).ToString("C")}"); //'.ToString' faz a msm coisa que ':C'
        Console.WriteLine($"Black Friday: {d2.Calcular(2000)}"); // Sem formatação monetária, retorna apenas o valor
    }
}
