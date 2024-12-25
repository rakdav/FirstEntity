using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace FirstEntity;

public partial class FirstContext : DbContext
{
    public FirstContext()
    {
        //Database.EnsureDeleted();
        //Database.EnsureCreated();
    }
    public FirstContext(DbContextOptions<FirstContext> options)
        : base(options)
    {
    }
    public virtual DbSet<User> Users { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("Data Source=C:\\SqLite\\first.db");
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("User");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        OnModelCreatingPartial(modelBuilder);
    }
    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
