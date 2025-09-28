using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PruebaRedLab.Models;

public partial class RedlabContext : DbContext
{
    public RedlabContext()
    {
    }

    public RedlabContext(DbContextOptions<RedlabContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=sql_db,1433;User Id=sa;Password=RicardoCopriz2025;TrustServerCertificate=True; Initial Catalog=redlab");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
