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
                    minuti = CalcolaTempo(atleta.Tempo);
                }
            }

            return minuti;
        }


        public string TrovaAtleti(string città)
        {
            string atleti = "";

            foreach (var atleta in lista)
            {
                if (atleta.Città == città)
                {
                    atleti += atleta.Nome + ";  ";
                }
            }

            return atleti;
        }


        public void InserisciElemento(string nome, string società, string ore, string minuti, string città)
        {
            bool esiste = false;

            foreach (var atleta in lista)
            {
                if (atleta.Città == città && atleta.Nome == nome)
                {
                    esiste = true;
                }
            }

            if(esiste == false)
            {
                var atleta = new Atleta();
                atleta.Nome = nome;
                atleta.Società = società;
                atleta.Città = città;
                atleta.Tempo = ore + "h" + minuti + "m";

                AggiungiElemento(atleta);
            }

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
                    atleta.Tempo = elementi[2];
                    atleta.Città = elementi[3];

                    AggiungiElemento(atleta);

                }
                


            }
        }



        public void Stampa( string nome, string città)
        {
            string tempo = "";
           
            
            foreach(var atleta in lista)
            {
                if(atleta.Nome == nome && atleta.Città == città)
                {
                    tempo = atleta.Tempo;
                }
            }

            string elenco = "";

            foreach (var atleta in lista)
            {
                if (CalcolaTempo(atleta.Tempo) < CalcolaTempo(tempo) && atleta.Città == città)
                {
                    elenco += atleta.Nome + "\n";
                }
            }


            string nomeFile = nome + "%" + tempo + ".txt";

            using (FileStream flusso = new FileStream(nomeFile, FileMode.Create, FileAccess.Write))
            {

                StreamWriter writer = new StreamWriter(flusso);

                writer.WriteLine(elenco);
                writer.Flush();


            }
        }
    }


   
}
