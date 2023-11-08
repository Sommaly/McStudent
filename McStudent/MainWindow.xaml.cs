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
            this.main_frame.Content = new ListeTp();

            // BASE DE DONNEEES
        }

        private void btn_voirTp_Click(object sender, RoutedEventArgs e)
        {
            this.main_frame.Content = new ListeTp();
        }

        private void btn_voirPromo_Click(object sender, RoutedEventArgs e)
        {
            this.main_frame.Content = new ListePromo();
        }

        private void btn_login_Click(object sender, RoutedEventArgs e)
        {
            this.main_frame.Content = new Login2();
        }

        private void btn_dashboard_Click(object sender, RoutedEventArgs e)
        {
            this.main_frame.Content = new Dashboard();
        }

        private void btn_creerTP_Click(object sender, RoutedEventArgs e)
        {
            this.main_frame.Content = new CreerTP();
        }

        private void btn_voirTpEleve_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
