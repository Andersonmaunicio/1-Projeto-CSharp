using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.PessoaCopia //NameSpace Organização de classes
{
    public class Pessoa //Classe pessoa
    {
        public string Nome { get; set; } //Propriedade Nome
        public int Idade { get; set; } //Propriedade Idade

        public void Apresentar() //Ação, métodoou função
        {
            Console.WriteLine($"Olá, Meu nome é {Nome}, e tenho {Idade} anos"); //Mensagem apresentada em tela Classe Console, Método WriteLine. Parametro ou argumento dentro de parfenteses.
       }
        
    }
}