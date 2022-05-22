﻿// <auto-generated />
using HeathCheck1.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace HeathCheck1.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220522154436_tabelaespecialista")]
    partial class tabelaespecialista
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("HeathCheck1.Models.EspecialidadeModel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("especialidades");
                });

            modelBuilder.Entity("HeathCheck1.Models.EspecialistaModel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("especialidadeid")
                        .HasColumnType("integer");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("registro")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("senha")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("sobrenome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("telefone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.HasIndex("especialidadeid");

                    b.ToTable("especialistas");
                });

            modelBuilder.Entity("HeathCheck1.Models.EspecialistaModel", b =>
                {
                    b.HasOne("HeathCheck1.Models.EspecialidadeModel", "especialidade")
                        .WithMany("especialistas")
                        .HasForeignKey("especialidadeid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("especialidade");
                });

            modelBuilder.Entity("HeathCheck1.Models.EspecialidadeModel", b =>
                {
                    b.Navigation("especialistas");
                });
#pragma warning restore 612, 618
        }
    }
}