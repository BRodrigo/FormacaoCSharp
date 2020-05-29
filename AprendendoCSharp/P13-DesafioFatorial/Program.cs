using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13_DesafioFatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Desafio do Fatorial");
            Console.WriteLine();

            int fatorial = 1;

            for (int i = 1; i < 11; i++)
            {
                fatorial *= i;
                Console.WriteLine("Fatorial de " + i + " = " + fatorial);
            }

            Console.ReadLine();
        }
    }
}
