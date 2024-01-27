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
            c = new Carro();
            c.Id = "Gol prata KKK-2526";

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            listBox1.Items.Add(c.Acelerar());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(c.Frear());
        }
    }
}
