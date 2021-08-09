using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Web_App_ASP.NET_Core_MVC_
{
    public partial class TaxiInDronContext : DbContext
    {
        public TaxiInDronContext()
        {
        }

        public TaxiInDronContext(DbContextOptions<TaxiInDronContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ColorDron> ColorDrons { get; set; }
        public virtual DbSet<Dron> Drons { get; set; }
        public virtual DbSet<HarkDron> HarkDrons { get; set; }
        public virtual DbSet<ToSatu> ToSatus { get; set; }
        public virtual DbSet<Zakaz> Zakazs { get; set; }
        public virtual DbSet<Zvonk> Zvonks { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("Server=WIN-TUD2DUAF5IN\\SQLEXPRESS;Database=TaxiInDron;Trusted_Connection=True;");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ColorDron>(entity =>
            {
                entity.ToTable("ColorDron");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

           

            modelBuilder.Entity<Dron>(entity =>
            {
                entity.ToTable("Dron");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Descrip).HasMaxLength(200);

                entity.Property(e => e.Igm).HasMaxLength(200);

                entity.Property(e => e.Name).HasMaxLength(250);
            });

          
            modelBuilder.Entity<HarkDron>(entity =>
            {
                entity.ToTable("HarkDron");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateVp)
                    .HasColumnType("date")
                    .HasColumnName("DateVP");

                entity.Property(e => e.ImgDron).HasMaxLength(200);
                entity.Property(e => e.full_name).HasMaxLength(200);

                entity.HasOne(d => d.ColorNavigation)
                    .WithMany(p => p.HarkDrons)
                    .HasForeignKey(d => d.Color)
                    .HasConstraintName("FK_HarkDron_ColorDron");

                entity.HasOne(d => d.WhoIsAvtoNavigation)
                    .WithMany(p => p.HarkDrons)
                    .HasForeignKey(d => d.WhoIsAvto)
                    .HasConstraintName("FK_HarkDron_Dron");
            });

            modelBuilder.Entity<ToSatu>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Zakaz>(entity =>
            {
                entity.HasKey(e => e.NomerZakaza);

                entity.ToTable("Zakaz");

                entity.Property(e => e.AddresDost).HasMaxLength(150);

                entity.Property(e => e.DateZak).HasColumnType("date");

                entity.Property(e => e.WhoIszak).HasColumnName("WhoISZak");

                entity.HasOne(d => d.CurrZakNavigation)
                    .WithMany(p => p.Zakazs)
                    .HasForeignKey(d => d.CurrZak)
                    .HasConstraintName("FK_Zakaz_Dron");

                entity.HasOne(d => d.StatusNavigation)
                    .WithMany(p => p.Zakazs)
                    .HasForeignKey(d => d.Status)
                    .HasConstraintName("FK_Zakaz_ToSatus");
            });

            modelBuilder.Entity<Zvonk>(entity =>
            {
                entity.ToTable("Zvonk");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.Tel).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
