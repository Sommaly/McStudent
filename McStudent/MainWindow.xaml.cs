using McStudent.Classe;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
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
using System.Security.AccessControl;
using System.Configuration;
using McStudent.TP;

namespace McStudent
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
          Eleve eleve;
        
        public MainWindow(Eleve e)
        {
            InitializeComponent();
            this.main_frame.Content = new ListeTp(new Eleve(1, "seb", "seb", "seb"));
            this.eleve = e;
            // BASE DE DONNEEES
        }

        private void RadioButton_Checked_dashboard(object sender, RoutedEventArgs e)
        {
            this.main_frame.Content = new Dashboard();
        }

        private void RadioButton_Checked_voirTp(object sender, RoutedEventArgs e)
        {
            this.main_frame.Content = new ListeTp(new Eleve(1, "seb", "seb", "seb"));
        }

        private void RadioButton_Checked_voirPromo(object sender, RoutedEventArgs e)
        {
            this.main_frame.Content = new ListePromo();
        }

        private void RadioButton_Checked_creerTp(object sender, RoutedEventArgs e)
        {
            this.main_frame.Content = new CreerTP();
        }
        private void RadioButton_Checked_voirTpEleve(object sender, RoutedEventArgs e)
        {
            this.main_frame.Content = new ListeTpEleve();
        }
        private void RadioButton_Checked_changerMdp(object sender, RoutedEventArgs e)
        {
            this.main_frame.Content = new ChangerMdp();
        }
        private void RadioButton_Checked_deconnexion(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void RadioButton_quit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void main_frame_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
