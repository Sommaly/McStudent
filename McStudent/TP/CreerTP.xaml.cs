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
using System.Text.RegularExpressions;

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
            con.Open();
            string query = "INSERT INTO dbo.TP (id_TP, titre, description, dte_debut, dte_fin, is_actif, note) VALUES (@id_TP, @titre, @description, @dte_debut, @dte_fin, @is_actif, @note)";
            using (SqlCommand command = new SqlCommand(query, con))
            {
                command.Parameters.AddWithValue("@id_TP", 4);
                command.Parameters.AddWithValue("@titre", tbx_titre.Text);
                command.Parameters.AddWithValue("@description", tbx_description.Text);
                command.Parameters.AddWithValue("@dte_debut", dte_debut.SelectedDate);
                command.Parameters.AddWithValue("@dte_fin", dte_fin.SelectedDate);
                command.Parameters.AddWithValue("@is_actif", 0);
                command.Parameters.AddWithValue("@note", tbx_note.Text);
                command.ExecuteNonQuery();
            }
            con.Close();
        }
    }
}
