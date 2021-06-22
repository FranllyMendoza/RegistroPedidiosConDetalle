﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RegistroPedidiosConDetalle.DAL;

namespace RegistroPedidiosConDetalle.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20210622031453_inicial")]
    partial class inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.7");

            modelBuilder.Entity("RegistroPedidiosConDetalle.Models.Ordenes", b =>
                {
                    b.Property<int>("OrdenId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<float>("Monto")
                        .HasColumnType("REAL");

                    b.Property<int>("SuplidorId")
                        .HasColumnType("INTEGER");

                    b.HasKey("OrdenId");

                    b.ToTable("Ordenes");
                });

            modelBuilder.Entity("RegistroPedidiosConDetalle.Models.OrdenesDetalle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<float>("Cantidad")
                        .HasColumnType("REAL");

                    b.Property<float>("Costo")
                        .HasColumnType("REAL");

                    b.Property<int>("OrdenId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("OrdenId");

                    b.ToTable("OrdenesDetalle");
                });

            modelBuilder.Entity("RegistroPedidiosConDetalle.Models.Productos", b =>
                {
                    b.Property<int>("ProductoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<float>("Costo")
                        .HasColumnType("REAL");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<float>("Inventario")
                        .HasColumnType("REAL");

                    b.HasKey("ProductoId");

                    b.ToTable("Productos");

                    b.HasData(
                        new
                        {
                            ProductoId = 1,
                            Costo = 25f,
                            Descripcion = "Refresco",
                            Inventario = 500f
                        },
                        new
                        {
                            ProductoId = 2,
                            Costo = 150f,
                            Descripcion = "Pollo frito",
                            Inventario = 300f
                        },
                        new
                        {
                            ProductoId = 3,
                            Costo = 200f,
                            Descripcion = "Vino Casero",
                            Inventario = 100f
                        });
                });

            modelBuilder.Entity("RegistroPedidiosConDetalle.Models.Suplidores", b =>
                {
                    b.Property<int>("SuplidorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("SuplidorId");

                    b.ToTable("Suplidores");

                    b.HasData(
                        new
                        {
                            SuplidorId = 1,
                            Nombres = "Juan Francisco Mendoza "
                        },
                        new
                        {
                            SuplidorId = 2,
                            Nombres = "La Verdolaga"
                        },
                        new
                        {
                            SuplidorId = 3,
                            Nombres = "Manuel Jimenes"
                        });
                });

            modelBuilder.Entity("RegistroPedidiosConDetalle.Models.OrdenesDetalle", b =>
                {
                    b.HasOne("RegistroPedidiosConDetalle.Models.Ordenes", null)
                        .WithMany("Detalle")
                        .HasForeignKey("OrdenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RegistroPedidiosConDetalle.Models.Ordenes", b =>
                {
                    b.Navigation("Detalle");
                });
#pragma warning restore 612, 618
        }
    }
}
