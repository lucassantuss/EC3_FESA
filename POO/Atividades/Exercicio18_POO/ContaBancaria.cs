using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio18_POO
{
    abstract class ContaBancaria : Object
    {
        private string nomecliente;
        private string numeroconta;
        private double saldo;

        public string NomeCliente
        {
            get => nomecliente;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Informe o nome do cliente");
                else
                    nomecliente = value;
            }
        }

        public string NumeroConta
        {
            get => numeroconta;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Informe o número da conta !!!");
                else
                    numeroconta = value;
            }
        }

        public double Saldo { get => saldo; set => saldo = value; }

        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        public virtual void Saque(double valor)
        {
        }

        public override string ToString()
        {
            return $"Nome do Cliente: {NomeCliente}" + Environment.NewLine +
                $"Numero da Conta: {NumeroConta}" + Environment.NewLine +
                $"Saldo: R${Saldo:F2}" + Environment.NewLine;
        }
    }
}
