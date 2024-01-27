using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InteragindoComFormularios
{
    public partial class Form1 : Form
    {
        Carro c;
        public Form1()
        {
            InitializeComponent();

            c = new Carro();
            c.onCarroAcelerou += C_onCarroAcelerou;
            c.onCarroFreou += C_onCarroFreou;
            c.Id = "Gol prata KKK-2526";            
        }

        private void C_onCarroFreou(object sender, FrearEventArgs e)
        {
            listBox1.Items.Add(e.Msg);
        }

        private void C_onCarroAcelerou(object sender, AcelerarEventArgs e)
        {
            listBox1.Items.Add(e.Msg);
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            c.Acelerar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            c.Frear();
        }
    }
}
