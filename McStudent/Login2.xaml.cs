﻿using System;
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
    /// Logique d'interaction pour Login2.xaml
    /// </summary>
    public partial class Login2 : Page
    {
        public Login2()
        {
            InitializeComponent();

        }

        private void btn_connecter_Click(object sender, RoutedEventArgs e)
        {
            if (tbx_pseudo.Text == "")
            {
                MessageBox.Show("Entrer un nom !");
            }
            else if (tbx_mdp.ToString() == "")
            {
                MessageBox.Show("Entrer un mot de passe !");
            }
            else
            {

                try
                {
                    SqlConnection con = new SqlConnection("Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=mcstudent;Integrated Security=SSPI"); con.Open();
                    // SqlConnection con = new SqlConnection("Data Source=SOMMALY\\SQLEXPRESS;Initial Catalog = mcstudent;Integrated Security=True;Connect Timeout=30;Encrypt=False;");
                    SqlCommand cmd = new SqlCommand("select * from dbo.eleve", con);
                    cmd.Parameters.AddWithValue("@pseudo", tbx_pseudo.Text);
                    cmd.Parameters.AddWithValue("@mdp", tbx_mdp.ToString());

                    SqlDataReader sqlDataReader = cmd.ExecuteReader();
                    

                    // SqlDataAdapter da = new SqlDataAdapter(cmd);
                    // DataTable dt = new DataTable();

                    // da.Fill(dt);

                    if (sqlDataReader.Read())
                    {
                        MessageBox.Show("Connexion réussie !");
                        // Accéder à la fenêtre parente
                        var mainWindow = Window.GetWindow(this) as MainWindow;

                        // Fermer la fenêtre actuelle (Login2)
                        mainWindow?.Close();

                        // Ou la cacher
                        // mainWindow?.Hide();

                        // Créer et afficher une nouvelle fenêtre
                        var newMainWindow = new MainWindow( new Eleve(1, "seb", "seb", "seb"));
                        newMainWindow.Show();
                    }
                    else
                    {
                        MessageBox.Show("Champs invalides");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
            }
        }
    }
}
