//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EH_Library
{
    using System;
    using System.Collections.Generic;
    
    public partial class Опросы
    {
        public int ID_опроса { get; set; }
        public int ID_организации { get; set; }
        public string Тема { get; set; }
        public string Описание { get; set; }
    
        public virtual Управляющая_организация Управляющая_организация { get; set; }
    }
}
