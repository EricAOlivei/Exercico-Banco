using System;
using System.Globalization;

namespace Exercico_Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta c;

            Console.Write("Informe o numero da conta: ");
            int numConta = int.Parse(Console.ReadLine());

            Console.Write("Informe o titular da conta: ");
            string nome = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            char opc = char.Parse(Console.ReadLine());

            if (opc == 's' || opc == 'S')
            {
                Console.Write("Informe o depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                c = new Conta(numConta, nome, depositoInicial);
            }
            else
            {
                 c = new Conta(numConta, nome);
            }

            Console.Clear();

            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(c);

            Console.WriteLine();
            Console.Write("Informe o valor do dépósito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Deposito(quantia);

            Console.WriteLine();
            Console.WriteLine("Dados da conta atualizdos: ");
            Console.WriteLine(c);

            Console.WriteLine();
            Console.Write("Informe o valor do saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Saque(quantia);

            Console.WriteLine();
            Console.WriteLine("Dados da conta atualizdos: ");
            Console.WriteLine(c);
        }
    }
}