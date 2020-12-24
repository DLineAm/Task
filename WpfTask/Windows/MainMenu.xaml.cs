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
    /// Логика взаимодействия для MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Window
    {
        public MainMenu()
        {
            InitializeComponent();
            Database.db.Database.Initialize(true);
        }

        private void Readers_Click(object sender, RoutedEventArgs e)
        {
            var readerManagerWindow = new ReaderManager(this) { Owner = this };
            this.Hide();
            if(readerManagerWindow.ShowDialog() == false) this.Close();

        }

        private void Books_Click(object sender, RoutedEventArgs e)
        {
            var bookManagerWindow = new BookManager(this) { Owner = this };
            this.Hide();
            if(bookManagerWindow.ShowDialog() == false) this.Close();
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            var reportWindow = new ReportWindow(this) {Owner = this };
            this.Hide();
            if(reportWindow.ShowDialog() == false) this.Close();
        }

        private void FillLink_Click(object sender, RoutedEventArgs e)
        {
            Database.db.Book.Add(new Book { Name = "Мастер и маргарита", Author = "Булгаков М.А." });
            Database.db.Book.Add(new Book { Name = "Дубровский", Author = "Пушкин А.С." });
            Database.db.Book.Add(new Book { Name = "Идиот", Author = "Достоевский Ф.М." });
            Database.db.Book.Add(new Book { Name = "Демон", Author = "Лермонтов М.Ю." });
            Database.db.Book.Add(new Book { Name = "Чайка", Author = "Чехов А.П." });
            Database.db.Book.Add(new Book { Name = "Человек-амфибия", Author = "Беляев А.Р" });
            Database.db.Book.Add(new Book { Name = "Отцы и дети", Author = "Тургенев И.С." });
            Database.db.Book.Add(new Book { Name = "Двойник", Author = "Достоевский Ф.М" });
            Database.db.Client.Add(new Client {FirstName="Динис", MiddleName="Жмышенко",LastName="Петров"});
            Database.db.Client.Add(new Client {FirstName="Павел", MiddleName="Георгевич",LastName="Ломник"});
            Database.db.Client.Add(new Client {FirstName="Константин", MiddleName="Николаевич",LastName="Рамзанов"});
            Database.db.Client.Add(new Client {FirstName="Владимир", MiddleName="Иванович",LastName="Кузьмин"});
            Database.db.Client.Add(new Client {FirstName="Анатолий", MiddleName="Валерьевич",LastName="Куликов"});
            MessageBox.Show("Данные добавлены!");
        }

        private void DeleteLink_Click(object sender, RoutedEventArgs e)
        {
            foreach (var o in Database.db.Book) Database.db.Book.Remove(o);
            foreach (var o in Database.db.Client) Database.db.Client.Remove(o);
            foreach (var o in Database.db.BookTakings) Database.db.BookTakings.Remove(o);
        }
    }
}
