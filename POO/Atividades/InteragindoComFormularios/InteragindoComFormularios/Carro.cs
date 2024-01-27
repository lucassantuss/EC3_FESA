using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteragindoComFormularios
{
    class Carro
    {
        public string Id { get; set; }

        public string Acelerar()
        {
            return $"{Id} acelerou";
        }

        public string Frear()
        {
            return $"{Id} freou";
        }
    }
}
