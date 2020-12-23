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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfTask.UI
{
    /// <summary>
    /// Логика взаимодействия для TopBorder.xaml
    /// </summary>
    public partial class TopBorder : UserControl
    {
        private string borderText;
        public TopBorder()
        {
            InitializeComponent();
        }

        public event RoutedEventHandler BackButtonClick
        {
            add { BackBtn.Click += value; }
            remove { BackBtn.Click -= value; }
        }

        public string HeaderText
        {
            get { return borderText; }
            set { borderText = value; HeaderLb.Content = borderText; }
        }
    }
}
