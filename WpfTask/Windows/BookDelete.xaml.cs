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
using WpfTask.Windows.Tables;

namespace WpfTask.Windows
{
    /// <summary>
    /// Логика взаимодействия для BookDelete.xaml
    /// </summary>
    public partial class BookDelete : Window
    {
        private Client selectedReader;

        public BookDelete(Client selectedReader)
        {
            InitializeComponent();
            this.selectedReader = selectedReader;
            LoadData();
        }

        private void LoadData() {
            var books = Database.db.BookTakings.Where(w => w.ClientId == selectedReader.Id).ToList();
            BooksDG.ItemsSource = books;
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        private void ApplyBtn_Click(object sender, RoutedEventArgs e)
        {
            var selectedBook = (BookTakings)BooksDG.SelectedItem;
            Database.db.BookTakings.Remove(selectedBook);
            Database.db.SaveChanges();
            LoadData();
        }
    }
}
