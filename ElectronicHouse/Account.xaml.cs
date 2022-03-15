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
    /// Логика взаимодействия для Account.xaml
    /// </summary>
    public partial class Account : Page
    {
        public Account()
        {
            InitializeComponent();
            DataContext = el_houseEntities.GetContext().Пользователь.Where(p => p.ID_пользователя == UserInfo.Id).First();

        }

        private void Back_Cick(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new MainPage());
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new EditAccount((sender as Button).DataContext as Пользователь));
            el_houseEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            
                el_houseEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                
                        
            
        }


    }
}
