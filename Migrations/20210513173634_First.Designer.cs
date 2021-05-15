﻿// <auto-generated />
using MVD_BD.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MVD_BD.Migrations
{
    [DbContext(typeof(MVDContext))]
    [Migration("20210513173634_First")]
    partial class First
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MVD_BD.Models.ВидыПреступлений", b =>
                {
                    b.Property<int>("КодВидаПреступления")
                        .HasColumnType("INT")
                        .HasColumnName("Код_вида_преступления");

                    b.Property<int>("Наименование")
                        .HasColumnType("INT");

                    b.Property<int>("Наказание")
                        .HasColumnType("INT");

                    b.Property<int>("Срок")
                        .HasColumnType("INT");

                    b.Property<int>("Статья")
                        .HasColumnType("INT");

                    b.HasKey("КодВидаПреступления");

                    b.HasIndex(new[] { "Наименование" }, "IX_Виды_преступлений_Наименование")
                        .IsUnique();

                    b.HasIndex(new[] { "Статья" }, "IX_Виды_преступлений_Статья")
                        .IsUnique();

                    b.ToTable("Виды_преступлений");
                });

            modelBuilder.Entity("MVD_BD.Models.Должности", b =>
                {
                    b.Property<int>("КодДолжности")
                        .HasColumnType("INT")
                        .HasColumnName("код_должности");

                    b.Property<int>("НаименованиеДолжности")
                        .HasColumnType("INT")
                        .HasColumnName("Наименование_должности");

                    b.Property<int>("Обязанности")
                        .HasColumnType("INT");

                    b.Property<int>("Оклад")
                        .HasColumnType("INT");

                    b.Property<int>("Требования")
                        .HasColumnType("INT");

                    b.HasKey("КодДолжности");

                    b.ToTable("Должности");
                });

            modelBuilder.Entity("MVD_BD.Models.Звания", b =>
                {
                    b.Property<int>("КодЗвания")
                        .HasColumnType("INT")
                        .HasColumnName("Код_звания");

                    b.Property<int>("Надбавка")
                        .HasColumnType("INT");

                    b.Property<int>("Наименование")
                        .HasColumnType("INT");

                    b.Property<int>("Обязанности")
                        .HasColumnType("INT");

                    b.Property<int>("Требования")
                        .HasColumnType("INT");

                    b.HasKey("КодЗвания");

                    b.HasIndex(new[] { "Наименование" }, "IX_Звания_Наименование")
                        .IsUnique();

                    b.ToTable("Звания");
                });

            modelBuilder.Entity("MVD_BD.Models.Пострадавшие", b =>
                {
                    b.Property<int>("КодПострадавшего")
                        .HasColumnType("INT")
                        .HasColumnName("Код_пострадавшего");

                    b.Property<int>("Адес")
                        .HasColumnType("INT")
                        .HasColumnName("адес");

                    b.Property<int>("ДатаРождения")
                        .HasColumnType("INT")
                        .HasColumnName("Дата_рождения");

                    b.Property<int>("Пол")
                        .HasColumnType("INT");

                    b.Property<int>("Фио")
                        .HasColumnType("INT")
                        .HasColumnName("ФИО");

                    b.HasKey("КодПострадавшего");

                    b.ToTable("Пострадавшие");
                });

            modelBuilder.Entity("MVD_BD.Models.Преступники", b =>
                {
                    b.Property<int>("НомерДела")
                        .HasColumnType("INT")
                        .HasColumnName("Номер_дела");

                    b.Property<int>("Адрес")
                        .HasColumnType("INT");

                    b.Property<int>("ДатаРождения")
                        .HasColumnType("INT")
                        .HasColumnName("Дата_рождения");

                    b.Property<int>("КодВидаПреступления")
                        .HasColumnType("INT")
                        .HasColumnName("Код_вида_преступления");

                    b.Property<int>("КодПострадавшего")
                        .HasColumnType("INT")
                        .HasColumnName("Код_пострадавшего");

                    b.Property<int>("КодСотрудника")
                        .HasColumnType("INT")
                        .HasColumnName("Код_сотрудника");

                    b.Property<int>("Пол")
                        .HasColumnType("INT");

                    b.Property<int>("Состояние")
                        .HasColumnType("INT");

                    b.Property<int>("Фио")
                        .HasColumnType("INT")
                        .HasColumnName("ФИО");

                    b.HasKey("НомерДела");

                    b.HasIndex("КодВидаПреступления");

                    b.HasIndex("КодСотрудника");

                    b.ToTable("Преступники");
                });

            modelBuilder.Entity("MVD_BD.Models.Сотрудники", b =>
                {
                    b.Property<int>("КодСотрудника")
                        .HasColumnType("INT")
                        .HasColumnName("Код_сотрудника");

                    b.Property<int>("Адрес")
                        .HasColumnType("INT");

                    b.Property<int>("Возраст")
                        .HasColumnType("INT");

                    b.Property<int>("КодДолжности")
                        .HasColumnType("INT")
                        .HasColumnName("код_должности");

                    b.Property<int>("КодЗвания")
                        .HasColumnType("INT")
                        .HasColumnName("Код_звания");

                    b.Property<int>("ПаспортныеДанные")
                        .HasColumnType("INT")
                        .HasColumnName("Паспортные_данные");

                    b.Property<int>("Пол")
                        .HasColumnType("INT");

                    b.Property<int>("Телефон")
                        .HasColumnType("INT");

                    b.Property<int>("Фио")
                        .HasColumnType("INT")
                        .HasColumnName("ФИО");

                    b.HasKey("КодСотрудника");

                    b.HasIndex(new[] { "КодЗвания" }, "IX_Сотрудники_Код_звания")
                        .IsUnique();

                    b.HasIndex(new[] { "ПаспортныеДанные" }, "IX_Сотрудники_Паспортные_данные")
                        .IsUnique();

                    b.HasIndex(new[] { "Телефон" }, "IX_Сотрудники_Телефон")
                        .IsUnique();

                    b.HasIndex(new[] { "КодДолжности" }, "IX_Сотрудники_код_должности")
                        .IsUnique();

                    b.ToTable("Сотрудники");
                });

            modelBuilder.Entity("MVD_BD.Models.Преступники", b =>
                {
                    b.HasOne("MVD_BD.Models.ВидыПреступлений", "КодВидаПреступленияNavigation")
                        .WithMany("Преступникиs")
                        .HasForeignKey("КодВидаПреступления")
                        .IsRequired();

                    b.HasOne("MVD_BD.Models.Сотрудники", "КодСотрудникаNavigation")
                        .WithMany("Преступникиs")
                        .HasForeignKey("КодСотрудника")
                        .IsRequired();

                    b.Navigation("КодВидаПреступленияNavigation");

                    b.Navigation("КодСотрудникаNavigation");
                });

            modelBuilder.Entity("MVD_BD.Models.Сотрудники", b =>
                {
                    b.HasOne("MVD_BD.Models.Должности", "КодДолжностиNavigation")
                        .WithOne("Сотрудники")
                        .HasForeignKey("MVD_BD.Models.Сотрудники", "КодДолжности")
                        .IsRequired();

                    b.HasOne("MVD_BD.Models.Звания", "КодЗванияNavigation")
                        .WithOne("Сотрудники")
                        .HasForeignKey("MVD_BD.Models.Сотрудники", "КодЗвания")
                        .IsRequired();

                    b.Navigation("КодДолжностиNavigation");

                    b.Navigation("КодЗванияNavigation");
                });

            modelBuilder.Entity("MVD_BD.Models.ВидыПреступлений", b =>
                {
                    b.Navigation("Преступникиs");
                });

            modelBuilder.Entity("MVD_BD.Models.Должности", b =>
                {
                    b.Navigation("Сотрудники");
                });

            modelBuilder.Entity("MVD_BD.Models.Звания", b =>
                {
                    b.Navigation("Сотрудники");
                });

            modelBuilder.Entity("MVD_BD.Models.Сотрудники", b =>
                {
                    b.Navigation("Преступникиs");
                });
#pragma warning restore 612, 618
        }
    }
}
