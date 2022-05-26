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
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            MainWindow main_window = new MainWindow();
        }

        private void MenuTopping_Click(object sender, RoutedEventArgs e)
        {
            Window2 window2 = new Window2();
            window2.Show();
            Close();
            
        }

        private void Voi_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main_window = new MainWindow();
            StreamReader students = new StreamReader("info.txt");
            int i = 0;
            string login = Log.Text;
            string password = Pas.Text;
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
                    MessageBox.Show("Наши поздравления, вы вошли!!!");
                    Base.Name = Log.Text;
                    Base.Sh1 = count;
                    i = 1;
                }
            }
            if (i == 1)
            {

            }
            else
            {
                MessageBox.Show("Ошибка!!! Такого пользователя не существует");
            }
            students.Close();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
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
