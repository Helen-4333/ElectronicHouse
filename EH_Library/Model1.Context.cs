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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class el_houseEntities : DbContext
    {
        public el_houseEntities()
            : base("name=el_houseEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Жилец> Жилец { get; set; }
        public virtual DbSet<Заявки> Заявки { get; set; }
        public virtual DbSet<Объявления> Объявления { get; set; }
        public virtual DbSet<Опросы> Опросы { get; set; }
        public virtual DbSet<Пользователь> Пользователь { get; set; }
        public virtual DbSet<Управляющая_организация> Управляющая_организация { get; set; }
    }
}
