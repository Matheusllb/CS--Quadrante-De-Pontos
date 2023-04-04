using System;
using System.Globalization;

namespace CsE16
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //EXERCÍCIO 16
            Console.Write("Achando o quadrante dos pontos\n\nInforme dois valores (X Y) que não sejam NULOS EX(8 -8): ");
            string[] vet = Console.ReadLine().Split(' ');
            double x = double.Parse(vet[0]);
            double y = double.Parse(vet[1]);

            while(x != 0 && y != 0)
            {
                if (x > 0 && y > 0)
                    Console.WriteLine($"\nX: {x} Y: {y} Quadrante 1");
                else if (x > 0 && y < 0)
                    Console.WriteLine($"\nX: {x} Y: {y} Quadrante 4");
                else if (x < 0 && y > 0)
                    Console.WriteLine($"\nX: {x} Y: {y} Quadrante 2");
                else Console.WriteLine($"\nX: {x} Y: {y} Quadrante 3");

                Console.WriteLine("\nNovas valores:");
                vet = Console.ReadLine().Split(' ');
                x = double.Parse(vet[0]);
                y = double.Parse(vet[1]);
            }
            Console.WriteLine("\nValor nulo\nFim do Programa!\n");
        }
    }
}