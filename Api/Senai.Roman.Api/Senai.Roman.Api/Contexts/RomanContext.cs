using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Senai.Roman.Api.Domains
{
    public partial class RomanContext : DbContext
    {
        public RomanContext()
        {
        }

        public RomanContext(DbContextOptions<RomanContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Professor> Professor { get; set; }
        public virtual DbSet<Projeto> Projeto { get; set; }
        public virtual DbSet<TipoUsuario> TipoUsuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=.\\SqlExpress;Initial Catalog=T_Roman;User Id=sa;Pwd=132;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Professor>(entity =>
            {
                entity.HasKey(e => e.IdProfessor);

                entity.Property(e => e.NomeDoProfessor)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdTipoUsuarioNavigation)
                    .WithMany(p => p.Professor)
                    .HasForeignKey(d => d.IdTipoUsuario)
                    .HasConstraintName("FK__Professor__IdTip__4F7CD00D");
            });

            modelBuilder.Entity<Projeto>(entity =>
            {
                entity.HasKey(e => e.IdProjeto);

                entity.HasIndex(e => e.Tema)
                    .HasName("UQ__Projeto__8F79CA08C78055D1")
                    .IsUnique();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Tema)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.NomeDoProfessorNavigation)
                    .WithMany(p => p.Projeto)
                    .HasForeignKey(d => d.NomeDoProfessor)
                    .HasConstraintName("FK__Projeto__NomeDoP__534D60F1");
            });

            modelBuilder.Entity<TipoUsuario>(entity =>
            {
                entity.HasKey(e => e.IdTipoUsuario);

                entity.HasIndex(e => e.Nome)
                    .HasName("UQ__TipoUsua__7D8FE3B261CD74F7")
                    .IsUnique();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });
        }
    }
}
