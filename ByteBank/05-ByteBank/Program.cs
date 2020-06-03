using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Cliente gabriela = new Cliente();

            gabriela.nome = "Gabriela" ;
            gabriela.profissao = "Desenvolvedora C#";
            gabriela.cpf = "345.345.345-06";*/

            ContaCorrente contaCorrente = new ContaCorrente();

            contaCorrente.titular = new Cliente();

            contaCorrente.titular.nome = "Gabriela";
            contaCorrente.titular.cpf = "345.345.345-06";
            contaCorrente.titular.profissao = "Desenvolvedora C#";

            contaCorrente.saldo = 500;
            contaCorrente.agencia = 563;
            contaCorrente.numero = 56345227;

            //Console.WriteLine(gabriela.nome);

            Console.WriteLine(contaCorrente.titular.nome);
            Console.WriteLine(contaCorrente.titular.cpf);
            Console.WriteLine(contaCorrente.titular.profissao);

            Console.ReadLine();

        }
    }
}
