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
        public BookManager()
        {
            InitializeComponent();
            using (ClientContext db = new ClientContext())
            {
                //db.Book.Add(new Book { Id = 1, Name = "Test", Author = "Test" });
                //db.SaveChanges();
                var books = db.Book.ToList();
                BookDG.ItemsSource = books;
            }
        }

        private void ChangeBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CreateBtn_Click(object sender, RoutedEventArgs e)
        {
            var bcf = new BookCreate();
            bool? result = bcf.ShowDialog();
            if (result == true)
            {
                using (ClientContext db = new ClientContext())
                {
                    Book b = new Book { Id = 1, Name = bcf.NameTB.Text, Author = bcf.AuthorTB.Text };
                    db.Book.Add(b);
                    db.SaveChanges();
                }
            }
        }

        private void OnBackButtonClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Plivet","Zdravstvyute");
        }
    }
}
