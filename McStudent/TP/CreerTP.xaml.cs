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
using McStudent.Classe;

namespace McStudent
{
    /// <summary>
    /// Logique d'interaction pour CreerTP.xaml
    /// </summary>
    public partial class CreerTP : Page
    {
        public CreerTP()
        {
            InitializeComponent();
            charger_promo();
        }

        //SqlConnection con = new SqlConnection("Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=mcstudent;Integrated Security=SSPI");
        SqlConnection con = new SqlConnection("Data Source=SOMMALY\\SQLEXPRESS;Initial Catalog = mcstudent;Integrated Security=True;Connect Timeout=30;Encrypt=False;");

        public void charger_promo()
        {
            SqlCommand cmd = new SqlCommand("select * from dbo.promo", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            liste_promo.ItemsSource = dt.DefaultView;
        }

        private void btn_creer_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
