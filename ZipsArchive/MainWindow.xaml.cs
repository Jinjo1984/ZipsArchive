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
using System.Windows.Forms;
using System.IO.Compression;
using System.IO;
using OpenFileDialog = System.Windows.Forms.OpenFileDialog;

namespace ZipsArchive
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        

        public MainWindow()
        {
            InitializeComponent();
            //textBlock.Text = null;
            //Archivers.Visibility = Visibility.Collapsed;
        }

        
        private void RazArchivers_Click(object sender, RoutedEventArgs e)
        {
            RazArchivexaml razArchive = new RazArchivexaml();
            razArchive.Show();
           
           
            //FolderBrowserDialog folderdialog = new FolderBrowserDialog();
            //folderdialog.ShowDialog();
            //string path = folderdialog.SelectedPath;
            //textBlock.Text = $"Путь папки для архивации {path}";
            //ZipFile.CreateFromDirectory(path,path+".zip");

        }

        private void Archivers_Click(object sender, RoutedEventArgs e)
        {
            Window1 Archivers = new Window1();
            Archivers.Show();
            
            
            //OpenFileDialog zipFile = new OpenFileDialog();
            //zipFile.ShowDialog();
            //string path = zipFile.FileName;
            //ZipFile.ExtractToDirectory(path, "C:\\Тесты", Encoding.GetEncoding(866));
            //textBlock.Text = $"Путь папки для разархивации {path}";

        }
    }
}
