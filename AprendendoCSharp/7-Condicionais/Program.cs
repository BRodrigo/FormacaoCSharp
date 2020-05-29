using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 7 - Condicionais");

            int idade = 16;
            int quantidadeDePessoas = 2;

            if (idade >= 18)
            {
                Console.WriteLine("João possui mais de 18 anos de idade. Pode entrar.");
                Console.WriteLine("Bem vindo");
            }
            else
            {
                if (quantidadeDePessoas >= 2)
                {
                    Console.WriteLine("João não possui mais de 18 anos de idade, mas está acompanhando então pode entrar");
                }
                else
                {
                    Console.WriteLine("João não possui mais de 18 anos. Não pode entrar.");
                }
            }

            Console.ReadLine();
        }
    }
}
