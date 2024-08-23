using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Microsoft.Extensions.Configuration;

namespace Infrastructure
{
    public class Data: DbContext
    {
        public DbSet<User> Users { get; set; }

        public Data(DbContextOptions<Data> options): base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.ID);
                entity.Property(e => e.ID).UseIdentityColumn();
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
