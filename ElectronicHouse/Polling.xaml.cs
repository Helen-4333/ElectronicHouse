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

namespace ElectronicHouse
{
    /// <summary>
    /// Логика взаимодействия для Polling.xaml
    /// </summary>
    public partial class Polling : Page
    {
        
        public Polling()
        {
            InitializeComponent();
            ComboThematics.ItemsSource = el_houseEntities.GetContext().Опросы.ToList();

            
        }

        private void Yes_Click(object sender, RoutedEventArgs e)
        {
            string message = "Ваш голос учтен";
            MessageBox.Show(message);

            Manager.MainFrame.Navigate(new MainPage());
        }

        private void No_Click(object sender, RoutedEventArgs e)
        {
            string message = "Ваш голос учтен";
            MessageBox.Show(message);

            Manager.MainFrame.Navigate(new MainPage());
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new MainPage());
        }

        private void ComboThematics_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
