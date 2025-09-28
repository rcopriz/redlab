using Microsoft.EntityFrameworkCore;
using PruebaRedLab.Models;

namespace PruebaRedLab.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Producto> Productos { get; set; }
        public DbSet<Perfil> Perfil {  get; set; }

        /*
         *  No se Usa Solo esta como referencia por si lo llego a necesitar a futuro
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Producto>(static tb => {
               // tb.HasKey(col => col.Id); no voy a sobreescribir el campo Id
               // tb.Property(col => col.Id).UseIdentityColumn().ValueGeneratedOnAdd();
                tb.Property(col => col.Nombre).HasMaxLength(80);
                tb.ToTable("Producto");
                  
            });
        } 
        */
    }
}
