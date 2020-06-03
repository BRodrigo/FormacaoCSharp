using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente conta = new ContaCorrente();
            Cliente cliente = new Cliente();

            cliente.Nome = "Breno";
            cliente.CPF = "345.345.345-98";
            cliente.Profissao = "Desenvolvedor C#";

            conta.Saldo = -10;

            Console.WriteLine(conta.Saldo);
            Console.WriteLine(cliente.Nome);

            Console.ReadLine()
;        }
    }
}
