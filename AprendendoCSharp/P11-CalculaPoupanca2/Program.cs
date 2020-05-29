using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11_CalculaPoupanca2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Executando projeto 11 - Calculando poupança utilizando o FOR");

            double valorInvestido = 1000;

            for (int contador = 1; contador <= 12; contador++)
            {
                valorInvestido *= 1.0036;

                if (contador == 1)
                {
                    Console.WriteLine("Após " + contador + " mes investido, você terá R$" + valorInvestido + " investido.");
                }
                else
                {
                    Console.WriteLine("Após " + contador + " meses investido, você terá R$" + valorInvestido + " investido.");
                }

            }

            Console.WriteLine("Execução concluída, tecle ENTER para encerrar...");
            Console.ReadLine();
        }
    }
}
