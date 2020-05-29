using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13_LacoDeRepeticaoWhile
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Executando projeto 13 - Exercicio que imprime os números de 0 a 10");

            int contador = 0;

            while(contador <= 10)
            {
                Console.WriteLine(contador);

                contador++;
            }

            for (int contadorNumero = 0; contadorNumero <= 10; contadorNumero++)
            {
                Console.Write(contadorNumero);
            }

            Console.ReadLine();
        }
    }
}
