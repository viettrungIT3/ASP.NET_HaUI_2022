using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace NguyenVietTrung_3066_De3.Models
{
    public partial class NguyenVietTrung : DbContext
    {
        public NguyenVietTrung()
            : base("name=NguyenVietTrung")
        {
        }

        public virtual DbSet<Hang> Hangs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hang>()
                .Property(e => e.Mahang)
                .IsFixedLength();
        }
    }
}
