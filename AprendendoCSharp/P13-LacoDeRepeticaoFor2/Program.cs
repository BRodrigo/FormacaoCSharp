using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13_LacoDeRepeticaoFor2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Executando projeto 13 - Exercicio que exibe a tabuada...");
            Console.WriteLine();

            {
                for (int multiplicador = 1; multiplicador <= 1; multiplicador++)
                {
                    for (int contador = 0; contador <= 10; contador++)
                    {
                        Console.Write(multiplicador + " * " + contador + " = " + multiplicador * contador);
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                }
                Console.ReadLine();
            }
        }
    }
}
