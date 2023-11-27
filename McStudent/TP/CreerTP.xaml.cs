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
            Classe.TP nouveauTP;
            nouveauTP = new Classe.TP(5, tbx_titre.Text, tbx_description.Text, dte_debut.SelectedDate, dte_fin.SelectedDate, int.Parse(tbx_note.Text));
            con.Open();
            string query = "INSERT INTO dbo.TP (id_TP, titre, description, dte_debut, dte_fin, is_actif, note) VALUES (@id_TP, @titre, @description, @dte_debut, @dte_fin, @is_actif, @note)";
            using (SqlCommand command = new SqlCommand(query, con))
            {
                command.Parameters.AddWithValue("@id_TP", nouveauTP.id);
                command.Parameters.AddWithValue("@titre", nouveauTP.titre);
                command.Parameters.AddWithValue("@description", nouveauTP.description);
                command.Parameters.AddWithValue("@dte_debut", nouveauTP.dteDebut);
                command.Parameters.AddWithValue("@dte_fin", nouveauTP.dteFin);
                command.Parameters.AddWithValue("@is_actif", nouveauTP.isActif);
                command.Parameters.AddWithValue("@note", nouveauTP.note);
                command.ExecuteNonQuery();
            }
            con.Close();
            NavigationService.Navigate(new ListeTp());
        }
        int compteur = 0;

        private void creer_tache_Click(object sender, RoutedEventArgs e)
        {
            compteur++;
            for (int i = compteur-1; i < compteur; i++)
            {
                // Créez une nouvelle TextBox
                TextBox newTextBox = new TextBox();
                newTextBox.Name = "tbx_tache" + compteur;
                newTextBox.Width = 300;
                newTextBox.Height = 17.96;
                // Créez une nouvelle Label
                Label newLabel = new Label();
                newLabel.Content = "Tache "+compteur;
                newLabel.Name = "lbl_tache" + compteur;
                newLabel.Foreground = Brushes.White;

                // Créez une nouvelle TextBox
                TextBox newTextBox2 = new TextBox();
                newTextBox2.Name = "tbx_note" + compteur;
                newTextBox2.Width = 300;
                newTextBox2.Height = 17.96;
                // Créez une nouvelle Label
                Label newLabel2 = new Label();
                newLabel2.Content = "Note " + compteur;
                newLabel2.Name = "lbl_note" + compteur;
                newLabel2.Foreground = Brushes.White;

                // Ajoutez la TextBox et la Label au StackPanel
                dynamicControlsPanel.Children.Add(newLabel);
                dynamicControlsPanel.Children.Add(newTextBox);
                dynamicControlsPanel.Children.Add(newLabel2);
                dynamicControlsPanel.Children.Add(newTextBox2);
            }
        }
    }
}
