using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13_DesafioMultiplosDe3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Desafio - Exibindo múltiplos de 3 de 0 a 100");
            Console.WriteLine();


            for (int numero = 0;  numero <= 100; numero++)
            {
                if (numero % 3 == 0)
                
                    Console.WriteLine(numero);
            }

            Console.ReadLine();
        }
    }
}
