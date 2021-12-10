﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using PrimeiraApiWorkshop.DataBase;

namespace PrimeiraApiWorkshop.DataBase
{
    [DbContext(typeof(NpgContext))]
    partial class NpgContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("PrimeiraApiWorkshop.Models.Vehicle", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id")
                        .UseIdentityByDefaultColumn();

                    b.Property<DateTime>("Ano")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("ano");

                    b.Property<string>("CidadeFabricacao")
                        .HasColumnType("text")
                        .HasColumnName("cidade_fabricacao");

                    b.Property<string>("Marca")
                        .HasColumnType("text")
                        .HasColumnName("marca");

                    b.Property<string>("Modelo")
                        .HasColumnType("text")
                        .HasColumnName("modelo");

                    b.HasKey("Id");

                    b.ToTable("tb_vehicle");
                });
#pragma warning restore 612, 618
        }
    }
}
