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
    /// Interaction logic for ListPage.xaml
    /// </summary>
    public partial class ListPage : Page
    {

        int incerement = 0;
        static int INDEX;

        List<string> list = new List<string> { };
        List<string> listName = new List<string> { };

        DispatcherTimer dispatcherTimer = new DispatcherTimer();


        public ListPage()
        {

            InitializeComponent();
            Restart();
            INDEX = 0;
            SelectionImage.Visibility = Visibility.Hidden;
            StackPanelVisible.Visibility = Visibility.Hidden;
        }


        public void Restart()
        {

            string Path = @"C:\Users\LITHIUM\Desktop\Homework\WpfApp1\WpfApp1\OpenFolderImage.txt";
            FileStream fileStream5 = new FileStream(Path, FileMode.OpenOrCreate, FileAccess.Read);
            using (StreamReader reader = new StreamReader(fileStream5))
            {
                while (true)
                {
                    string satir = reader.ReadLine();
                    list.Add(satir);
                    if (satir == null) break;
                }
                reader.Close();
            }
            fileStream5.Close();



            for (int i = 0; i < list.Count - 1; i++)
            {
                ImageUserControl imageUserControl = new ImageUserControl { };
                imageUserControl.SelectionImage.Source = new BitmapImage(new Uri(list[i]));
                listPageAdd.Items.Add(imageUserControl);
            }
        }

        private void listPageAdd_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

            int index = listPageAdd.SelectedIndex;
            INDEX = listPageAdd.SelectedIndex;
            SelectionImage.Source = new BitmapImage(new Uri(list[index]));
            listPageAdd.Visibility = Visibility.Hidden;
            SelectionImage.Visibility = Visibility.Visible;
            StackPanelVisible.Visibility = Visibility.Visible;
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (INDEX >= 1)
            {
                SelectionImage.Source = new BitmapImage(new Uri(list[INDEX--]));
            }


        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            if (INDEX < list.Count)
            {
                SelectionImage.Source = new BitmapImage(new Uri(list[INDEX++]));
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            dispatcherTimer.Interval = TimeSpan.FromSeconds(1);
            dispatcherTimer.Tick += DispatcherTimer_Tick;
            dispatcherTimer.Start();
        }

        private void DispatcherTimer_Tick(object sender, EventArgs e)
        {
            incerement++;

            if (incerement < list.Count)
            {
                SelectionImage.Source = new BitmapImage(new Uri(list[INDEX++]));
            }
            else
            {
                incerement = 0;
                INDEX = 0;
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            dispatcherTimer.Stop();
        }
    }
}
