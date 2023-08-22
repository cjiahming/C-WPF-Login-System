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

namespace Intern_Application
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-2J6G9H0A\SQLEXPRESS;Initial Catalog=InternDB;Integrated Security=True");
            try
            {
                if(con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                String query = "SELECT COUNT(1) FROM loginTable WHERE Username=@Username AND Password=@Password";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Username", usernameTxt.Text);
                cmd.Parameters.AddWithValue("@Password", passwordTxt.Password);
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if(count==1)
                {
                    MessageBox.Show("Success");
                    Homepage hp = new Homepage();
                    this.Content = hp;
                }
                else
                {
                    MessageBox.Show("Wrong Login Information");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

            }
        }
    }
}
