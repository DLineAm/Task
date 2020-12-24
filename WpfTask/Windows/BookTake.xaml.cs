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

            TakeBookDG.ItemsSource = Database.db.Book.ToList();

            TakeDP.SelectedDate = DateTime.Now;
        }

        private void LoadData()
        {
            TakeBookDG.ItemsSource = Database.db.Book.ToList();
        }

        private void ApplyBtn_Click(object sender, RoutedEventArgs e)
        {
            if (GiveDP.SelectedDate == null)
            {
                MessageBox.Show("Выберите дату взятия и окончания!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (TakeBookDG.SelectedItem == null)
            {
                MessageBox.Show("Выберите книгу для выдачи!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            var date = DateTime.Now.Subtract(GiveDP.SelectedDate.Value);

            if (TakeDP.SelectedDate >= GiveDP.SelectedDate)
            {
                MessageBox.Show("Некорректная дата возврата", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            

            Book selectedBook = (Book)TakeBookDG.SelectedItem;

            BookTakings taking = new BookTakings() {
                BookId = selectedBook.Id,
                ClientId = currentClient.Id,
                TakeDate = TakeDP.SelectedDate,
                GiveDate = GiveDP.SelectedDate
            };

            Database.db.BookTakings.Add(taking);
            Database.db.SaveChanges();
            this.DialogResult = true;
        }
    }
}
