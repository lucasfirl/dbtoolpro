using System;
using System.Collections.Generic;
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

namespace DBTTool
{
    /// <summary>
    /// Interaktionslogik für Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string cs = "Server = " + dbsource.Text + "; Database = " + dbname.Text + "; User ID = " + dbuser.Text + "; Password = Password; Trusted_Connection = true";

            SqlConnection conn = new SqlConnection(cs);
            //conn.Open();


            MainWindow.BackToMain();
        }
    }
}
