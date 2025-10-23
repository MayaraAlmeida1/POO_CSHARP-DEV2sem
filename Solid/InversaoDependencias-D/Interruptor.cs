
namespace InversaoDependencias_D
{
    public class Interruptor
    {
        private readonly IDispositivo variavel_dispositivo_interface; //'readonly' - somente leitura / Variável criada como dispositivo
        private ArCondicionado ar;

        //* JEITO ERRADO
        public Interruptor()
        {   
            ar = new ArCondicionado();
        }

        //* JEITO CERTO
        //* Construtor que vai acionar o ligar no dispositivo
        // public Interruptor (IDispositivo parametro_dispositivo) // ou _dispositivo para não consfundir nome de variável
        // {
        //     this.variavel_dispositivo_interface = parametro_dispositivo; //'this' para não confundir nome de variável

        // }

        // public void Acionar() => variavel_dispositivo_interface.Ligar();

        //* JEITO ERRADO
        public void Acionar(){
            ar.Ligar();
        }
    }
}