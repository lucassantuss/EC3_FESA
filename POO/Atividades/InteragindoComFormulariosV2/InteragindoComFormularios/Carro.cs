using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InteragindoComFormularios
{
    class Carro
    {
        public string Id { get; set; }
        public ListBox listbox { get; set; }

        public void Acelerar()
        {
            listbox.Items.Add($"{Id} acelerou");
        }

        public void Frear()
        {
            listbox.Items.Add( $"{Id} freou");
        }
    }
}
