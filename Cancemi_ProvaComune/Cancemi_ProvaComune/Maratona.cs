using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
            int minutiParziali = int.Parse(tempo.Substring(3, 2));

            minuti = (ore * 60) + minutiParziali;

            return minuti;
        }

        public int Tempo(string nome, string città)
        {
            int minuti = 0;

            foreach(var atleta in lista)
            {
                if(atleta.Nome == nome && atleta.Città == città)
                {
                    minuti = atleta.Tempo;
                }
            }

            return minuti;
        }


        public void Leggi()
        {
            using (FileStream flusso = new FileStream("dati.txt", FileMode.Open, FileAccess.Read))
            {

                StreamReader reader = new StreamReader(flusso);
                while (!reader.EndOfStream)
                {
                    var atleta = new Atleta();

                    string linea = reader.ReadLine();
                    string[] elementi = linea.Split('%');


                    atleta.Nome = elementi[0];
                    atleta.Società = elementi[1];
                    atleta.Tempo = CalcolaTempo(elementi[2]);
                    atleta.Città = elementi[3];

                    AggiungiElemento(atleta);

                }
                


            }
        }
    }


   
}
