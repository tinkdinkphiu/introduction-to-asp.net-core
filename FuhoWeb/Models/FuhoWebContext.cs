using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace FuhoWeb.Models;

public partial class FuhoWebContext : DbContext
{
    public FuhoWebContext()
    {
    }

    public FuhoWebContext(DbContextOptions<FuhoWebContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Project> Projects { get; set; }

    public virtual DbSet<Service> Services { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=LAPTOP-AGE43NEK; Database=FuhoWeb;Integrated Security=true;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Client>(entity =>
        {
            entity.Property(e => e.ClientId)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("ClientID");
            entity.Property(e => e.ClientName).HasMaxLength(50);
            entity.Property(e => e.Comment).HasMaxLength(1000);
            entity.Property(e => e.Image).HasMaxLength(50);
            entity.Property(e => e.Job).HasMaxLength(50);
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.Property(e => e.EmployeeId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EmployeeID");
            entity.Property(e => e.EmployeeName).HasMaxLength(50);
            entity.Property(e => e.Image).HasMaxLength(50);
            entity.Property(e => e.Position).HasMaxLength(50);
        });

        modelBuilder.Entity<Project>(entity =>
        {
            entity.Property(e => e.ProjectId)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("ProjectID");
            entity.Property(e => e.Address).HasMaxLength(50);
            entity.Property(e => e.Image).HasMaxLength(50);
            entity.Property(e => e.ProjectName).HasMaxLength(50);
        });

        modelBuilder.Entity<Service>(entity =>
        {
            entity.Property(e => e.ServiceId)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("ServiceID");
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.Image).HasMaxLength(50);
            entity.Property(e => e.ServiceName).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
