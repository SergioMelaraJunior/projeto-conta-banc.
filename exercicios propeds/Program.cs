using System;
using System.Globalization;

namespace exercicios_propeds {
    class Program {
        static void Main(string[] args) {
            ContaBancaria conta;

            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's' || resp == 'S') {
                Console.Write("Entre o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, depositoInicial);
            }
            else {
                conta = new ContaBancaria(numero, titular);
            }
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Dados da Conta");
            Console.WriteLine(conta);

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(deposito);

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Dados da Conta Atualizaos");
            Console.WriteLine(conta);

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(saque);

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Dados da Conta Atualizaos");
            Console.WriteLine(conta);



        }
    }
}
