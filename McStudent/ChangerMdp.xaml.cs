using McStudent.Classe;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
    /// Logique d'interaction pour ChangerMdp.xaml
    /// </summary>
    public partial class ChangerMdp : Page
    {
        public ChangerMdp()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (isValid())
            {
                if (validateUserCredentials(tbx_pseudo.Text, tbx_oldmdp.Password.ToString())) 
                {
                    changePassword(tbx_pseudo.Text, tbx_newmdp.Password.ToString());
                }
                else
                {
                    MessageBox.Show("Cratère invalide");
                }
            }
        }

        private bool isValid()
        {
            if (string.IsNullOrEmpty(tbx_pseudo.Text))
            {
                MessageBox.Show("peusdo requis");
                return false;
            }
            else if (string.IsNullOrEmpty(tbx_oldmdp.Password.ToString()))
            {
                MessageBox.Show("Mot de passe requis");
                return false;
            } 
            else if (string.IsNullOrEmpty(tbx_newmdp.Password.ToString()))
            {
                MessageBox.Show("Nouveau peau de passe requis");
                return false;
            }
            else if (string.IsNullOrEmpty(tbx_newmdp2.Password.ToString()))
            {
                MessageBox.Show("confirmation mot de passe requis");
                return false;
            }
            else if (tbx_newmdp.Password.ToString() != tbx_newmdp2.Password.ToString())
            {
                MessageBox.Show("il faut les mêmes mots de passe");
                return false;
            }
            return true;
        }
        private bool validateUserCredentials(string pseudo, string password)
        {
            using (SqlConnection con = new SqlConnection("Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=mcstudent;Integrated Security=SSPI"))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.eleve WHERE pseudo = '" + pseudo + "' AND mdp = '" + password + "'", con);
                con.Open();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    return true;
                } else { return false; }
            }

        }

        private void changePassword (string pseudo, string newPassword)
        {
            using (SqlConnection con = new SqlConnection("Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=mcstudent;Integrated Security=SSPI"))
            {
                SqlCommand cmd = new SqlCommand("UPDATE dbo.eleve SET mdp = '" + newPassword + "' WHERE pseudo = '" + pseudo + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Mot de jaaj changé avec suces");

                
            }
        }

    }
}
