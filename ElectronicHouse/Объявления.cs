//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ElectronicHouse
{
    using System;
    using System.Collections.Generic;
    
    public partial class Объявления
    {
        public int ID_объявления { get; set; }
        public int ID_организации { get; set; }
        public string Название { get; set; }
        public string Описание { get; set; }
        public System.DateTime Дата { get; set; }
    
        public virtual Управляющая_организация Управляющая_организация { get; set; }
    }
}
