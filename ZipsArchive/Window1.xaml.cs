using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ZipsArchive
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public string path = null;
        public string pathArchive = null;
        public Window1()
        {
            InitializeComponent();
            Archivers.Visibility = Visibility.Hidden;
        }



        private void Browse_Click(object sender, RoutedEventArgs e)
        {
           using(FolderBrowserDialog Folder = new FolderBrowserDialog())
            {
                Folder.ShowDialog();
                path = Folder.SelectedPath;
            }
           textBlock.Text = path;
           Archivers.Visibility = Visibility.Visible;
        }
        private void Archivers_Click(object sender, RoutedEventArgs e)
        {
            using(FolderBrowserDialog FolderZip = new FolderBrowserDialog())
            {
                FolderZip.ShowDialog();
                pathArchive= FolderZip.SelectedPath;
                ZipFile.CreateFromDirectory(path,pathArchive+".zip");
            }
            BackEnd.Background = new SolidColorBrush(Colors.LightGreen);
            textBlock.Text = "Успешно";
        }

       
    }
}
