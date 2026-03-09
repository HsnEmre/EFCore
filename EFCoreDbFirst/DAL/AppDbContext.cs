using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDbFirst.DAL
{
    public class AppDbContext:DbContext//miras
    {

        public DbSet<Product> Products { get; set; }

        public AppDbContext()
        {
            
        }

        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)  //db ile ilgili tum ayarlar
        {
            
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(DbContextInitializer.Configuration.GetConnectionString("SqlCon"));
            base.OnConfiguring(optionsBuilder);
        }


        //i was make refactoring
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Data Source=DESKTOP-41V1OLM\\SQLEXPRESS;Initial Catalog=EFCoreDatabaseFirstDb;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");//connectionstring

        //}

    }
}
