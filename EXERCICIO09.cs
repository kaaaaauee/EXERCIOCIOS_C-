using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCIOCIOS_C_
{
    internal class EXERCICIO09
    {
        public static void Main(string[] args)
        {
            Exercicio9(); // Chama diretamente o Exercício 9
        }

        static void Exercicio9()
        {
            Console.WriteLine("Digite a classificação etária do filme (G, PG, PG-13, R):");
            string classificacao = Console.ReadLine().ToUpper(); // Converte para maiúsculas para garantir que o usuário insira corretamente

            switch (classificacao)
            {
                case "G":
                    Console.WriteLine("Faixa etária permitida: Livre");
                    break;
                case "PG":
                    Console.WriteLine("Faixa etária permitida: Maior de 10 anos");
                    break;
                case "PG-13":
                    Console.WriteLine("Faixa etária permitida: Maior de 13 anos");
                    break;
                case "R":
                    Console.WriteLine("Faixa etária permitida: Maior de 18 anos");
                    break;
                default:
                    Console.WriteLine("Classificação inválida. Por favor, insira uma das opções válidas (G, PG, PG-13, R).");
                    break;
            }
        }
    }
}
