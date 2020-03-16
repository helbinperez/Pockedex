using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PokemonTarea.Models
{
    public partial class PockedexContext : DbContext
    {
        public PockedexContext()
        {
        }

        public PockedexContext(DbContextOptions<PockedexContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Ataques> Ataques { get; set; }
        public virtual DbSet<AtaquesPokemon> AtaquesPokemon { get; set; }
        public virtual DbSet<Color> Color { get; set; }
        public virtual DbSet<Pokemon> Pokemon { get; set; }
        public virtual DbSet<Region> Region { get; set; }
        public virtual DbSet<TipoPokemon> TipoPokemon { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-RSFHOUK\\SQLEXPRESS;Initial Catalog=Pockedex;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Ataques>(entity =>
            {
                entity.HasKey(e => e.IdAtaque)
                    .HasName("PK_ATAQUE");

                entity.ToTable("ATAQUES");

                entity.Property(e => e.IdAtaque).HasColumnName("ID_ATAQUE");

                entity.Property(e => e.Ataque)
                    .IsRequired()
                    .HasColumnName("ATAQUE")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AtaquesPokemon>(entity =>
            {
                entity.HasKey(e => e.IdAtaquesPokemon)
                    .HasName("PK_IDPOK_ATA");

                entity.ToTable("ATAQUES_POKEMON");

                entity.Property(e => e.IdAtaquesPokemon).HasColumnName("ID_ATAQUES_POKEMON");

                entity.Property(e => e.AtaquesId).HasColumnName("ATAQUES_ID");

                entity.Property(e => e.PokemonId).HasColumnName("POKEMON_ID");

                entity.HasOne(d => d.Ataques)
                    .WithMany(p => p.AtaquesPokemon)
                    .HasForeignKey(d => d.AtaquesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ATAQUES");

                entity.HasOne(d => d.Pokemon)
                    .WithMany(p => p.AtaquesPokemon)
                    .HasForeignKey(d => d.PokemonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_POKEMON");
            });

            modelBuilder.Entity<Color>(entity =>
            {
                entity.HasKey(e => e.IdColor);

                entity.ToTable("COLOR");

                entity.Property(e => e.IdColor).HasColumnName("ID_COLOR");

                entity.Property(e => e.Color1)
                    .IsRequired()
                    .HasColumnName("COLOR")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Pokemon>(entity =>
            {
                entity.HasKey(e => e.IdPokemon);

                entity.ToTable("POKEMON");

                entity.Property(e => e.IdPokemon).HasColumnName("ID_POKEMON");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Region).HasColumnName("REGION");

                entity.Property(e => e.Tipo).HasColumnName("TIPO");

                entity.HasOne(d => d.RegionNavigation)
                    .WithMany(p => p.Pokemon)
                    .HasForeignKey(d => d.Region)
                    .HasConstraintName("FK_REGION_POKEMON");

                entity.HasOne(d => d.TipoNavigation)
                    .WithMany(p => p.Pokemon)
                    .HasForeignKey(d => d.Tipo)
                    .HasConstraintName("FK_TIPO_POKEMON");
            });

            modelBuilder.Entity<Region>(entity =>
            {
                entity.HasKey(e => e.IdRegion);

                entity.ToTable("REGION");

                entity.Property(e => e.IdRegion).HasColumnName("ID_REGION");

                entity.Property(e => e.Color).HasColumnName("COLOR");

                entity.Property(e => e.Region1)
                    .IsRequired()
                    .HasColumnName("REGION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.ColorNavigation)
                    .WithMany(p => p.Region)
                    .HasForeignKey(d => d.Color)
                    .HasConstraintName("FK_REGION_COLOR");
            });

            modelBuilder.Entity<TipoPokemon>(entity =>
            {
                entity.HasKey(e => e.IdTipo)
                    .HasName("PK_TIPO");

                entity.ToTable("TIPO_POKEMON");

                entity.Property(e => e.IdTipo).HasColumnName("ID_TIPO");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasColumnName("TIPO")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
        }
    }
}
