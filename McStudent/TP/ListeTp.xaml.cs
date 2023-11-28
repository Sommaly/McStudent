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
using McStudent.TP;
using McStudent.Classe;

namespace McStudent
{
    /// <summary>
    /// Logique d'interaction pour ListeTp.xaml
    /// </summary>
    public partial class ListeTp : Page
    {
        Eleve eleve;
        public ListeTp(Eleve e)
        {
            InitializeComponent();
            charger_tp();
            this.eleve = e;
        }

        //SqlConnection con = new SqlConnection("Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=mcstudent;Integrated Security=SSPI");
        SqlConnection con = new SqlConnection("Data Source=SOMMALY\\SQLEXPRESS;Initial Catalog = mcstudent;Integrated Security=True;Connect Timeout=30;Encrypt=False;");

        public void charger_tp()
        {
            SqlCommand cmd = new SqlCommand("select * from dbo.TP", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            liste_tp.ItemsSource = dt.DefaultView;
        }
    }

}
