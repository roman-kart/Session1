using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace GovernmentionAutoInspection.Model
{
    public partial class DriversModel : DbContext
    {
        public DriversModel()
            : base("name=DriversModel")
        {
        }

        public virtual DbSet<Drivers> Drivers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
