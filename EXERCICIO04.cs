using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCIOCIOS_C_
{
    internal class EXERCICIO04
    {
        public static void Main(string[] args)
        {
            Exercicio4(); // Chama diretamente o Exercício 4
        }

        static void Exercicio4()
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Exibir 'Olá, Mundo!'");
            Console.WriteLine("2 - Exibir 'Bem-vindo ao C#'");
            Console.WriteLine("3 - Sair");
            Console.Write("Digite o número da opção desejada: ");

            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Olá, Mundo!");
                    break;
                case 2:
                    Console.WriteLine("Bem-vindo ao C#");
                    break;
                case 3:
                    Console.WriteLine("Saindo do programa...");
                    return; // Sai do programa
                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    break;
            }
        }
    }
}

