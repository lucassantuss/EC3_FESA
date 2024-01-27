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
        public int Velocidade { get; set; } = 0;
        public event EventHandler<AcelerarEventArgs> onCarroAcelerou;
        public event EventHandler<FrearEventArgs> onCarroFreou;


        public void Acelerar()
        {
            Velocidade++;
            string msg = $"{Id} acelerou  para {Velocidade} km/h";
            if (onCarroAcelerou != null)
                onCarroAcelerou(this, new AcelerarEventArgs(msg));
        }

        public void Frear()
        {
            onCarroFreou?.Invoke(this, new FrearEventArgs($"{Id} freou"));            
        }
    }
}
