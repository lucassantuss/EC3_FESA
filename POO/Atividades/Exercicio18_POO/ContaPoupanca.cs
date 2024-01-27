using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio18_POO
{
    class ContaPoupanca : ContaBancaria
    {
        private string numContaCorrenteAtrelada;

        public int DiaAniversario { get; set; }

        public string NumContaCorrenteAtrelada
        {
            get => numContaCorrenteAtrelada;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Informe o número da conta corrente atrelada !!!");
                else
                    numContaCorrenteAtrelada = value;
            }
        }

        public override void Saque(double valor)
        {
            if (valor <= Saldo)
                Saldo -= valor;
            else
                throw new Exception("O valor de saque é maior que o saldo disponível");
        }

        public override string ToString()
        {
            return "---Conta Poupança---" + Environment.NewLine +
                base.ToString() + $"Número da conta corrente atrelada {NumContaCorrenteAtrelada}" +
                Environment.NewLine + $"Dia do aniversário: {DiaAniversario}" + Environment.NewLine +
                Environment.NewLine;
        }
    }
}
