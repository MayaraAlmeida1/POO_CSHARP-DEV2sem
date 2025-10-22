namespace Atividade2_ClasseAbstrata
{
    public abstract class Forma // Uma classe abstrata não pode ser instanciada(criar objetos), mas ela é usada/chamada em outros objetos
    {

        public abstract double CalcularArea(); // Ao trazer esse método como abstrato as classes filhas são obrigadas a implementá-lo e sobscrever (override)
        public void MostrarTipo() // Esse método não foi declarado como abstrato, portanto classes filhas não são obrigadas a implemntá-los
        {
            Console.WriteLine("Sou uma forma geométrica.");
        }
    }
}