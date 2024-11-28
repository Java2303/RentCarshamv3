﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RentCarsham.Models;

#nullable disable

namespace RentCarsham.Migrations
{
    [DbContext(typeof(RentCarshamContext))]
    partial class RentCarshamContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RentCarsham.Models.Alquilere", b =>
                {
                    b.Property<int>("AlquilerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AlquilerId"));

                    b.Property<DateTime>("FechaAlquiler")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("FechaDevolucion")
                        .HasColumnType("datetime");

                    b.Property<decimal>("TotalPago")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.Property<int>("VehiculoId")
                        .HasColumnType("int");

                    b.HasKey("AlquilerId")
                        .HasName("PK__Alquiler__F28020B57F83BCA9");

                    b.HasIndex("UsuarioId");

                    b.HasIndex("VehiculoId");

                    b.ToTable("Alquileres");
                });

            modelBuilder.Entity("RentCarsham.Models.Mantenimiento", b =>
                {
                    b.Property<int>("MantenimientoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MantenimientoId"));

                    b.Property<decimal>("Costo")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<string>("Descripcion")
                        .HasMaxLength(500)
                        .IsUnicode(false)
                        .HasColumnType("varchar(500)");

                    b.Property<DateTime>("FechaMantenimiento")
                        .HasColumnType("datetime");

                    b.Property<string>("TipoMantenimiento")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<int>("VehiculoId")
                        .HasColumnType("int");

                    b.HasKey("MantenimientoId")
                        .HasName("PK__Mantenim__A62E61A2C6DE808C");

                    b.HasIndex("VehiculoId");

                    b.ToTable("Mantenimientos");
                });

            modelBuilder.Entity("RentCarsham.Models.Marca", b =>
                {
                    b.Property<int>("MarcaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MarcaId"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Pais")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.HasKey("MarcaId")
                        .HasName("PK__Marcas__D5B1CD8BFFE75C72");

                    b.HasIndex(new[] { "Nombre" }, "UQ__Marcas__75E3EFCF6D3D6AAB")
                        .IsUnique();

                    b.ToTable("Marcas");
                });

            modelBuilder.Entity("RentCarsham.Models.Modelo", b =>
                {
                    b.Property<int>("ModeloId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ModeloId"));

                    b.Property<string>("Caja")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<int>("CapacidadMaletero")
                        .HasColumnType("int");

                    b.Property<int>("CapacidadPersonas")
                        .HasColumnType("int");

                    b.Property<string>("ImagenRuta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MarcaId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.HasKey("ModeloId")
                        .HasName("PK__Modelos__FA60529A21A7EC68");

                    b.HasIndex("MarcaId");

                    b.ToTable("Modelos");
                });

            modelBuilder.Entity("RentCarsham.Models.Pago", b =>
                {
                    b.Property<int>("PagoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PagoId"));

                    b.Property<int>("AlquilerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaPago")
                        .HasColumnType("datetime");

                    b.Property<string>("MetodoPago")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<decimal>("MontoPagado")
                        .HasColumnType("decimal(10, 2)");

                    b.HasKey("PagoId")
                        .HasName("PK__Pagos__F00B6138C59EB0A8");

                    b.HasIndex("AlquilerId");

                    b.ToTable("Pagos");
                });

            modelBuilder.Entity("RentCarsham.Models.Reserva", b =>
                {
                    b.Property<int>("ReservaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReservaId"));

                    b.Property<DateTime>("FechaFin")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("FechaInicio")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("FechaReserva")
                        .HasColumnType("datetime");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.Property<int>("VehiculoId")
                        .HasColumnType("int");

                    b.HasKey("ReservaId")
                        .HasName("PK__Reservas__C39937633042D796");

                    b.HasIndex("UsuarioId");

                    b.HasIndex("VehiculoId");

                    b.ToTable("Reservas");
                });

            modelBuilder.Entity("RentCarsham.Models.Seguro", b =>
                {
                    b.Property<int>("SeguroId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SeguroId"));

                    b.Property<DateTime>("FechaFin")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("FechaInicio")
                        .HasColumnType("datetime");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<string>("TipoSeguro")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("VehiculoId")
                        .HasColumnType("int");

                    b.HasKey("SeguroId")
                        .HasName("PK__Seguros__8B87D00A2DD844AD");

                    b.HasIndex("VehiculoId");

                    b.ToTable("Seguros");
                });

            modelBuilder.Entity("RentCarsham.Models.Sucursale", b =>
                {
                    b.Property<int>("SucursalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SucursalId"));

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(250)
                        .IsUnicode(false)
                        .HasColumnType("varchar(250)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Telefono")
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)");

                    b.HasKey("SucursalId")
                        .HasName("PK__Sucursal__6CB482E10B2C0321");

                    b.ToTable("Sucursales");
                });

            modelBuilder.Entity("RentCarsham.Models.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UsuarioId"));

                    b.Property<string>("Direccion")
                        .HasMaxLength(250)
                        .IsUnicode(false)
                        .HasColumnType("varchar(250)");

                    b.Property<string>("DocumentoIdentidad")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Rol")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)");

                    b.HasKey("UsuarioId")
                        .HasName("PK__Usuarios__2B3DE7B86C910C35");

                    b.HasIndex(new[] { "Email" }, "UQ__Usuarios__A9D10534BBA585F7")
                        .IsUnique();

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("RentCarsham.Models.Vehiculo", b =>
                {
                    b.Property<int>("VehiculoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VehiculoId"));

                    b.Property<int>("Anio")
                        .HasColumnType("int");

                    b.Property<bool>("Disponible")
                        .HasColumnType("bit");

                    b.Property<int>("Kilometraje")
                        .HasColumnType("int");

                    b.Property<int>("MarcaId")
                        .HasColumnType("int");

                    b.Property<int>("ModeloId")
                        .HasColumnType("int");

                    b.Property<string>("Placa")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<decimal>("PrecioPorDia")
                        .HasColumnType("decimal(10, 2)");

                    b.HasKey("VehiculoId")
                        .HasName("PK__Vehiculo__AA088600294C68B2");

                    b.HasIndex("MarcaId");

                    b.HasIndex("ModeloId");

                    b.HasIndex(new[] { "Placa" }, "UQ__Vehiculo__8310F99D214C4DC6")
                        .IsUnique();

                    b.ToTable("Vehiculos");
                });

            modelBuilder.Entity("VehiculosSucursale", b =>
                {
                    b.Property<int>("VehiculoId")
                        .HasColumnType("int");

                    b.Property<int>("SucursalId")
                        .HasColumnType("int");

                    b.HasKey("VehiculoId", "SucursalId")
                        .HasName("PK__Vehiculo__ACC3CE2ECA68AD39");

                    b.HasIndex("SucursalId");

                    b.ToTable("VehiculosSucursales", (string)null);
                });

            modelBuilder.Entity("RentCarsham.Models.Alquilere", b =>
                {
                    b.HasOne("RentCarsham.Models.Usuario", "Usuario")
                        .WithMany("Alquileres")
                        .HasForeignKey("UsuarioId")
                        .IsRequired()
                        .HasConstraintName("FK__Alquilere__Usuar__1DE57479");

                    b.HasOne("RentCarsham.Models.Vehiculo", "Vehiculo")
                        .WithMany("Alquileres")
                        .HasForeignKey("VehiculoId")
                        .IsRequired()
                        .HasConstraintName("FK__Alquilere__Vehic__1ED998B2");

                    b.Navigation("Usuario");

                    b.Navigation("Vehiculo");
                });

            modelBuilder.Entity("RentCarsham.Models.Mantenimiento", b =>
                {
                    b.HasOne("RentCarsham.Models.Vehiculo", "Vehiculo")
                        .WithMany("Mantenimientos")
                        .HasForeignKey("VehiculoId")
                        .IsRequired()
                        .HasConstraintName("FK__Mantenimi__Vehic__276EDEB3");

                    b.Navigation("Vehiculo");
                });

            modelBuilder.Entity("RentCarsham.Models.Modelo", b =>
                {
                    b.HasOne("RentCarsham.Models.Marca", "Marca")
                        .WithMany("Modelos")
                        .HasForeignKey("MarcaId")
                        .IsRequired()
                        .HasConstraintName("FK__Modelos__MarcaId__164452B1");

                    b.Navigation("Marca");
                });

            modelBuilder.Entity("RentCarsham.Models.Pago", b =>
                {
                    b.HasOne("RentCarsham.Models.Alquilere", "Alquiler")
                        .WithMany("Pagos")
                        .HasForeignKey("AlquilerId")
                        .IsRequired()
                        .HasConstraintName("FK__Pagos__AlquilerI__21B6055D");

                    b.Navigation("Alquiler");
                });

            modelBuilder.Entity("RentCarsham.Models.Reserva", b =>
                {
                    b.HasOne("RentCarsham.Models.Usuario", "Usuario")
                        .WithMany("Reservas")
                        .HasForeignKey("UsuarioId")
                        .IsRequired()
                        .HasConstraintName("FK__Reservas__Usuari__2A4B4B5E");

                    b.HasOne("RentCarsham.Models.Vehiculo", "Vehiculo")
                        .WithMany("Reservas")
                        .HasForeignKey("VehiculoId")
                        .IsRequired()
                        .HasConstraintName("FK__Reservas__Vehicu__2B3F6F97");

                    b.Navigation("Usuario");

                    b.Navigation("Vehiculo");
                });

            modelBuilder.Entity("RentCarsham.Models.Seguro", b =>
                {
                    b.HasOne("RentCarsham.Models.Vehiculo", "Vehiculo")
                        .WithMany("Seguros")
                        .HasForeignKey("VehiculoId")
                        .IsRequired()
                        .HasConstraintName("FK__Seguros__Vehicul__24927208");

                    b.Navigation("Vehiculo");
                });

            modelBuilder.Entity("RentCarsham.Models.Vehiculo", b =>
                {
                    b.HasOne("RentCarsham.Models.Marca", "Marca")
                        .WithMany("Vehiculos")
                        .HasForeignKey("MarcaId")
                        .IsRequired()
                        .HasConstraintName("FK__Vehiculos__Marca__1A14E395");

                    b.HasOne("RentCarsham.Models.Modelo", "Modelo")
                        .WithMany("Vehiculos")
                        .HasForeignKey("ModeloId")
                        .IsRequired()
                        .HasConstraintName("FK__Vehiculos__Model__1B0907CE");

                    b.Navigation("Marca");

                    b.Navigation("Modelo");
                });

            modelBuilder.Entity("VehiculosSucursale", b =>
                {
                    b.HasOne("RentCarsham.Models.Sucursale", null)
                        .WithMany()
                        .HasForeignKey("SucursalId")
                        .IsRequired()
                        .HasConstraintName("FK__Vehiculos__Sucur__30F848ED");

                    b.HasOne("RentCarsham.Models.Vehiculo", null)
                        .WithMany()
                        .HasForeignKey("VehiculoId")
                        .IsRequired()
                        .HasConstraintName("FK__Vehiculos__Vehic__300424B4");
                });

            modelBuilder.Entity("RentCarsham.Models.Alquilere", b =>
                {
                    b.Navigation("Pagos");
                });

            modelBuilder.Entity("RentCarsham.Models.Marca", b =>
                {
                    b.Navigation("Modelos");

                    b.Navigation("Vehiculos");
                });

            modelBuilder.Entity("RentCarsham.Models.Modelo", b =>
                {
                    b.Navigation("Vehiculos");
                });

            modelBuilder.Entity("RentCarsham.Models.Usuario", b =>
                {
                    b.Navigation("Alquileres");

                    b.Navigation("Reservas");
                });

            modelBuilder.Entity("RentCarsham.Models.Vehiculo", b =>
                {
                    b.Navigation("Alquileres");

                    b.Navigation("Mantenimientos");

                    b.Navigation("Reservas");

                    b.Navigation("Seguros");
                });
#pragma warning restore 612, 618
        }
    }
}