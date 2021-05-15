using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace MVD_BD.Models
{
    public partial class MVDContext : DbContext
    {
        public MVDContext()
        {
        }

        public MVDContext(DbContextOptions<MVDContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ВидыПреступлений> ВидыПреступленийs { get; set; }
        public virtual DbSet<Должности> Должностиs { get; set; }
        public virtual DbSet<Звания> Званияs { get; set; }
        public virtual DbSet<Пострадавшие> Пострадавшиеs { get; set; }
        public virtual DbSet<Преступники> Преступникиs { get; set; }
        public virtual DbSet<Сотрудники> Сотрудникиs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source = (localdb)\\mssqllocaldb; Database = Dblybrary; Trusted_Connection = True; ");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ВидыПреступлений>(entity =>
            {
                entity.HasKey(e => e.КодВидаПреступления);

                entity.ToTable("Виды_преступлений");

                entity.HasIndex(e => e.Наименование, "IX_Виды_преступлений_Наименование")
                    .IsUnique();

                entity.HasIndex(e => e.Статья, "IX_Виды_преступлений_Статья")
                    .IsUnique();

                entity.Property(e => e.КодВидаПреступления)
                    .HasColumnType("INT")
                    .ValueGeneratedNever()
                    .HasColumnName("Код_вида_преступления");

                entity.Property(e => e.Наименование).HasColumnType("INT");

                entity.Property(e => e.Наказание).HasColumnType("INT");

                entity.Property(e => e.Срок).HasColumnType("INT");

                entity.Property(e => e.Статья).HasColumnType("INT");
            });

            modelBuilder.Entity<Должности>(entity =>
            {
                entity.HasKey(e => e.КодДолжности);

                entity.ToTable("Должности");

                entity.Property(e => e.КодДолжности)
                    .HasColumnType("INT")
                    .ValueGeneratedNever()
                    .HasColumnName("код_должности");

                entity.Property(e => e.НаименованиеДолжности)
                    .HasColumnType("INT")
                    .HasColumnName("Наименование_должности");

                entity.Property(e => e.Обязанности).HasColumnType("INT");

                entity.Property(e => e.Оклад).HasColumnType("INT");

                entity.Property(e => e.Требования).HasColumnType("INT");
            });

            modelBuilder.Entity<Звания>(entity =>
            {
                entity.HasKey(e => e.КодЗвания);

                entity.ToTable("Звания");

                entity.HasIndex(e => e.Наименование, "IX_Звания_Наименование")
                    .IsUnique();

                entity.Property(e => e.КодЗвания)
                    .HasColumnType("INT")
                    .ValueGeneratedNever()
                    .HasColumnName("Код_звания");

                entity.Property(e => e.Надбавка).HasColumnType("INT");

                entity.Property(e => e.Наименование).HasColumnType("INT");

                entity.Property(e => e.Обязанности).HasColumnType("INT");

                entity.Property(e => e.Требования).HasColumnType("INT");
            });

            modelBuilder.Entity<Пострадавшие>(entity =>
            {
                entity.HasKey(e => e.КодПострадавшего);

                entity.ToTable("Пострадавшие");

                entity.Property(e => e.КодПострадавшего)
                    .HasColumnType("INT")
                    .ValueGeneratedNever()
                    .HasColumnName("Код_пострадавшего");

                entity.Property(e => e.Адес)
                    .HasColumnType("INT")
                    .HasColumnName("адес");

                entity.Property(e => e.ДатаРождения)
                    .HasColumnType("INT")
                    .HasColumnName("Дата_рождения");

                entity.Property(e => e.Пол).HasColumnType("INT");

                entity.Property(e => e.Фио)
                    .HasColumnType("INT")
                    .HasColumnName("ФИО");
            });

            modelBuilder.Entity<Преступники>(entity =>
            {
                entity.HasKey(e => e.НомерДела);

                entity.ToTable("Преступники");

                entity.Property(e => e.НомерДела)
                    .HasColumnType("INT")
                    .ValueGeneratedNever()
                    .HasColumnName("Номер_дела");

                entity.Property(e => e.Адрес).HasColumnType("INT");

                entity.Property(e => e.ДатаРождения)
                    .HasColumnType("INT")
                    .HasColumnName("Дата_рождения");

                entity.Property(e => e.КодВидаПреступления)
                    .HasColumnType("INT")
                    .HasColumnName("Код_вида_преступления");

                entity.Property(e => e.КодПострадавшего)
                    .HasColumnType("INT")
                    .HasColumnName("Код_пострадавшего");

                entity.Property(e => e.КодСотрудника)
                    .HasColumnType("INT")
                    .HasColumnName("Код_сотрудника");

                entity.Property(e => e.Пол).HasColumnType("INT");

                entity.Property(e => e.Состояние).HasColumnType("INT");

                entity.Property(e => e.Фио)
                    .HasColumnType("INT")
                    .HasColumnName("ФИО");

                entity.HasOne(d => d.КодВидаПреступленияNavigation)
                    .WithMany(p => p.Преступникиs)
                    .HasForeignKey(d => d.КодВидаПреступления)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.КодСотрудникаNavigation)
                    .WithMany(p => p.Преступникиs)
                    .HasForeignKey(d => d.КодСотрудника)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Сотрудники>(entity =>
            {
                entity.HasKey(e => e.КодСотрудника);

                entity.ToTable("Сотрудники");

                entity.HasIndex(e => e.КодДолжности, "IX_Сотрудники_код_должности")
                    .IsUnique();

                entity.HasIndex(e => e.КодЗвания, "IX_Сотрудники_Код_звания")
                    .IsUnique();

                entity.HasIndex(e => e.ПаспортныеДанные, "IX_Сотрудники_Паспортные_данные")
                    .IsUnique();

                entity.HasIndex(e => e.Телефон, "IX_Сотрудники_Телефон")
                    .IsUnique();

                entity.Property(e => e.КодСотрудника)
                    .HasColumnType("INT")
                    .ValueGeneratedNever()
                    .HasColumnName("Код_сотрудника");

                entity.Property(e => e.Адрес).HasColumnType("INT");

                entity.Property(e => e.Возраст).HasColumnType("INT");

                entity.Property(e => e.КодДолжности)
                    .HasColumnType("INT")
                    .HasColumnName("код_должности");

                entity.Property(e => e.КодЗвания)
                    .HasColumnType("INT")
                    .HasColumnName("Код_звания");

                entity.Property(e => e.ПаспортныеДанные)
                    .HasColumnType("INT")
                    .HasColumnName("Паспортные_данные");

                entity.Property(e => e.Пол).HasColumnType("INT");

                entity.Property(e => e.Телефон).HasColumnType("INT");

                entity.Property(e => e.Фио)
                    .HasColumnType("INT")
                    .HasColumnName("ФИО");

                entity.HasOne(d => d.КодДолжностиNavigation)
                    .WithOne(p => p.Сотрудники)
                    .HasForeignKey<Сотрудники>(d => d.КодДолжности)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.КодЗванияNavigation)
                    .WithOne(p => p.Сотрудники)
                    .HasForeignKey<Сотрудники>(d => d.КодЗвания)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
