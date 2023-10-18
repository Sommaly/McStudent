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

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            this.main_frame.Content = new Dashboard();
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            this.main_frame.Content = new ListeTp();
        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            this.main_frame.Content = new ListePromo();
        }

        private void RadioButton_Checked_3(object sender, RoutedEventArgs e)
        {
            this.main_frame.Content = new Login2();
        }

        private void RadioButton_Checked_4(object sender, RoutedEventArgs e)
        {
            this.main_frame.Content = new CreerTP();
        }
    }
}
