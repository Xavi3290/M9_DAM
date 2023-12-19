using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ExamenProducorXavierRoca.Models;

public partial class CiclismeContext : DbContext
{
    public CiclismeContext()
    {
    }

    public CiclismeContext(DbContextOptions<CiclismeContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Ciclistum> Ciclista { get; set; }

    public virtual DbSet<Equipo> Equipos { get; set; }

    public virtual DbSet<Etapa> Etapas { get; set; }

    public virtual DbSet<Llevar> Llevars { get; set; }

    public virtual DbSet<Maillot> Maillots { get; set; }

    public virtual DbSet<Puerto> Puertos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.; Trusted_Connection=True; Encrypt=false; Database=ciclisme");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Ciclistum>(entity =>
        {
            entity.HasKey(e => e.Dorsal).HasName("PK__ciclista__EF86010607E94B19");

            entity.ToTable("ciclista");

            entity.Property(e => e.Dorsal)
                .ValueGeneratedNever()
                .HasColumnName("dorsal");
            entity.Property(e => e.Edad).HasColumnName("edad");
            entity.Property(e => e.Nombre)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Nomeq)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("nomeq");

            entity.HasOne(d => d.NomeqNavigation).WithMany(p => p.Ciclista)
                .HasForeignKey(d => d.Nomeq)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ciclista_ibfk_1");
        });

        modelBuilder.Entity<Equipo>(entity =>
        {
            entity.HasKey(e => e.Nomeq).HasName("PK__equipo__F76AACF529AF8011");

            entity.ToTable("equipo");

            entity.Property(e => e.Nomeq)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("nomeq");
            entity.Property(e => e.Director)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("director");
        });

        modelBuilder.Entity<Etapa>(entity =>
        {
            entity.HasKey(e => e.Netapa).HasName("PK__etapa__EC1F67A51B2F2718");

            entity.ToTable("etapa");

            entity.Property(e => e.Netapa)
                .ValueGeneratedNever()
                .HasColumnName("netapa");
            entity.Property(e => e.Dorsal).HasColumnName("dorsal");
            entity.Property(e => e.Km).HasColumnName("km");
            entity.Property(e => e.Llegada)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("llegada");
            entity.Property(e => e.Salida)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("salida");

            entity.HasOne(d => d.DorsalNavigation).WithMany(p => p.Etapas)
                .HasForeignKey(d => d.Dorsal)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("etapa_ibfk_1");
        });

        modelBuilder.Entity<Llevar>(entity =>
        {
            entity.HasKey(e => new { e.Netapa, e.Codigo }).HasName("PK__llevar__8810FD853240A40B");

            entity.ToTable("llevar");

            entity.Property(e => e.Netapa).HasColumnName("netapa");
            entity.Property(e => e.Codigo)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("codigo");
            entity.Property(e => e.Dorsal).HasColumnName("dorsal");

            entity.HasOne(d => d.CodigoNavigation).WithMany(p => p.Llevars)
                .HasForeignKey(d => d.Codigo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("llevar_ibfk_3");

            entity.HasOne(d => d.DorsalNavigation).WithMany(p => p.Llevars)
                .HasForeignKey(d => d.Dorsal)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("llevar_ibfk_1");

            entity.HasOne(d => d.NetapaNavigation).WithMany(p => p.Llevars)
                .HasForeignKey(d => d.Netapa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("llevar_ibfk_2");
        });

        modelBuilder.Entity<Maillot>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("PK__maillot__40F9A20709986C5E");

            entity.ToTable("maillot");

            entity.Property(e => e.Codigo)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("codigo");
            entity.Property(e => e.Color)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("color");
            entity.Property(e => e.Premio).HasColumnName("premio");
            entity.Property(e => e.Tipo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("tipo");
        });

        modelBuilder.Entity<Puerto>(entity =>
        {
            entity.HasKey(e => e.Nompuerto);

            entity.ToTable("puerto");

            entity.Property(e => e.Nompuerto)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("nompuerto");
            entity.Property(e => e.Altura).HasColumnName("altura");
            entity.Property(e => e.Categoria)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("categoria");
            entity.Property(e => e.Dorsal).HasColumnName("dorsal");
            entity.Property(e => e.Netapa).HasColumnName("netapa");
            entity.Property(e => e.Pendiente).HasColumnName("pendiente");

            entity.HasOne(d => d.DorsalNavigation).WithMany(p => p.Puertos)
                .HasForeignKey(d => d.Dorsal)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("puerto_ibfk_1");

            entity.HasOne(d => d.NetapaNavigation).WithMany(p => p.Puertos)
                .HasForeignKey(d => d.Netapa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("puerto_ibfk_2");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
