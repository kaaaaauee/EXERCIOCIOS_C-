using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCIOCIOS_C_
{
    internal class EXERCICIO10
    {
        public static void Main(string[] args)
        {
            Exercicio10(); // Chama diretamente o Exercício 10
        }

        static void Exercicio10()
        {
            Console.WriteLine("Digite um número para calcular o fatorial:");
            int numero = int.Parse(Console.ReadLine());

            if (numero < 0)
            {
                Console.WriteLine("Fatorial não existe para números negativos.");
                return;
            }

            int resultado = 1;

            switch (numero)
            {
                case 0:
                    Console.WriteLine("Fatorial de 0 é 1.");
                    break;
                default:
                    // Calcula o fatorial para números maiores que 0
                    for (int i = 1; i <= numero; i++)
                    {
                        resultado *= i;
                    }
                    Console.WriteLine($"Fatorial de {numero} é {resultado}.");
                    break;
            }
        }
    }
}
