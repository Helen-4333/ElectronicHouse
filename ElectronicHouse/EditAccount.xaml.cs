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
    /// Логика взаимодействия для EditAccount.xaml
    /// </summary>
    public partial class EditAccount : Page
    {

       
        public Пользователь currentUser = new Пользователь();
    //    public Жилец currentTenant = new Жилец();

        // var currentUser = ElectronicHouseEntities.GetContext().Пользователь.ToList();
        // var currentTenant = ElectronicHouseEntities.GetContext().Жилец.ToList();
        public EditAccount(Пользователь selectedПользователь)
        {
            InitializeComponent();
            

            if (selectedПользователь != null)
                currentUser = selectedПользователь;

           
            
            DataContext= currentUser;
            //   DataContext = currentTenant;


            TB_House.IsEnabled = true;     

            UpdateAccount();

        }

        private void UpdateAccount()
        {
            var currentUser = el_houseEntities.GetContext().Пользователь.ToList();
        //    var currentTenant = ElectronicHouseEntities.GetContext().Жилец.ToList();

            currentUser = currentUser.Where(p => p.Имя.ToLower().Contains(TB_Name.Text.ToLower())).ToList();
            currentUser = currentUser.Where(p => p.Фамилия.ToLower().Contains(TB_Surname.Text.ToLower())).ToList();
            currentUser = currentUser.Where(p => p.Адрес.ToLower().Contains(TB_Address.Text.ToLower())).ToList();
         //   currentUser = currentUser.Where(p => p.Номер_дома..Contains(TB_House.Text.ToLower())).ToList();
          //  currentUser = currentUser.Where(p => p.Номер_квартиры.ToLower().Contains(TB_entrance_number.Text.ToLower())).ToList();
         //   currentUser = currentUser.Where(p => p.Номер_подъезда.ToLower().Contains(TB_Flat_number.Text.ToLower())).ToList();

            
            //   currentTenant = currentTenant.Where(p => p.Адрес.ToLower().Contains(TB_Address.Text.ToLower())).ToList();




        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
           

            StringBuilder errors = new StringBuilder();

            currentUser.Имя=TB_Name.Text;
            currentUser.Фамилия=TB_Surname.Text;
            currentUser.Адрес=TB_Address.Text;
            //currentTenant.Адрес=TB_Address.Text;

            if (string.IsNullOrWhiteSpace(currentUser.Имя))
                errors.AppendLine("Укажите Имя");

            if (string.IsNullOrWhiteSpace(currentUser.Фамилия))
                errors.AppendLine("Укажите Фамилию");

       //    if (string.IsNullOrWhiteSpace(currentTenant.Адрес))
         //      errors.AppendLine("Введите Адрес");

        //    if (currentTenant.Подъезд < 1 || currentTenant.Подъезд > 5)
         //       errors.AppendLine("Введите число от 1 до 5");

          //  if (currentTenant.Квартира < 1 || currentTenant.Квартира > 59)
           //     errors.AppendLine("Введите число от 1 до 59"); 

            if(errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
         
            if (currentUser.ID_пользователя == 0)
                el_houseEntities.GetContext().Пользователь.Add(currentUser);

       /*    if(currentTenant.ID_жильца == 0)
                ElectronicHouseEntities.GetContext().Жилец.Add(currentTenant);
         */ 
            
            try
            {
                el_houseEntities.GetContext().SaveChanges();

                Manager.MainFrame.Navigate(new Account());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

      //  private void UpdateAccount()
        //{
          //  var currentUser = ElectronicHouseEntities.GetContext().Пользователь.ToList();
          //  var currentTenant = ElectronicHouseEntities.GetContext().Жилец.ToList();

          //  currentUser = currentUser.Where(p => p.Имя.ToLower().Contains(TB_Name.Text.ToLower())).ToList();
            //currentUser = currentUser.Where(p => p.Фамилия.ToLower().Contains(TB_Surname.Text.ToLower())).ToList();

           
     //   }

    

   //     private void TB_Address_TextChanged(object sender, TextChangedEventArgs e)
     //   {
      //      UpdateAccount();
      //  }

     //   private void TB_House_number_TextChanged(object sender, TextChangedEventArgs e)
     //   {
     //       UpdateAccount();
     //   }

      //  private void TB_Flat_number_TextChanged(object sender, TextChangedEventArgs e)
      //  {
        //    UpdateAccount();
        //}
    }
}
