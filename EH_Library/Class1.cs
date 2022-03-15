using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EH_Library
{
    public class Class1
    {
        ElectronicHouse.el_houseEntities EH = new ElectronicHouse.el_houseEntities();
    

        ElectronicHouse.Пользователь user = new ElectronicHouse.Пользователь();
        ElectronicHouse.Заявки _request = new ElectronicHouse.Заявки();

        public string Authorization(string login, string password)
        {
            user.Логин = login;
            user.Пароль = password;
            return login;
        }

        public string editAccount(string name, string surname, string address)
        {
            var accountforedit = EH.Пользователь.Where(r => r.Имя == name).FirstOrDefault();

            user.Имя = name;
            user.Фамилия = surname;
            user.Адрес = address;
            EH.SaveChanges();
            return accountforedit.Имя;
        }

        public string Create_Request(string Address, string Object, string Thema, string Description)
        {
            _request.Адрес = Address;
            _request.Объект = Object;
            _request.Тематика=Thema;
            _request.Описание = Description;
            EH.Заявки.Add(_request);
            EH.SaveChanges();
            return Address;
        }




    }

    
}
