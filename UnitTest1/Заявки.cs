//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UnitTest1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Заявки
    {
        public int ID_заявки { get; set; }
        public int ID_жильца { get; set; }
        public string Адрес { get; set; }
        public string Объект { get; set; }
        public string Тематика { get; set; }
        public string Описание { get; set; }
    
        public virtual Жилец Жилец { get; set; }
    }
}
