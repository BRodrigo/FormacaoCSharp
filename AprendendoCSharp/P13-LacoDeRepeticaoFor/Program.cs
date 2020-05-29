using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13_LacoDeRepeticaoFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 13 - Exercicio que imprime os números de 0 a 10 com o FOR");

            for (int contadorNumero = 0; contadorNumero <= 10; contadorNumero++)
            {
                Console.WriteLine(contadorNumero);
            }
            Console.ReadLine();
        }
    }
}
