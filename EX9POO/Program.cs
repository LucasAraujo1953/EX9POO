 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX9POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();

            Console.Write("Digite a base do retângulo: ");
            retangulo.Base = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a altura do retângulo: ");
            retangulo.Altura = Convert.ToDouble(Console.ReadLine());

            retangulo.ExibirMensagemArea();
        }
    }
}
