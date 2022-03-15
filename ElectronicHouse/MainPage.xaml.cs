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
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void Personal_Account_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Account());

        }

        private void Request_Click(object sender, RoutedEventArgs e)
        {
            Request request_;

            request_ = new Request(null, 2);
            Manager.MainFrame.Navigate(request_);
        }

        private void Poll_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Polling());
    
        }

        private void Ads_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new News());
        }

    }
}
