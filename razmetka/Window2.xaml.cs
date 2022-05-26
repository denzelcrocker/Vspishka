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
using System.IO;

namespace razmetka
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void Voi_Click(object sender, RoutedEventArgs e)
        {
            string[] InfoData = new string[3];
            InfoData[0] = Log.Text;
            InfoData[1] = Pas.Text;
            InfoData[2] = Convert.ToString(0);
            Base.Registration(InfoData);
            Window1 window1 = new Window1();
            window1.Show();
            Close();
        }

        private void Vih_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }
    }
}
