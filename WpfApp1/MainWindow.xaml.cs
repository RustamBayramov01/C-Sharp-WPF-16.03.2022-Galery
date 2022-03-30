using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        string delet = @"C:\Users\LITHIUM\Desktop\Homework\WpfApp1\WpfApp1\OpenFolderImage.txt";
        string imageName = @"C:\Users\LITHIUM\Desktop\Homework\WpfApp1\WpfApp1\ImageName.txt";
        string path = @"C:\Users\LITHIUM\Desktop\Homework\WpfApp1\WpfApp1\OpenFolderImage.txt";
        string selection = @"C:\Users\LITHIUM\Desktop\Homework\WpfApp1\WpfApp1\Select.txt";

        DispatcherTimer dispatcherTimer = new DispatcherTimer();
        List<string> list = new List<string> { };


        public MainWindow()
        {

            InitializeComponent();

            FileStackPanel.Width = 1;
            EditStackPanel.Width = 1;
            ViewStackPanel.Width = 1;

            File.Delete(delet);
            File.Delete(imageName);

        }


        private void Window_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            try { DragMove(); }
            catch (Exception) { throw; }
        }

        private void Button_MouseMove(object sender, System.Windows.Input.MouseEventArgs e) { EditButton.Margin = new Thickness(0, 190, 0, 0); ViewButton.Margin = new Thickness(0, 150, 0, 0); FileStackPanel.Visibility = Visibility.Visible;  EditStackPanel.Visibility = Visibility.Hidden; ViewStackPanel.Visibility = Visibility.Hidden; }
        private void EditButton_MouseMove(object sender, System.Windows.Input.MouseEventArgs e) { EditButton.Margin = new Thickness(0, 0, 0, 345); ViewButton.Margin = new Thickness(0, 90, 0, 0); FileStackPanel.Visibility = Visibility.Hidden; ViewStackPanel.Visibility = Visibility.Hidden; EditStackPanel.Visibility = Visibility.Visible; }

        private void ViewButton_MouseMove(object sender, System.Windows.Input.MouseEventArgs e) { ViewButton.Margin = new Thickness(0, 0, 0, 345);  FileStackPanel.Visibility = Visibility.Hidden; EditStackPanel.Visibility = Visibility.Hidden; ViewStackPanel.Visibility = Visibility.Visible; }

        private void Open_Click(object sender, RoutedEventArgs e)
        {

            var show = new FolderBrowserDialog();


            if (show.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string supportedExtensions = "*.jpg,*.png,*.jpeg";
                foreach (string imageFile in Directory.GetFiles(show.SelectedPath, "*.*", SearchOption.AllDirectories).Where(s => supportedExtensions.Contains(System.IO.Path.GetExtension(s).ToLower())))
                {
                    //Photos.Add(new Photo() { path = imageFile, title = imageFile.Split('\\').Last(), time = DateTime.Now });
                    File.AppendAllText(path, imageFile + Environment.NewLine);
                    File.AppendAllText(imageName, imageFile.Split('\\').Last() + Environment.NewLine);
                }


                Rest();



            }

            

        }


        public void Rest()
        {

            string selection;
            string Path = @"C:\Users\LITHIUM\Desktop\Homework\WpfApp1\WpfApp1\Select.txt";
            FileStream fileStream5 = new FileStream(Path, FileMode.OpenOrCreate, FileAccess.Read);
            using (StreamReader reader = new StreamReader(fileStream5))
            {
                string satir = reader.ReadLine();
                selection = satir;
                reader.Close();
            }
            fileStream5.Close();


            if (selection == "1")
            {
                ListPage listPage = new ListPage();
                MainFrame.Navigate(listPage);
            }
            else if (selection == "2")
            {
                SmilIconP smilIconP = new SmilIconP();
                MainFrame.Navigate(smilIconP);

            }
            else if (selection == "3")
            {
                DetailsPage detailsPage = new DetailsPage();
                MainFrame.Navigate(detailsPage);
            }
        }



        private void New_Click(object sender, RoutedEventArgs e)
        {
            File.Delete(delet);
            MainFrame.Content = null;

        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }


        private void AddFile_Click_1(object sender, RoutedEventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            open.Title = "Select a picture";
            open.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
              "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
              "Portable Network Graphic (*.png)|*.png";
            _ = open.ShowDialog();

            File.AppendAllText(path, open.FileName + Environment.NewLine);
            File.AppendAllText(imageName, open.FileName.Split('\\').Last() + Environment.NewLine);

            Rest();


        }

        private void SmailIcon_Click_1(object sender, RoutedEventArgs e)
        {
            File.WriteAllText(selection, "2" + Environment.NewLine);
            SmilIconP smilIconP = new SmilIconP();
            MainFrame.Navigate(smilIconP);
        }

        private void Tiles_Click(object sender, RoutedEventArgs e)
        {
            File.WriteAllText(selection, "1" + Environment.NewLine);
            ListPage listPagee = new ListPage();
            MainFrame.Navigate(listPagee);
        }

        private void Details_Click(object sender, RoutedEventArgs e)
        {
            File.WriteAllText(selection, "3" + Environment.NewLine);
            DetailsPage detailsPage = new DetailsPage();
            MainFrame.Navigate(detailsPage);
        }
    }
}
