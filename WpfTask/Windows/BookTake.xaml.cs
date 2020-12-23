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
    /// Логика взаимодействия для BookTake.xaml
    /// </summary>
    public partial class BookTake : Window
    {
        private Client currentClient;
        public BookTake(Client client)
        {
            InitializeComponent();
            currentClient = client;

            //DG.ItemsSource = Database.db.Book.ToList();

            LoadData();

            //var Kavo = (Book)TakeBookDG.SelectedItem;
        }

        private void LoadData()
        {
            var books = Database.db.Book.AsQueryable();
            {
                TakeBookDG.ItemsSource = books.Select(s => new
                {
                    Id = s.Id,
                    Name = s.Name,
                    Author = s.Author
                }).ToList();
            }
        }

        private void ApplyBtn_Click(object sender, RoutedEventArgs e)
        {
            if (TakeDP.SelectedDate == null || GiveDP.SelectedDate == null)
            {
                MessageBox.Show("Выберите дату взятия и окончания!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (TakeBookDG.SelectedItem == null)
            {
                //MessageBox.Show("Выберите книгу для выдачи!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                //return;
            }

            //TakeBookDG.
            Book selectedBook = (Book)TakeBookDG.SelectedItem;
            //MessageBox.Show(selectedItem.ToString());

            BookTakings taking = new BookTakings() {
                BookId = selectedBook.Id,
                Book = selectedBook,
                ClientId = currentClient.Id,
                Client = currentClient,
                TakeDate = TakeDP.SelectedDate,
                GiveDate = GiveDP.SelectedDate
            };

            Database.db.BookTakings.Add(taking);

            this.DialogResult = true;
        }
    }
}
