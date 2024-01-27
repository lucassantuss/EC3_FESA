using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio18_POO
{
    public partial class Form1 : Form
    {
        Dictionary<string, ContaBancaria> dicionario = new Dictionary<string, ContaBancaria>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnContaCorrente_Click(object sender, EventArgs e)
        {
            txtListar.Clear();

            ContaCorrente cc = new ContaCorrente();

            try
            {
                cc.NomeCliente = txtNomeCorrente.Text;
                cc.NumeroConta = txtNumContaCor.Text;
                cc.Saldo = Convert.ToDouble(numSaldoCorrente.Value) + Convert.ToDouble(numLimiteCredito.Value);
                cc.LimiteCredito = Convert.ToDouble(numLimiteCredito.Value);

                if (rbNao.Checked)
                    cc.UtilizaTalao = false;
                else if (rbSim.Checked)
                    cc.UtilizaTalao = true;
                else
                    throw new Exception("Selecione se o cliente possui Talão ou não");

                if (!dicionario.ContainsKey(cc.NumeroConta))
                    dicionario.Add(cc.NumeroConta, cc);
                else
                    throw new Exception("Desculpe, mas já existe um cliente cadastrado com o número de conta corrente informado");

                txtNomeCorrente.Clear();
                txtNumContaCor.Clear();
                numSaldoCorrente.Value = 0;
                numLimiteCredito.Value = 0;
                rbNao.Checked = false;
                rbSim.Checked = false;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnContaPoupança_Click(object sender, EventArgs e)
        {
            txtListar.Clear();

            ContaPoupanca cp = new ContaPoupanca();

            try
            {
                cp.NomeCliente = txtNome.Text;
                cp.NumeroConta = txtNConta.Text;
                cp.NumContaCorrenteAtrelada = txtContaAtrelada.Text;
                cp.Saldo = Convert.ToDouble(txtSaldo.Value);
                cp.DiaAniversario = Convert.ToInt32(numDiaAniversario.Value);

                if (!dicionario.ContainsKey(cp.NumeroConta))
                {
                    if (!dicionario.ContainsKey(cp.NumContaCorrenteAtrelada))
                        dicionario.Add(cp.NumeroConta, cp);

                    else if (dicionario.ContainsKey(cp.NumContaCorrenteAtrelada))
                        throw new Exception("A conta corrente atrelada informada já foi cadastrada");
                }
                else
                    throw new Exception("Já existe um cliente cadastrado com o número de conta poupança informado");

                txtNome.Clear();
                txtNConta.Clear();
                txtContaAtrelada.Clear();
                txtSaldo.Value = 0;
                numDiaAniversario.Value = 1;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            txtListar.Clear();

            try
            {
                if (dicionario.ContainsKey(TxtNconta2.Text))
                {
                    foreach (ContaBancaria cb in dicionario.Values)
                        if (cb.NumeroConta == TxtNconta2.Text)
                            cb.Saque(Convert.ToDouble(txtValor.Value));
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            txtListar.Clear();

            try
            {
                if (dicionario.ContainsKey(TxtNconta2.Text))
                {
                    foreach (ContaBancaria cb in dicionario.Values)
                        if (cb.NumeroConta == TxtNconta2.Text)
                            cb.Deposito(Convert.ToDouble(txtValor.Value));
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            txtListar.Clear();

            foreach (ContaBancaria cb in dicionario.Values)
                txtListar.Text += cb.ToString();
        }
    }
}
