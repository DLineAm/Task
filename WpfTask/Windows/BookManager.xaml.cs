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
    /// Логика взаимодействия для BookManager.xaml
    /// </summary>
    public partial class BookManager : Window
    {
        private MainMenu mainMenu;
        public BookManager(MainMenu window)
        {
            InitializeComponent();
            mainMenu = window;          
            LoadData();
        }

        private void LoadData()
        {
            var books = Database.db.Book.AsQueryable();
            {
                BookDG.ItemsSource = books.Select(s => new Book
                {
                    Id = s.Id,
                    Name = s.Name,
                    Author = s.Author
                });
            }


        }

        private void ChangeBtn_Click(object sender, RoutedEventArgs e)
        {
            Book selectedItem;
            try
            {
                selectedItem = (Book)BookDG.SelectedItem;
            }
            catch { return; }
            if (selectedItem == null)
                return;
            var selectedID = selectedItem.Id;
            using (ClientContext db = new ClientContext())
            {
                var selectedBook = db.Book.FirstOrDefault(p => p.Id == selectedID);
                var bookCreateWindow = new BookCreate(selectedBook);
                if (bookCreateWindow.ShowDialog() == true)
                {
                    selectedBook.Name = bookCreateWindow.NameTB.Text;
                    selectedBook.Author = bookCreateWindow.AuthorTB.Text;
                    db.SaveChanges();
                    BookDG.ItemsSource = db.Book.ToList();
                }
            }
        }

        private void CreateBtn_Click(object sender, RoutedEventArgs e)
        {
            var bookCreateWindow = new BookCreate();
            if (bookCreateWindow.ShowDialog() == true)
            {
                using (ClientContext db = new ClientContext())
                {
                    Book b = new Book { Id = 1, Name = bookCreateWindow.NameTB.Text, Author = bookCreateWindow.AuthorTB.Text };
                    db.Book.Add(b);
                    db.SaveChanges();
                    BookDG.ItemsSource = db.Book.ToList();
                    BookDG.ScrollIntoView(b);
                }
            }
        }

        private void OnBackButtonClick(object sender, RoutedEventArgs e)
        {
            this.Close();
            mainMenu.Show();
        }

        private void RemoveBtn_Click(object sender, RoutedEventArgs e)
        {
            Book selectedItem;
            try
            {
                selectedItem = (Book)BookDG.SelectedItem;
            }
            catch { return; }

            using (ClientContext db = new ClientContext())
            {
                var selectedBook = db.Book.FirstOrDefault(p => p.Id == selectedItem.Id);
                db.Book.Remove(selectedBook);
                db.SaveChanges();
                BookDG.ItemsSource = db.Book.ToList();
            }
        }
    }
}
