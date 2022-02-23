using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercico_Banco
{
    internal class Conta
    {
        public int NumeroDaConta { get; private set; }
        public string NomeTitular { get; set; }
        public double Saldo { get; private set; }

        public Conta(int numeroDaConta, string nomeTitular) 
        {
            NumeroDaConta = numeroDaConta;
            NomeTitular = nomeTitular;
        }

        public Conta(int numeroDaConta, string nomeTitular, double depositoInicial) : this(numeroDaConta, nomeTitular)
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
                + NumeroDaConta
                + ", Titular: "
                + NomeTitular
                +", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
