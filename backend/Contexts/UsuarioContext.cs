/*
namespace PruebaRedLab.Contexts
{
    public class UsuarioContext
    {
    }
}
*/

using Microsoft.EntityFrameworkCore;
using PruebaRedLab.Models;
using System;
using System.Collections.Generic;

namespace PruebaRedLab.Contexts
{
    public partial class UsuarioContext : DbContext
    {
        public UsuarioContext()
        {
        }

        public UsuarioContext(DbContextOptions<UsuarioContext> options)
            : base(options)
        {
        }


        public virtual DbSet<Usuario> Usuario { get; set; }


        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    } 

}