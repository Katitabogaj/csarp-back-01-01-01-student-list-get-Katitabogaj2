using Kreata.Backend.Datas.Entities;
using Microsoft.EntityFrameworkCore;

namespace Kreata.Backend.Context
{
    public class KretaContext : DbContext
    {
        private DbSet<Student> _students;
        private DbSet<Teacher> _teachers;
        private DbSet<Parent> _parents;
        private DbSet<Pizzeriak> _pizzeriak;
        private DbSet<Pasta> _pastas;

        public KretaContext(DbContextOptions<KretaContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<Pizzeriak> Pizzeriaks { get; set; }
        public DbSet<Pasta> Pastas { get; set; }
    }
}
