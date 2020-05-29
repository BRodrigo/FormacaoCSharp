using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Condicionais2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Executando projeto 8 - Condicionais 2");

            int idade = 18;
            int quantidadePessoas = 2;

            bool acompanhado = quantidadePessoas >= 2;

            if (idade >= 18 && acompanhado)
            {
                Console.WriteLine("Pode entrar...");
            }
            else
            {
                Console.WriteLine("Não pode entrar...");
            }

            Console.ReadLine();


        }
    }
}
