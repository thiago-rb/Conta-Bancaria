using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    internal class Conta
    {
        public int Num { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public Conta(int num, string titular)
        {
            Num = num;
            Titular = titular;
        }
        public Conta(int num, string titular, double depositoInicial) : this(num, titular)
        {
            Deposito(depositoInicial);
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia + 5.0;
        }

        public override string ToString()
        {
            return "Conta: "
                + Num
                + ", Titular: "
                + Titular
                + ", Saldo da conta: $"
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
