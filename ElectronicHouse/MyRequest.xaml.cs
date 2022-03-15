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
    /// Логика взаимодействия для MyRequest.xaml
    /// </summary>
    public partial class MyRequest : Page
    {
        

        public MyRequest()
        {
            InitializeComponent();
            DG_MyRequest.ItemsSource = el_houseEntities.GetContext().Заявки.ToList();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new MainPage());
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            el_houseEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
            DG_MyRequest.ItemsSource= el_houseEntities.GetContext().Заявки.ToList();
        }

        private void DG_MyRequest_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        
        
    }
}

