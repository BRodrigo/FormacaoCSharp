using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Executando o projeto 5 - Caracteres e textos");

            // O char é um tipo de variável de 16 bits;
            char primeiraLetra = 'a';
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)65;
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);


            string titulo = "Alura Curos de Tecnologia " + 2020;
            string cursosProgramacao = @" - .NET 
                - Java 
                - Javascript";

            Console.WriteLine(titulo);
            Console.WriteLine(cursosProgramacao);




            Console.ReadLine();


        }
    }
}
