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
    
    public partial class Жилец
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Жилец()
        {
            this.Заявки = new HashSet<Заявки>();
        }
    
        public int ID_жильца { get; set; }
        public int ID_пользователя { get; set; }
        public string Адрес { get; set; }
        public int Подъезд { get; set; }
        public int Этаж { get; set; }
        public int Квартира { get; set; }
    
        public virtual Пользователь Пользователь { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Заявки> Заявки { get; set; }
    }
}
