using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cancemi_ProvaComune
{
    class Maratona
    {
        public List<Atleta> lista = new List<Atleta>();

        public void AggiungiElemento(Atleta atleta)
        {
            lista.Add(atleta);
        }

        public int CalcolaTempo(string tempo)
        {
            int minuti = 0;

            int ore = int.Parse(tempo.Substring(0, 2));

            return minuti;
        }
    }

   
}
