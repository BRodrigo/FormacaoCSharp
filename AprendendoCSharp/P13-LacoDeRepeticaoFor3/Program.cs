using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13_LacoDeRepeticaoFor3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Executando projeto 13 - Exercicio que exibe que exibe uma MATRIZ...");
            Console.WriteLine();

            for (int linha = 0; linha < 10; linha++)
            {
                for (int coluna = 0; coluna < 10; coluna++)
                {
                    if (coluna > linha)
                    {
                        break;
                    }
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }

    }
}