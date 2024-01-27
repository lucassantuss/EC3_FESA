using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteragindoComFormularios
{
    class AcelerarEventArgs : EventArgs
    {
        public string Msg { get; set; }        
        public AcelerarEventArgs(string msg)
        {
            Msg = msg;
        }
    }
}