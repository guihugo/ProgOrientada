using System;
using System.Globalization;

//Classe com metodos para funcionamento do sistema de um banco
namespace Banco
{
    class Sistema
    {
        public int Conta {get; private set;}
        public string Nome {get; set;}
        public double Saldo {get; private set;}


        public Sistema (int conta, string nome)
        {
            Conta = conta;
            Nome = nome;

        }

        public Sistema(int conta, string nome, double saldo) : this(conta, nome) {
            Saldo = saldo;
        }

        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        public void Saque(double valor)
        {
            Saldo -= valor + 5;
        }

        public override string ToString() {
            return "Conta "
                + Conta
                + ", Titular: "
               + Nome
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }        
    }
}
    
