using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
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

namespace app1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<string> elemente = new List<string>();
            SoundPlayer player = new SoundPlayer(@"C:\Users\Robert Kubica\Downloads\In da club romanian remix 1 hour.wav");
            player.Load();
            player.Play();
        }

        public void ButtonAddName_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtName.Text) && !firstnames.Items.Contains(txtName.Text) && cb.IsChecked == true)
            {
                lb.Visibility = Visibility.Hidden;
                firstnames.Items.Add(txtName.Text);
                SoundPlayer player = new SoundPlayer(@"C:\Users\Robert Kubica\Downloads\Bine vericu,il angajez acum!.wav");
                player.Load();
                player.Play();
                txtName.Clear();
                System.Threading.Thread.Sleep(500);
                SoundPlayer player1 = new SoundPlayer(@"C:\Users\Robert Kubica\Downloads\In da club romanian remix 1 hour.wav");
                player1.Load();
                player1.Play();
            }
            else
            {
                lb.Visibility = Visibility.Visible;

            }
        }

        public class User
        {
            public string Name { get; set; }
            public int Age
            {
                get; set;
            }
            public string Mail { get; set; }
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        public void ButtonAddName(object sender, RoutedEventArgs e)
        {
            firstnames.Items.Refresh();
        }
    }
}

