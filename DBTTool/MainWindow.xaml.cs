using System;
using System.Windows;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Text.RegularExpressions;

namespace DBTTool
{
    public partial class MainWindow : Window
    {
        private object content;
        private string connectionString;
        public MainWindow()
        {
            InitializeComponent();
            content = Content;
            Content = new Page1();
        }

        public void BackToMain(string cs)
        {
            Content = content;
            connectionString = cs;

            if (cs == "skip")
            {
                sizebtn.IsEnabled = false;
            }
            else
            {
                sizebtn.IsEnabled = true;
            }
        }

        public static MainWindow GetMainWindow()
        {
            MainWindow mainWindow = null;

            foreach (Window window in Application.Current.Windows)
            {
                Type type = typeof(MainWindow);
                if (window != null && window.DependencyObjectType.Name == type.Name)
                {
                    mainWindow = (MainWindow)window;
                    if (mainWindow != null)
                    {
                        break;
                    }
                }
            }


            return mainWindow;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (speedtext.Text != "" && sizetext.Text != "" && Regex.Matches(speedtext.Text, @"[a-zA-Z]").Count < 1 && Regex.Matches(sizetext.Text, @"[a-zA-Z]").Count < 1)
            {
                double dbsize = Convert.ToDouble(sizetext.Text);
                double espeed = Convert.ToDouble(speedtext.Text) / 8;

                if (combo.SelectedIndex == -1)
                {
                    MessageBox.Show("Bitte gebe eine Einheit an");
                }

                double result = Methoden.BerechneDownloadZeit(combo.SelectedIndex, dbsize, espeed);

                double hours = Math.Round(result / 3600);
                double minutes = Math.Round(result / 60 % 60);
                resultlabel.Content = "Geschätze Wartezeit: " + hours + "h " + minutes + "m";
            }
            else
            {
                MessageBox.Show("Bitte gebe in beiden Boxen einen Wert an.\n\nOder Überprüfe auf Buchstaben.");
            }
        }

        private async void Button_SizeAutomAsync(object sender, RoutedEventArgs e)
        {
            Mouse.OverrideCursor = System.Windows.Input.Cursors.Wait;
            sizebtn.IsEnabled = false;
            string result = await Task.Run(() => Methoden.CheckDBSize(connectionString));
            string resulteinheit = result.Substring(result.IndexOf(" ") + 1);

            switch (resulteinheit)
            {
                case "B": // Byte
                    combo.SelectedIndex = 0;
                    break;
                case "KB": // KB
                    combo.SelectedIndex = 1;
                    break;
                case "MB": // MB
                    combo.SelectedIndex = 2;
                    break;
                case "GB": // GB
                    combo.SelectedIndex = 3;
                    break;
                case "TB": // TB
                    combo.SelectedIndex = 4;
                    break;
            }

            sizetext.Text = result.Substring(0, result.ToString().IndexOf(" "));
            Mouse.OverrideCursor = System.Windows.Input.Cursors.Arrow;
            sizebtn.IsEnabled = true;
        }

        private async void Button_InternetAutomAsync(object sender, RoutedEventArgs e)
        {
            Mouse.OverrideCursor = System.Windows.Input.Cursors.Wait;
            speedbtn.IsEnabled = false;
            speedtext.Text = await Task.Run(() => Methoden.Speedcheck());
            Mouse.OverrideCursor = System.Windows.Input.Cursors.Arrow;
            speedbtn.IsEnabled = true;
        }

        private void Button_Return(object sender, RoutedEventArgs e)
        {
            Content = new Page1();
        }
    }
}
 