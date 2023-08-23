using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX9POO
{
    internal class Retangulo
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public double CalcularArea()
        {
            return Base * Altura;
        }

        public void ExibirMensagemArea()
        {
            double area = CalcularArea();
            Console.WriteLine("Área do retângulo: " + area);

            if (area > 100)
            {
                Console.WriteLine("Terreno grande");
            }
            else
            {
                Console.WriteLine("Terreno pequeno");
            }
        }
    }
}
