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
                var clients = db.Client.ToList();
                ReaderDG.ItemsSource = clients;
            }

        }

        private void CreateBtn_Click(object sender, RoutedEventArgs e)
        {
            var rcw = new ReaderCreate(this);
            bool? result = rcw.ShowDialog();
            if (result == true)
            {
                using (ClientContext db = new ClientContext())
                {
                    Client cl = new Client { Name = rcw.FirstNameTB.Text, Id = 1 };
                    db.Client.Add(cl);
                    db.SaveChanges();
                }
            }
        }

        private void ChangeBtn_Click(object sender, RoutedEventArgs e)
        {
            var selectedItem = (Client)ReaderDG.SelectedItem;
            if (selectedItem == null)
                return;
            var selectedId = selectedItem.Id;
            using (ClientContext db = new ClientContext())
            {
                var selectedReader = db.Client.FirstOrDefault(p => p.Id == selectedId);
                var rcw = new ReaderCreate();
                rcw.TitleLb.Content = "Изменение данных";
                rcw.AddBtn.Content = "Изменить";
                rcw.FirstNameTB.Text = selectedReader.Name;
                bool? result = rcw.ShowDialog();
                if (result == true)
                {
                    selectedReader.Name = rcw.FirstNameTB.Text;
                    db.SaveChanges();
                    var clients = db.Client.ToList();
                    ReaderDG.ItemsSource = clients;
                }

            }

        }
    }
}
