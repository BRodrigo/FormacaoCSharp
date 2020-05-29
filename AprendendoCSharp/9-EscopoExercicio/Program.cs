using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_EscopoExercicio
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Executando projeto 9 - Exercicio calculo imposto de renda");

            // De 1900.0 até 2800.0 o IR é de 7.5% e pode deduzir R$ 142
            // De 2800.01 até 3751.0 o IR é de 15% e pode deduzir R$ 350
            // De 3751.01 até 4664.00 o IR é de 22.5% e pode deduzir R$ 636

            double salario = 4300.0;

            if (salario >= 1900.00 && salario <= 2800.00)
            {
                Console.WriteLine("Seu IR será de 7.5%");
                Console.WriteLine("Será deduzido da declaração R$142.00");
            }

            else if (salario >= 2800.01 && salario <= 3751.0)
            {
                Console.WriteLine("Seu IR será de 15%");
                Console.WriteLine("Será deduzido da declaração R$350.00");
            }

            else if (salario >= 3751.01 && salario <= 4664.00)
            {
                Console.WriteLine("Seu IR será de 22.5%");
                Console.WriteLine("Será deduzido da declaração R$636.00");
            }

            Console.ReadLine();

        }
    }
}
