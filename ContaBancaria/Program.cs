using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta conta;

            Console.WriteLine("Bem vindo ao Banco Nacional!!");
            Console.WriteLine();

            Console.Write("Insira o número da sua conta: ");
            int Num = int.Parse(Console.ReadLine());

            Console.Write("Insira o nome do titular da conta: ");
            string Titular = Console.ReadLine();

            Console.Write("Haverá um depósito inical? (s/n): ");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's' || resp == 'S')
            {
                Console.Write("Insira o valor do deposito incial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new Conta(Num, Titular, depositoInicial);
            }
            else
            {
                conta = new Conta (Num, Titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta: " + conta);
            Console.WriteLine();

            Console.Write("Insira um valor de depósito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);
            Console.WriteLine("Dados da conta atualizados: " + conta);
            Console.WriteLine();

            Console.Write("Insira um valor de saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);
            Console.WriteLine("Dados da conta atualizados: " + conta);
            Console.WriteLine();
        }
    }
}
