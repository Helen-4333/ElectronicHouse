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
    /// Логика взаимодействия для Auth.xaml
    /// </summary>
    public partial class Auth : Page
    {
        public Auth()
        {
            InitializeComponent();
        }

        private void Auth_Enter_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(Login.Text))
            {
                if (!String.IsNullOrWhiteSpace(Password.Password))
                {
                    Пользователь user = el_houseEntities.GetContext().Пользователь.FirstOrDefault(p => p.Логин == Login.Text);

                    if (user != null)
                    {
                        if (user.Пароль == Password.Password)
                        {
                            MessageBox.Show("Успешная авторизация");
                            UserInfo.Id = user.ID_пользователя;
                            Manager.MainFrame.Navigate(new MainPage());
                        }
                        else
                        {
                            MessageBox.Show("Неверный пароль");
                            Password.Password = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Неверный логин");
                        Password.Password = "";
                    }
                }
                else
                {
                    MessageBox.Show("Укажите данные для входа");
                }
            }
            else
            {
                MessageBox.Show("Укажите данные для входа");
            }
        }
    }
}
