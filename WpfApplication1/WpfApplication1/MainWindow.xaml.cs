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

namespace WpfApplication1
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

        private void Insert_click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("insert clicked");
            string code = this.txtcode.Text;
            string fname = this.txtname.Text;
            string lname = this.txtlname.Text;
           // DateTime bdate = this.calBirthdt.SelectedDate.Value;
            //DateTime adate = this.calAppdt.SelectedDate.Value;
            string countryCode = (this.Countrycode.SelectedItem as ComboBoxItem).Content.ToString();
            string showstr = $"{code},{fname},{lname},{countryCode}";
            MessageBox.Show(showstr);
            if(this.RbFemale.IsChecked==true)
            {
                MessageBox.Show("female");
            }
            if (this.RbMale.IsChecked == true)
            {
                MessageBox.Show("Male");
            }
            if (this.RbHuman.IsChecked == true)
            {
                MessageBox.Show("Human");
            }
            SqlConnection conn= null;
            try
            {
                conn = new SqlConnection(@"Data Source = ADMIN\SQLEXPRESS; Integrated Security = SSPI;" + "Initial Catalog=Recruitment");
                conn.Open();
                string sql = "Insert into ExternalCandidate" + "(cCandidateCode,vFirstName,vLastName)" + "values (@code,@fname,@lname)";
                using(SqlCommand command = new SqlCommand(sql, conn))
                {
                    SqlParameter parameter = new SqlParameter
                    {
                        ParameterName = "@code",
                        Value = code,
                        SqlDbType = SqlDbType.Char,
                        Size = 6
                    };
                    command.Parameters.Add(parameter);
                    parameter = new SqlParameter
                    {
                        ParameterName = "@fname",
                        Value = fname,
                        SqlDbType = SqlDbType.VarChar,
                        Size = 20
                    };
                    command.Parameters.Add(parameter);
                    parameter = new SqlParameter
                    {
                        ParameterName = "@lname",
                        Value = lname,
                        SqlDbType = SqlDbType.VarChar,
                        Size = 20
                    };
                    command.Parameters.Add(parameter);
                    command.ExecuteNonQuery();
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show("DONE");
        }

        private void Update_click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("update clicked");

        }

        private void Delete_click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("delete clicked");

        }
    }
}
