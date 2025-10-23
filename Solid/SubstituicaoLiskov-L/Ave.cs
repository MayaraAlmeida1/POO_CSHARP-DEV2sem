
namespace SubstituicaoLiskov_L
{
    public abstract class Ave // Clsse abstrata para herdar informções
    {
        public abstract void Mover(); // abstratact obriga a sobscrever o método em outros objetos

        public virtual void Dormir() => Console.WriteLine("Dormindo..."); // ao colocar virtual, não é obrigado a sobscrever o método em outros objetos, mas permite sobscrever caso queira, senão vai o padrão já escrito
    }
}