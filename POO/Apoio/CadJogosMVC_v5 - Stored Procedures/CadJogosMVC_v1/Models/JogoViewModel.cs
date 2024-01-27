﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadJogosMVC_v1.Models
{
    public class JogoViewModel
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public DateTime DataAquisicao { get; set; }
        public int CategoriaID { get; set; }

        public string DescricaoCategoria { get; set; }
    }
}
