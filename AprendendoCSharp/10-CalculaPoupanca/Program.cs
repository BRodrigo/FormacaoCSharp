using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_CalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            //Esse ponto da nossa aula tem como foco estudar o laço de repetição WHILE

            Console.WriteLine("Executando projeto 10 - Calcula poupanca");

            double valorInvestido = 1000;
            int contadorMes = 1;

            while (contadorMes <= 12)
            {
                valorInvestido = valorInvestido + valorInvestido * 0.0036;

                if (contadorMes == 1)
                {
                    Console.WriteLine("Após " + contadorMes + " mes investido, você terá R$" + valorInvestido + " investido.");
                }
                else
                {
                    Console.WriteLine("Após " + contadorMes + " meses investido, você terá R$" + valorInvestido + " investido.");
                }
                contadorMes++;
            }

            Console.WriteLine("Programa executado com sucesso, tecle ENTER para finalizar a execucao...");
            Console.ReadLine();
        }
    }
}
