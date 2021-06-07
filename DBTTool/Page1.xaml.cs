using System.Data.SqlClient;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace DBTTool
{
    public partial class Page1 : Page
    {

        MainWindow mainWindow = MainWindow.GetMainWindow();
        public Page1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string cs = @"Data Source = " + dbsource.Text + "; Initial Catalog = " + dbname.Text + "; User ID = " + dbuser.Text + "; Password = " + dbpw.Password + ";";

            SqlConnection conn = new SqlConnection(cs);
            StringBuilder errorMessages = new StringBuilder();

            try
            {
                Mouse.OverrideCursor = System.Windows.Input.Cursors.Wait;
                conn.Open();
            }
            catch (SqlException ex)
            {
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Nachricht: " + ex.Errors[i].Message + "\n" +
                        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n" +
                        "Procedure: " + ex.Errors[i].Procedure + "\n");
                }
                MessageBox.Show(errorMessages.ToString());
            }


            Mouse.OverrideCursor = System.Windows.Input.Cursors.Arrow;
            if (conn.State.ToString() == "Open")
            {
                mainWindow.BackToMain(cs);
                conn.Close();
            }
        }

        private void Button_Skip(object sender, RoutedEventArgs e)
        {
            mainWindow.BackToMain("skip");
        }
    }
}
