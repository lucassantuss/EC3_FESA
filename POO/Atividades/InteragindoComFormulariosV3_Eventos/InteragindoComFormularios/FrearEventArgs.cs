using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteragindoComFormularios
{
    class FrearEventArgs : EventArgs
    {
        public string Msg { get; set; }
        public FrearEventArgs(string msg)
        {
            Msg = msg;
        }
    }
}
