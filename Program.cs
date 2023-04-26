using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int b;
            int a;
            int h;

                Console.WriteLine("Vamos calcular a área de um terreno retângular ");
            Console.Write("Digite sua base: ");
            b=int.Parse(Console.ReadLine());
            Console.Write("Digite sua altura: ");
            a=int.Parse(Console.ReadLine());

            h = a * b;
            Console.WriteLine("Seu terreno tem área de {0}m²", h) ;
            if (h >= 100)
                Console.WriteLine("Seu terreno é grande!");
            else
                Console.WriteLine("Seu terreno é pequeno!");
        }
    }
}
