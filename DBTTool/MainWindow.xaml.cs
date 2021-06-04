using System;
using System.Diagnostics;
using System.Net;
using System.Windows;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DBTTool
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private object content;
        public MainWindow()
        {
            InitializeComponent();
            Content = new Page1();
            content = Content;
        }
         
        public void BackToMain()
        {
            Content = content;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (speedtext.Text != "" && sizetext.Text != "")
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
                MessageBox.Show("Bitte gebe in beiden Boxen einen Wert an");
            }
        }

        private async void Button_AutomAsync(object sender, RoutedEventArgs e)
        {
            Mouse.OverrideCursor = System.Windows.Input.Cursors.Wait;
            speedbtn.IsEnabled = false;
            speedtext.Text = await Task.Run(() => Methoden.Speedcheck());
            Mouse.OverrideCursor = System.Windows.Input.Cursors.Arrow;
            speedbtn.IsEnabled = true;
        }
    }
}
 