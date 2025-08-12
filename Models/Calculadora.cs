using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Home.Models
{
    public class Calculadora //Classe calculadora
    {
        public void Somar(int x, int y) //Metodo somar que irá realizar uma ação nos argumentos int x, int y
        {
            Console.WriteLine($"{x} + {y} = {x + y}"); //Imprime em tela {refere-se a usar os valores} o segundo {Realiza a operação}
        }

        public void Subtrair(int x, int y) //Metodo Subtrair
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }
        public void Multiplicar(int x, int y) //Metodo Multiplicar
        {
            Console.WriteLine($"{x} * {y} = {x * y}");
        }
         public void Dividir(int x, int y) //Metodo dividir
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }
    }

}