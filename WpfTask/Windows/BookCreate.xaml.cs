﻿using System;
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
    /// Логика взаимодействия для BookCreate.xaml
    /// </summary>
    public partial class BookCreate : Window
    {
        public BookCreate()
        {
            InitializeComponent();
        }

        public BookCreate(Book book)
        {
            InitializeComponent();
            NameTB.Text = book.Name;
            AuthorTB.Text = book.Author;
            TitleLb.Content = "Изменение данных";
            AddBtn.Content = "Изменить";
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(NameTB.Text) && !string.IsNullOrWhiteSpace(AuthorTB.Text))
                this.DialogResult = true;
            else
                MessageBox.Show("Поля должны быть заполнены!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
