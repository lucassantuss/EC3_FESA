using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadAlunoMVC.Models
{
    /// <summary>
    /// Classe principal
    /// </summary>
    public partial class AlunoViewModel : PadraoViewModel
    { 
        public string Nome { get; set; }        
        public double? Mensalidade { get; set; }
        public int CidadeId { get; set; }
        public DateTime DataNascimento { get; set; }        
    }
}
