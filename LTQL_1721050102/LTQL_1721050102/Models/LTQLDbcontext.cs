using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace LTQL_1721050102.Models
{
    public partial class LTQLDbcontext : DbContext
    {
        public LTQLDbcontext()
            : base("name=LTQLDbcontext")
        {
        }
        public virtual DbSet<LopHoc102>LopHoc102s { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
