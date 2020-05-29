using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Executando projeto 4");

            // Quando convertemos uma variavel de um tipo em outro tipo tem o nome de CAST.
            double salario = 1200.50;
            int salarioEmInteiro = (int)salario; 
            Console.WriteLine(salarioEmInteiro);

            //64bits, esse tipo ocupa mais espaço na memória.
            long idade = 1200000000000000000; 
            Console.WriteLine(idade);      

            //No tipo float é necessário acrescentarmos o sufixo "f", pois do contrário o C# entende que sem esse sufixo se trata de um double;
            float altura = 1.80f;
            Console.WriteLine(altura);

            //16bits;
            short quantidadeProdutos = 150; 
            Console.WriteLine(quantidadeProdutos);
            

            Console.WriteLine("Projeto finalizado, tecle ENTER para encerrar o programa...");
            Console.ReadLine();
        }
    }
}
