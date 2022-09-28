using System.Collections.Generic;
using System.Data.Entity;
using WebShop.Entity;

namespace WebShop.Context
{
    public class ConnectionContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Expence> Expences { get; set; }
        public DbSet<MyItemEntity> MyItemEntity { get; set; }
        public ConnectionContext() : base("Server = (localdb)\\mssqllocaldb; Database=Shop.dbo;Trusted_Connection=True;")
        {
            Users = this.Set<User>();
            Expences = this.Set<Expence>();
            MyItemEntity = this.Set<MyItemEntity>();
        }
    }
}
