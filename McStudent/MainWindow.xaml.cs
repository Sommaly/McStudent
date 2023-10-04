using McStudent.Classe;
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

namespace McStudent
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Eleve testEleve;
            testEleve = new Classe.Eleve("pseudo","prenom","motdepasse");
           
        }

        private void btn_voirTp_Click(object sender, RoutedEventArgs e)
        {
            this.main_frame.Content = new ListeTp();
        }

        private void btn_voirPromo_Click(object sender, RoutedEventArgs e)
        {
            this.main_frame.Content = new ListePromo();
        }
    }
}
