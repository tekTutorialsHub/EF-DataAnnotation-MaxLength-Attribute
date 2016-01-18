using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EF_MaxLength_Attribute
{
    public class EFContext : DbContext
    {
        public EFContext()
            : base("EFDatabase")
        {
            Database.SetInitializer<EFContext>(new DropCreateDatabaseIfModelChanges<EFContext>());
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Customer> Customers { get; set; }

    }


}
