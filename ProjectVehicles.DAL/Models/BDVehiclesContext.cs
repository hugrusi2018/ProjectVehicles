using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ProjectVehicles.DAL.Models
{
    public partial class BDVehiclesContext : DbContext
    {
        public BDVehiclesContext()
        {
        }

        public BDVehiclesContext(DbContextOptions<BDVehiclesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual DbSet<TbBinnacles> TbBinnacles { get; set; }
        public virtual DbSet<TbCars> TbCars { get; set; }
        public virtual DbSet<TbCities> TbCities { get; set; }
        public virtual DbSet<TbFueld> TbFueld { get; set; }
        public virtual DbSet<TbServicesType> TbServicesType { get; set; }
        public virtual DbSet<TbStates> TbStates { get; set; }
        public virtual DbSet<TbThirdParties> TbThirdParties { get; set; }
        public virtual DbSet<TbThirdPartiesTbCars> TbThirdPartiesTbCars { get; set; }
        public virtual DbSet<TbThirdType> TbThirdType { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-0Q6ANR9\\SQLEXPRESS;Database=BDVehicles;User ID=sa;Password=12345");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetRoleClaims>(entity =>
            {
                entity.HasIndex(e => e.RoleId);

                entity.Property(e => e.RoleId).IsRequired();

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName)
                    .HasName("RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasIndex(e => e.RoleId);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail)
                    .HasName("EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName)
                    .HasName("UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);

                entity.HasOne(d => d.Card)
                    .WithMany(p => p.AspNetUsers)
                    .HasForeignKey(d => d.CardId)
                    .HasConstraintName("FK_AspNetUsers_tbCars");
            });

            modelBuilder.Entity<AspNetUserTokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.Name).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<TbBinnacles>(entity =>
            {
                entity.HasKey(e => e.BinId);

                entity.ToTable("tbBinnacles");

                entity.Property(e => e.BinId).ValueGeneratedNever();

                entity.HasOne(d => d.Car)
                    .WithMany(p => p.TbBinnacles)
                    .HasForeignKey(d => d.CarId)
                    .HasConstraintName("FK_tbBinnacles_tbCars");

                entity.HasOne(d => d.Sta)
                    .WithMany(p => p.TbBinnacles)
                    .HasForeignKey(d => d.StaId)
                    .HasConstraintName("FK_tbBinnacles_tbStates");

                entity.HasOne(d => d.Third)
                    .WithMany(p => p.TbBinnacles)
                    .HasForeignKey(d => d.ThirdId)
                    .HasConstraintName("FK_tbBinnacles_tbThirdParties");
            });

            modelBuilder.Entity<TbCars>(entity =>
            {
                entity.HasKey(e => e.CarId);

                entity.ToTable("tbCars");

                entity.Property(e => e.CarId).ValueGeneratedNever();

                entity.Property(e => e.CarCreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CarDisplacement)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CarExpirationDateRtm).HasColumnType("datetime");

                entity.Property(e => e.CarExpirationDateSoat).HasColumnType("datetime");

                entity.Property(e => e.CarExpirationDateSt).HasColumnType("datetime");

                entity.Property(e => e.CarName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Fuel)
                    .WithMany(p => p.TbCars)
                    .HasForeignKey(d => d.FuelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbCars_tbFueld");

                entity.HasOne(d => d.Ser)
                    .WithMany(p => p.TbCars)
                    .HasForeignKey(d => d.SerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbCars_tbServicesType");

                entity.HasOne(d => d.Sta)
                    .WithMany(p => p.TbCars)
                    .HasForeignKey(d => d.StaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbCars_tbStates");
            });

            modelBuilder.Entity<TbCities>(entity =>
            {
                entity.HasKey(e => e.CityId);

                entity.ToTable("tbCities");

                entity.Property(e => e.CityId).ValueGeneratedNever();

                entity.Property(e => e.CityName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbFueld>(entity =>
            {
                entity.HasKey(e => e.FuelId);

                entity.ToTable("tbFueld");

                entity.Property(e => e.FuelId).ValueGeneratedNever();

                entity.Property(e => e.FuelName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbServicesType>(entity =>
            {
                entity.HasKey(e => e.SerId);

                entity.ToTable("tbServicesType");

                entity.Property(e => e.SerId).ValueGeneratedNever();

                entity.Property(e => e.SerName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbStates>(entity =>
            {
                entity.HasKey(e => e.StaId);

                entity.ToTable("tbStates");

                entity.Property(e => e.StaId).ValueGeneratedNever();

                entity.Property(e => e.StaName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbThirdParties>(entity =>
            {
                entity.HasKey(e => e.ThirdId);

                entity.ToTable("tbThirdParties");

                entity.Property(e => e.ThirdId).ValueGeneratedNever();

                entity.Property(e => e.ThirdAddress)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ThirdCreatedAt).HasColumnType("datetime");

                entity.Property(e => e.ThirdName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ThirdObservation)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ThirdTelephone)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.City)
                    .WithMany(p => p.TbThirdParties)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbThirdParties_tbCities");

                entity.HasOne(d => d.ThirdType)
                    .WithMany(p => p.TbThirdParties)
                    .HasForeignKey(d => d.ThirdTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbThirdParties_tbThirdType");
            });

            modelBuilder.Entity<TbThirdPartiesTbCars>(entity =>
            {
                entity.ToTable("tbThirdParties_tbCars");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Car)
                    .WithMany(p => p.TbThirdPartiesTbCars)
                    .HasForeignKey(d => d.CarId)
                    .HasConstraintName("FK_tbThirdParties_tbCars_tbThirdParties_tbCars");

                entity.HasOne(d => d.Third)
                    .WithMany(p => p.TbThirdPartiesTbCars)
                    .HasForeignKey(d => d.ThirdId)
                    .HasConstraintName("FK_tbThirdParties_tbCars_tbThirdParties");
            });

            modelBuilder.Entity<TbThirdType>(entity =>
            {
                entity.HasKey(e => e.ThirdTypeId);

                entity.ToTable("tbThirdType");

                entity.Property(e => e.ThirdTypeId).ValueGeneratedNever();

                entity.Property(e => e.ThirdTypeName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });
        }
    }
}
