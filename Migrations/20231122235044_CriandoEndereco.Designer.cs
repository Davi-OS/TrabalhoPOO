﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Trabalho_POO.Context;

#nullable disable

namespace Trabalho_POO.Migrations
{
    [DbContext(typeof(ProjetoDbContext))]
    [Migration("20231122235044_CriandoEndereco")]
    partial class CriandoEndereco
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Trabalho_POO.Models.Cliente_", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(14)
                        .HasColumnType("varchar(14)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Trabalho_POO.Models.Conta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<decimal>("Subtotal")
                        .HasColumnType("Decimal (10,2)");

                    b.Property<decimal>("Total")
                        .HasColumnType("Decimal (10,2)");

                    b.Property<string>("clienteId")
                        .IsRequired()
                        .HasColumnType("varchar(14)");

                    b.Property<double>("consumo")
                        .HasColumnType("Double (10,3)");

                    b.Property<DateTime>("lançamento")
                        .HasColumnType("datetime(6)");

                    b.Property<double>("leitura")
                        .HasColumnType("double");

                    b.Property<double>("leituraAnterior")
                        .HasColumnType("double");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.Property<int>("tipo")
                        .HasColumnType("int");

                    b.Property<DateOnly>("vencimento")
                        .HasColumnType("date");

                    b.HasKey("Id");

                    b.HasIndex("clienteId");

                    b.ToTable("Conta");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Conta");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Trabalho_POO.Models.ContaAgua", b =>
                {
                    b.HasBaseType("Trabalho_POO.Models.Conta");

                    b.HasDiscriminator().HasValue("ContaAgua");
                });

            modelBuilder.Entity("Trabalho_POO.Models.ContaLuz", b =>
                {
                    b.HasBaseType("Trabalho_POO.Models.Conta");

                    b.HasDiscriminator().HasValue("ContaLuz");
                });

            modelBuilder.Entity("Trabalho_POO.Models.Conta", b =>
                {
                    b.HasOne("Trabalho_POO.Models.Cliente_", "cliente")
                        .WithMany("contas")
                        .HasForeignKey("clienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("cliente");
                });

            modelBuilder.Entity("Trabalho_POO.Models.Cliente_", b =>
                {
                    b.Navigation("contas");
                });
#pragma warning restore 612, 618
        }
    }
}
