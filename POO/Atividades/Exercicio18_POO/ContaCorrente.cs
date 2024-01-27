using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio18_POO
{
    class ContaCorrente : ContaBancaria
    {
        public double LimiteCredito { get; set; }

        public bool UtilizaTalao { get; set; }

        public override void Saque(double valor)
        {
            if (valor <= Saldo)
                Saldo -= valor;
            else
                throw new Exception("O valor de saque é maior que o saldo disponível");
        }

        public override string ToString()
        {
            return $"---Conta Corrente---" + Environment.NewLine +
                 $"Nome do Cliente: {NomeCliente}" + Environment.NewLine +
                 $"Numero da Conta: {NumeroConta}" + Environment.NewLine +
                 $"Saldo + Limite de Crédito: R${Saldo:F2}" + Environment.NewLine +
                 $"Limite de Crédito: R${LimiteCredito:F2}" + Environment.NewLine +
                 $"Utiliza Talão: {UtilizaTalao}" + Environment.NewLine + Environment.NewLine;
        }
    }
}

