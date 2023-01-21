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
    /// Логика взаимодействия для RazArchivexaml.xaml
    /// </summary>
    public partial class RazArchivexaml : Window
    {
       public MainWindow mainWindow = new MainWindow();
        public string path = null;
        public string pathRazArchive = null;
        public RazArchivexaml()
        {
            InitializeComponent();
            Archivers.Visibility= Visibility.Hidden;
        }

      

        private void RazArchivers_Click(object sender, RoutedEventArgs e)
        {
            using (FolderBrowserDialog folderdialog = new FolderBrowserDialog())
            {

                folderdialog.ShowDialog();
                pathRazArchive = folderdialog.SelectedPath; //#FF8BF16C
            }
            ZipFile.ExtractToDirectory(path, pathRazArchive+ "\\",Encoding.UTF8);
            BackEnd.Background = new SolidColorBrush(Colors.LightGreen);
            textBlock.Text = "Успешно";
        }

        private void Browse_Click(object sender, RoutedEventArgs e)
        {
            using (OpenFileDialog zipFile = new OpenFileDialog())
            {
                zipFile.Filter = "Zip архив (*.zip)|*.zip|Все файлы (*.*)|*.*\"\"";
                zipFile.ShowDialog();
                path = zipFile.FileName;

            }
            textBlock.Text= path;
            Archivers.Visibility = Visibility.Visible;

        }
    }
}
