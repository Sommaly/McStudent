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
            else if (tbx_mdp.Text == "")
            {
                MessageBox.Show("Entrer un mot de passe !");
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=mcstudent;Integrated Security=SSPI");
                    SqlCommand cmd = new SqlCommand("select * from dbo.eleve where pseudo = @pseudo and mdp = @mdp", con);
                    cmd.Parameters.AddWithValue("@pseudo", tbx_pseudo.Text);
                    cmd.Parameters.AddWithValue("@mdp", tbx_mdp.Text);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Connection réussit !");
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
