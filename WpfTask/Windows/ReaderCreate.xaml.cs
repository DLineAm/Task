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
using WpfTask.Windows;
using WpfTask.Windows.Tables;

namespace WpfTask.Windows
{
    /// <summary>
    /// Логика взаимодействия для ReaderCreate.xaml
    /// </summary>
    public partial class ReaderCreate : Window
    {
        private ReaderManager readerManager;

        public ReaderCreate()
        {
            InitializeComponent();
        }

        public ReaderCreate(Client client)
        {
            InitializeComponent();
            FirstNameTB.Text = client.Name;
            TitleLb.Content = "Изменение данных";
            AddBtn.Content = "Изменить";
        }

        public ReaderCreate(ReaderManager readerManager)
        {
            InitializeComponent();
            this.readerManager = readerManager;
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(FirstNameTB.Text))
                this.DialogResult = true;
            else
                MessageBox.Show("Поля должны быть заполнены!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
