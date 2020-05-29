using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12_CalculaInvestimentoLongoPrazo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Executando projeto 12 - Calculando investimento longo prazo");

            double valorInvestido = 1000;
            double fatorRendimento = 1.0036;

            for (int contadorAno = 1; contadorAno <= 5; contadorAno++)
            {
                for (int contador = 1; contador <= 12; contador++)
                {
                    valorInvestido *= fatorRendimento;
                }

                fatorRendimento += 0.0010;
            }

            Console.WriteLine("Ao término do investimento, você terá investido R$" + valorInvestido);

            Console.ReadLine();
        }
    }
}
