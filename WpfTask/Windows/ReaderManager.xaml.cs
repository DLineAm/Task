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
    /// Логика взаимодействия для ReaderManager.xaml
    /// </summary>
    public partial class ReaderManager : Window
    {
        private MainMenu mainMenu;

        public ReaderManager()
        {
            InitializeComponent();
        }

        public ReaderManager(MainMenu mainMenu)
        {
            InitializeComponent();
            this.mainMenu = mainMenu;
            using (ClientContext db = new ClientContext())
            {
                //var clients = db.Client.ToList();
                ReaderDG.ItemsSource = db.Client.ToList();
            }

        }

        private void CreateBtn_Click(object sender, RoutedEventArgs e)
        {
            var rcw = new ReaderCreate();
            if (rcw.ShowDialog() == true)
            {
                using (ClientContext db = new ClientContext())
                {
                    Client cl = new Client { Name = rcw.FirstNameTB.Text, Id = 1 };
                    db.Client.Add(cl);
                    db.SaveChanges();                    
                    ReaderDG.ItemsSource = db.Client.ToList();
                    ReaderDG.ScrollIntoView(cl);
                }
            }
        }

        private void ChangeBtn_Click(object sender, RoutedEventArgs e)
        {
            Client selectedItem;
            try
            {
                selectedItem = (Client)ReaderDG.SelectedItem;
            }
            catch { return; }
            
            if (selectedItem == null)
                return;
            var selectedId = selectedItem.Id;
            using (ClientContext db = new ClientContext())
            {
                var selectedReader = db.Client.FirstOrDefault(p => p.Id == selectedId);

                var readerCreateWindow = new ReaderCreate(selectedReader) { };              

                if (readerCreateWindow.ShowDialog() == true)
                {
                    selectedReader.Name = readerCreateWindow.FirstNameTB.Text;
                    db.SaveChanges();
                    ReaderDG.ItemsSource = db.Client.ToList();
                }

            }

        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            Client selectedItem;
            try
            {
                selectedItem = (Client)ReaderDG.SelectedItem;
            }
            catch { return; }

            if (selectedItem == null)
                return;
            using (ClientContext db = new ClientContext())
            {
                var selectedClient = db.Client.FirstOrDefault(p => p.Id == selectedItem.Id);
                db.Client.Remove(selectedClient);
                db.SaveChanges();
                ReaderDG.ItemsSource = db.Client.ToList();
            }
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            mainMenu.Show();
        }
    }
}
