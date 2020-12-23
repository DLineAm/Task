using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace WpfTask.Windows
{
    /// <summary>
    /// Логика взаимодействия для MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Window
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Readers_Click(object sender, RoutedEventArgs e)
        {
            var rmf = new ReaderManager(this) { Owner = this };
            this.Hide();
            rmf.Show();
        }

        private void Books_Click(object sender, RoutedEventArgs e)
        {
            var bmf = new BookManager();
            this.Hide();
            bmf.Show();
        }
    }
}
