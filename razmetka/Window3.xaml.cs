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
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        private static bool closing;
        public Window3()
        {
            InitializeComponent();
            closing = true;
            MainWindow main_window = new MainWindow();
        }

        private void Vih_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            closing = false;
            Close();

        }

        private void Oplata_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            string[] InfoData = new string[3];
            InfoData[0] = Base.Name;
            InfoData[1] = Base.Password;
            InfoData[2] = Convert.ToString(+1);
            Base.Registration(InfoData);
            StreamReader students = new StreamReader("info.txt");
            int i = 0;
            string login = Log.Text;
            string password = Pas.Password;
            string line = students.ReadLine();
            while (line != null)
            {
                string[] splitLine = line.Split(';');
                string search = splitLine[0];
                string search1 = splitLine[1];
                string count = splitLine[2];
                line = students.ReadLine();
                if (login.Contains(search) && password.Contains(search1))
                {
                    MessageBox.Show("Вы успешно вошли");
                    Base.Name = Log.Text;
                    Base.Password = Pas.Password;
                    Base.Sh1 = count;
                    i = 1;
                }
            }
            closing = false;
            Close();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (closing)
            {
                Application.Current.Shutdown();
            }
        }
    }
}
