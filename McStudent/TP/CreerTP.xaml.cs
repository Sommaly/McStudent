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
        int compteur = 0;
        List<TextBox> lesTbx = new List<TextBox>();
        List<TextBox> lesTbxNote = new List<TextBox>();
        SqlConnection con = new SqlConnection("Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=mcstudent;Integrated Security=SSPI");
        //SqlConnection con = new SqlConnection("Data Source=SOMMALY\\SQLEXPRESS;Initial Catalog = mcstudent;Integrated Security=True;Connect Timeout=30;Encrypt=False;");

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
            Classe.TP nvTP;
            nvTP = new Classe.TP(5, tbx_titre.Text, tbx_description.Text, dte_debut.SelectedDate, dte_fin.SelectedDate, int.Parse(tbx_note.Text));
            con.Open();
            string query = "INSERT INTO dbo.TP (id_TP, titre, description, dte_debut, dte_fin, is_actif, note) VALUES (@id_TP, @titre, @description, @dte_debut, @dte_fin, @is_actif, @note)";
            using (SqlCommand command = new SqlCommand(query, con))
            {
                command.Parameters.AddWithValue("@id_TP", nvTP.id);
                command.Parameters.AddWithValue("@titre", nvTP.titre);
                command.Parameters.AddWithValue("@description", nvTP.description);
                command.Parameters.AddWithValue("@dte_debut", nvTP.dteDebut);
                command.Parameters.AddWithValue("@dte_fin", nvTP.dteFin);
                command.Parameters.AddWithValue("@is_actif", nvTP.isActif);
                command.Parameters.AddWithValue("@note", nvTP.note);
                command.ExecuteNonQuery();
            }
            con.Close();
            NavigationService.Navigate(new ListeTp(new Eleve(1, "seb", "seb", "seb")));

            if (compteur != 0)
            {
                for (int i = 1; i <= compteur; i++) {
                    Classe.Tache nvTache;
                    nvTache = new Classe.Tache(i, lesTbx[i-1].Text, int.Parse(lesTbxNote[i-1].Text), false, nvTP);
                    con.Open();
                    string query2 = "INSERT INTO dbo.tache (id_tache, nom_tache, points, is_obligatoire) VALUES (@id_tache, @nom_tache, @points, @is_obligatoire)";
                    using (SqlCommand command = new SqlCommand(query2, con))
                    {
                        command.Parameters.AddWithValue("@id_tache", nvTache.id);
                        command.Parameters.AddWithValue("@nom_tache", nvTache.nom);
                        command.Parameters.AddWithValue("@points", nvTache.points);
                        command.Parameters.AddWithValue("@is_obligatoire", nvTache.isObligatoire);
                        command.ExecuteNonQuery();
                    }
                    con.Close();
                }
            }
        }

        private void creer_tache_Click(object sender, RoutedEventArgs e)
        {
            compteur++;
            for (int i = compteur-1; i < compteur; i++)
            {
                // Créez une nouvelle TextBoxx
                TextBox nvtbx_tache = new TextBox();
                nvtbx_tache.Name = "tbx_tache" + compteur;
                nvtbx_tache.Width = 300;
                nvtbx_tache.Height = 17.96;
                // Créez une nouvelle Label
                Label nvlbl_tache = new Label();
                nvlbl_tache.Content = "Tache "+compteur;
                nvlbl_tache.Name = "lbl_tache" + compteur;
                nvlbl_tache.Foreground = Brushes.White;

                // Créez une nouvelle TextBox
                TextBox nvtbx_tacheNote = new TextBox();
                nvtbx_tacheNote.Name = "tbx_tachenote" + compteur;
                nvtbx_tacheNote.Width = 300;
                nvtbx_tacheNote.Height = 17.96;
                // Créez une nouvelle Label
                Label nvlbl_tacheNote = new Label();
                nvlbl_tacheNote.Content = "Note " + compteur;
                nvlbl_tacheNote.Name = "lbl_note" + compteur;
                nvlbl_tacheNote.Foreground = Brushes.White;

                // Ajoutez la TextBox et la Label au StackPanel
                dynamicControlsPanel.Children.Add(nvtbx_tache);
                dynamicControlsPanel.Children.Add(nvlbl_tache);
                dynamicControlsPanel.Children.Add(nvtbx_tacheNote);
                dynamicControlsPanel.Children.Add(nvlbl_tacheNote);

                lesTbx.Add(nvtbx_tache);
                lesTbxNote.Add(nvtbx_tacheNote);
            }
        }
    }
}
