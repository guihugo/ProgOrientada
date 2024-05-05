using System;
using System.Globalization;

//Codigo para implementação de um sistema de banco
namespace Banco
{
    class Cliente
    {
        static void Main(string[] args)
        {
            Sistema  s;

            System.Console.WriteLine("Bem vindo ao Banco");
            System.Console.WriteLine("Para abrir uma conta insera um número de conta, nome e se deseja um depósito inicial");

            System.Console.Write("Insira o número de conta");
            int conta = int.Parse(Console.ReadLine( ), CultureInfo.InvariantCulture);

            System.Console.Write("Entre o titular da conta");
            string nome = Console.ReadLine();

            System.Console.WriteLine("Haverá depósito incial (s/n)");
            string inicial = Console.ReadLine();
            
            if (inicial == "s")
            {
                Console.WriteLine("Insira o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                s = new Sistema(conta, nome, depositoInicial);
                
            }
            else
            {
                s = new Sistema(conta, nome); // Aqui, apenas número de conta e nome são passados
            }

            Console.WriteLine();
            Console.WriteLine(s); 
            
            Console.WriteLine("-----------------------------");
            Console.Write("Entre um valor para depósito: ");
            double quantia_deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            s.Deposito(quantia_deposito);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(s);

            Console.WriteLine("-----------------------------");
            Console.Write("Entre um valor para depósito: ");
            double quantia_saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            s.Saque(quantia_saque);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(s);


        }
    }
}
