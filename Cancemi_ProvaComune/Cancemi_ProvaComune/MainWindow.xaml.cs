﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace Cancemi_ProvaComune
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Maratona maratona;
        public MainWindow()
        {
            InitializeComponent();
            maratona = new Maratona();
            lstLista.ItemsSource = maratona.lista;
        }

        private void btnLeggi_Click(object sender, RoutedEventArgs e)
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
                    atleta.Tempo = maratona.CalcolaTempo(elementi[2]);
                    atleta.Città = elementi[3];

                    maratona.AggiungiElemento(atleta);

                }
                lstLista.Items.Refresh();


            }
        }

        private void btnTempo_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnAtleti_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
