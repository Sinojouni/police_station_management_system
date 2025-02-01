using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using WinFormsApp1.Repositories.Models;

namespace WinFormsApp1.Repositories;

public partial class InvEntities : DbContext
{
    public InvEntities()
    {
    }

    public InvEntities(DbContextOptions<InvEntities> options)
        : base(options)
    {
    }

    public virtual DbSet<ImageAndFp> ImageAndFps { get; set; }

    public virtual DbSet<ImageFace> ImageFaces { get; set; }

    public virtual DbSet<ImageFp> ImageFps { get; set; }

    public virtual DbSet<Invest> Invests { get; set; }

    public virtual DbSet<Invperson> Invpersons { get; set; }

    public virtual DbSet<Nation> Nations { get; set; }

    public virtual DbSet<Vehicle> Vehicles { get; set; }

    public virtual DbSet<Village> Villages { get; set; }

    public virtual DbSet<Worldkey> Worldkeys { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(localdb)\\ProjectModels;Initial Catalog=projectdb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ImageAndFp>(entity =>
        {
            entity.HasKey(e => new { e.Serial, e.Serpers }).HasName("PK__ImageAnd__C87A60D5C4BE05D5");
        });

        modelBuilder.Entity<ImageFace>(entity =>
        {
            entity.HasKey(e => new { e.Serial, e.Serpers }).HasName("PK__ImageFac__52B352DE3D04902C");
        });

        modelBuilder.Entity<ImageFp>(entity =>
        {
            entity.HasKey(e => new { e.Serial, e.Serpers }).HasName("PK__ImageFP__52B352DE842C54E2");
        });

        modelBuilder.Entity<Invest>(entity =>
        {
            entity.HasKey(e => e.Serial).HasName("PK__INVEST__1CE6D4E6353FDDFC");
        });

        modelBuilder.Entity<Invperson>(entity =>
        {
            entity.HasKey(e => e.Serpers ).HasName("PK__invperso__52B352DEC229374F");
        });

        modelBuilder.Entity<Nation>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PK__nations__AA1D437898E5A570");

            entity.Property(e => e.Code).ValueGeneratedNever();
        });

        modelBuilder.Entity<Vehicle>(entity =>
        {
            entity.HasKey(e => e.Vid).HasName("PK__vehicles__DDB00C7DCC21BDC6");
        });

        modelBuilder.Entity<Village>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PK__Village__AA1D43782D41583B");

            entity.Property(e => e.Code).ValueGeneratedNever();
            entity.Property(e => e.Label).IsFixedLength();
        });

        modelBuilder.Entity<Worldkey>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PK__worldkey__AA1D4378B6B2B618");

            entity.Property(e => e.Code).ValueGeneratedNever();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
