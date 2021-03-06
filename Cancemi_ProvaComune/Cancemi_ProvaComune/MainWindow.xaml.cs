using System;
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

            maratona.Leggi();
            lstLista.Items.Refresh();
        }

        private void btnTempo_Click(object sender, RoutedEventArgs e)
        {
            string nome = txtAtleta.Text;
            string città = txtCitta.Text;
                
            lblTempo.Content = maratona.Tempo(nome, città);


        }

        private void btnAtleti_Click(object sender, RoutedEventArgs e)
        {
            string città = txtCitta.Text;
            lblAtleti.Content = maratona.TrovaAtleti(città);
        }

        private void btnInserisci_Click(object sender, RoutedEventArgs e)
        {
            string nome = txtNomeNuovo.Text;
            string società = txtSocietaNuovo.Text;
            string ore = txtOreNuovo.Text;
            string minuti = txtMinutiNuovo.Text;
            string città = txtCittaNuovo.Text;

            maratona.InserisciElemento(nome, società, ore, minuti, città);
            lstLista.Items.Refresh();



        }

        private void btnStampa_Click(object sender, RoutedEventArgs e)
        {
            string nome = txtAtleta.Text;
            string città = txtCitta.Text;

            maratona.Stampa(nome, città);
        }
    }
}
