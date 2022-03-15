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
    /// Логика взаимодействия для Request.xaml
    /// </summary>
    public partial class Request : Page
    {



        public int UserId;
        


        private Заявки curRequest = new Заявки();
       
        //Жилец curUser=new Жилец();

    
        public Request(Заявки selectedRequest, int User_Id)
        {
            InitializeComponent();
            UserId = User_Id;

            if (selectedRequest != null)
                curRequest = selectedRequest;

            DataContext = curRequest;


            UpdateRequest();
            
        }

        private void UpdateRequest()
        {
            var curRequest = el_houseEntities.GetContext().Заявки.ToList();
            //    var currentTenant = ElectronicHouseEntities.GetContext().Жилец.ToList();

            curRequest = curRequest.Where(p => p.Адрес.ToLower().Contains(TB_Address.Text.ToLower())).ToList();
            curRequest = curRequest.Where(p => p.Объект.ToLower().Contains(TB_Object.Text.ToLower())).ToList();
            curRequest = curRequest.Where(p => p.Тематика.ToLower().Contains(TB_Thematics.Text.ToLower())).ToList();
            curRequest = curRequest.Where(p => p.Описание.ToLower().Contains(TB_Description.Text.ToLower())).ToList();

            //  currentTenant = currentTenant.Where(p => p.Адрес.ToLower().Contains(TB_Address.Text.ToLower())).ToList();




        }

        private void Create_Click(object sender, RoutedEventArgs e) // создание заявки
        {
           
            StringBuilder errors = new StringBuilder();


            curRequest.ID_жильца = UserId;
            curRequest.Адрес = TB_Address.Text;
            curRequest.Объект=TB_Object.Text;
            curRequest.Тематика=TB_Thematics.Text;
            curRequest.Описание=TB_Description.Text;


            if (string.IsNullOrWhiteSpace(curRequest.Адрес))
                errors.AppendLine("Укажите Адрес");

            if (string.IsNullOrWhiteSpace(curRequest.Объект))
                errors.AppendLine("Укажите Объект");


            if (string.IsNullOrWhiteSpace(curRequest.Тематика))
                errors.AppendLine("Укажите Тематику");

            if (string.IsNullOrWhiteSpace(curRequest.Описание))
                errors.AppendLine("Укажите Описание");


            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

   
            if (curRequest.ID_заявки == 0)
                el_houseEntities.GetContext().Заявки.Add(curRequest);


            try
            {
                el_houseEntities.GetContext().SaveChanges();

                MessageBox.Show("Заявка создана");
                Manager.MainFrame.GoBack();

                
               // Manager.MainFrame.Navigate(new Request((sender as Button).DataContext as Заявки));
            }
           catch (Exception ex)
            {
               MessageBox.Show(ex.Message.ToString());
               
            }

     /*       if(isError)
            {
                MessageBox.Show("Заявка не создана");
            }
            else
            {
                MessageBox.Show("Заявка оформлена");
                Manager.MainFrame.Navigate(new MainPage());
            }
     */
        }

        private void Look_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new MyRequest());
        }

       
    }
}
