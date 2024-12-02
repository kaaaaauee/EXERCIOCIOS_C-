using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCIOCIOS_C_
{
    internal class EXERCICIO06
    {
        public static void Main(string[] args)
        {
            Exercicio6(); // Chama diretamente o Exercício 6
        }

        static void Exercicio6()
        {
            Console.WriteLine("Escolha uma bebida:");
            Console.WriteLine("1 - Café");
            Console.WriteLine("2 - Chá");
            Console.WriteLine("3 - Suco");
            Console.WriteLine("4 - Refrigerante");
            Console.Write("Digite o número da bebida escolhida: ");

            int escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    Console.WriteLine("Você escolheu: Café");
                    break;
                case 2:
                    Console.WriteLine("Você escolheu: Chá");
                    break;
                case 3:
                    Console.WriteLine("Você escolheu: Suco");
                    break;
                case 4:
                    Console.WriteLine("Você escolheu: Refrigerante");
                    break;
                default:
                    Console.WriteLine("Opção inválida! Escolha um número de 1 a 4.");
                    break;
            }
        }
    }
}
