using Microsoft.Win32;
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
using System.IO;

namespace findFile_txtProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //нужная функция
        public void findFile(TextBox textBox)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt";
            openFileDialog.Title = "Выберите файл";

            if(openFileDialog.ShowDialog() == true)
            {
                string filePath = openFileDialog.FileName;

                textBox.Clear();

                textBox.Text = File.ReadAllText(filePath);

                MessageBox.Show("Загрузка файла выполнена успешно");
            }
        }

        private void aBtnClick(object sender, RoutedEventArgs e)
        {
            findFile(textBoxName);
        }
    }
}
