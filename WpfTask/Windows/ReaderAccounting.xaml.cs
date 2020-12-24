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
    /// Логика взаимодействия для ReaderAccounting.xaml
    /// </summary>
    public partial class ReaderAccounting : Window
    {
        private Client selectedReader;

        public ReaderAccounting()
        {
            InitializeComponent();
        }

        public ReaderAccounting(Client selectedReader)
        {
            InitializeComponent();
            this.selectedReader = selectedReader;
            TitleLb.Content += " " + selectedReader.Id;
            FirstNameTB.Text = selectedReader.FirstName;
            MiddleNameTB.Text = selectedReader.LastName;
            LastNameTB.Text = selectedReader.LastName;
            LoadTextBox();
        }

        void LoadTextBox() {
            var clientBooks = Database.db.BookTakings.Where(w => w.ClientId == selectedReader.Id).ToList();
            var bookNames = new List<String>();
            foreach (var o in clientBooks) bookNames.Add(Database.db.Book.Find(o.BookId).Name);                
            BooksTB.Text = String.Join(", ",bookNames);
        } 

        private void ApplyBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(FirstNameTB.Text) ||
                !string.IsNullOrWhiteSpace(MiddleNameTB.Text) ||
                !string.IsNullOrWhiteSpace(LastNameTB.Text))
                this.DialogResult = true;
            else
                MessageBox.Show("Поля должны быть заполнены!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void AddBookBtn_Click(object sender, RoutedEventArgs e)
        {
            var bookTakeWindow = new BookTake(selectedReader);
            if (bookTakeWindow.ShowDialog() == true)
            {
                LoadTextBox();
            }
        }

        private void DeleteBookBtn_Click(object sender, RoutedEventArgs e)
        {
            var deletebookWindow = new BookDelete(selectedReader);
            if (deletebookWindow.ShowDialog() == true)
            {
                LoadTextBox();
            }
        }
    }
}
