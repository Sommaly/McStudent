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
            LoadGrid();
        }

        SqlConnection con = new SqlConnection("Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=mcstudent;Integrated Security=SSPI");

        public void LoadGrid()
        {
            SqlCommand cmd = new SqlCommand("select * from dbo.TP", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            creer_tp.ItemsSource = dt.DefaultView;
        }

        private void btn_creer_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
