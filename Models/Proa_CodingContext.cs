using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace API_Project.Models
{
    public partial class Proa_CodingContext : DbContext
    {
        public Proa_CodingContext()
        {
        }

        public Proa_CodingContext(DbContextOptions<Proa_CodingContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Data1> Data1s { get; set; } = null!;
        public virtual DbSet<Data10> Data10s { get; set; } = null!;
        public virtual DbSet<Data2> Data2s { get; set; } = null!;
        public virtual DbSet<Data3> Data3s { get; set; } = null!;
        public virtual DbSet<Data4> Data4s { get; set; } = null!;
        public virtual DbSet<Data5> Data5s { get; set; } = null!;
        public virtual DbSet<Data6> Data6s { get; set; } = null!;
        public virtual DbSet<Data7> Data7s { get; set; } = null!;
        public virtual DbSet<Data8> Data8s { get; set; } = null!;
        public virtual DbSet<Data9> Data9s { get; set; } = null!;
        public virtual DbSet<Variable> Variables { get; set; } = null!;
        public virtual DbSet<WeatherStation> WeatherStations { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-TUQCAE1;Database=Proa_Coding;Trusted_Connection=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Data1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("data_1");

                entity.Property(e => e.AirTInst)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AirT_inst");

                entity.Property(e => e.GhiInst)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GHI_inst");

                entity.Property(e => e.Timestamp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("timestamp");
            });

            modelBuilder.Entity<Data10>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("data_10");

                entity.Property(e => e.AirTInst)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AirT_inst");

                entity.Property(e => e.GhiInst)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GHI_inst");

                entity.Property(e => e.Timestamp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("timestamp");
            });

            modelBuilder.Entity<Data2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("data_2");

                entity.Property(e => e.AvgAirTemp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("avg_airTemp");

                entity.Property(e => e.AvgWm2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("avg_Wm2");

                entity.Property(e => e.Timestamp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("timestamp");
            });

            modelBuilder.Entity<Data3>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("data_3");

                entity.Property(e => e.AirTInst)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AirT_inst");

                entity.Property(e => e.GhiInst)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GHI_inst");

                entity.Property(e => e.Timestamp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("timestamp");
            });

            modelBuilder.Entity<Data4>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("data_4");

                entity.Property(e => e.GhiInst)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GHI_inst");

                entity.Property(e => e.Timestamp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("timestamp");
            });

            modelBuilder.Entity<Data5>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("data_5");

                entity.Property(e => e.GhiInst)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GHI_inst");

                entity.Property(e => e.Timestamp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("timestamp");
            });

            modelBuilder.Entity<Data6>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("data_6");

                entity.Property(e => e.GhiInst)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GHI_inst");

                entity.Property(e => e.Timestamp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("timestamp");
            });

            modelBuilder.Entity<Data7>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("data_7");

                entity.Property(e => e.Timestamp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("timestamp");

                entity.Property(e => e.WdAvg)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("WD_avg");

                entity.Property(e => e.WsAvg)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("WS_avg");
            });

            modelBuilder.Entity<Data8>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("data_8");

                entity.Property(e => e.Timestamp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("timestamp");

                entity.Property(e => e.WdAvg)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("WD_avg");

                entity.Property(e => e.WsAvg)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("WS_avg");
            });

            modelBuilder.Entity<Data9>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("data_9");

                entity.Property(e => e.AirTInst)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AirT_inst");

                entity.Property(e => e.GhiInst)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GHI_inst");

                entity.Property(e => e.Timestamp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("timestamp");
            });

            modelBuilder.Entity<Variable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("variables");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("id");

                entity.Property(e => e.LongName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("long_name");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Unit)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("unit");

                entity.Property(e => e.VarId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("var_id");
            });

            modelBuilder.Entity<WeatherStation>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("weather_stations");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("id");

                entity.Property(e => e.Latitude)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("latitude");

                entity.Property(e => e.Longitude)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("longitude");

                entity.Property(e => e.Portfolio)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("portfolio");

                entity.Property(e => e.Site)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("site");

                entity.Property(e => e.State)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("state");

                entity.Property(e => e.WsName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ws_name");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
