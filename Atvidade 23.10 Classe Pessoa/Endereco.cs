

namespace Atvidade_23._10_Classe_Pessoa
{
    public class Endereco
    {
        public string Rua {get; set;} = string.Empty; // 'get' e 'set' são usados para armazenar os valores
                                                      // 'get' - Permite a leitura do valor da propriedade
                                                      // 'set' - Permite a atribuição de um novo valor à propriedade
        public int Numero {get; set;}
        public string Cidade {get; set;} = string.Empty;
        public string Estado {get; set;} = string.Empty;
        public string Cep {get; set;} = string.Empty;
        public string Complemento {get; set;} = string.Empty;
        public bool Comercial {get; set;}
    }
}