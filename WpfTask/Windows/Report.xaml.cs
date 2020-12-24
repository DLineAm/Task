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
    /// Логика взаимодействия для Report.xaml
    /// </summary>
    public partial class ReportWindow : Window
    {
        private MainMenu mainMenu;    

        public ReportWindow(MainMenu mainMenu)
        {
            InitializeComponent();
            this.mainMenu = mainMenu;
            var report = new List<Report>();
            foreach (var o in Database.db.Book)
            {
                using (ClientContext database = new ClientContext())
                {
                    var bookT = database.BookTakings.Where(w => w.BookId == o.Id).ToList();                    
                    report.Add(new Report(o.Name, bookT.Count()));
                }
            }

            ReportDG.ItemsSource = report.Select(p => new
            {
                BookName = p.BookName,
                Count = p.Count
            }).ToList();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            mainMenu.Show();
        }
    }
}
