﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Transport.Data;

namespace Transport.Data
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Transport.Models.Tablas.Cliente", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DPI")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<DateTime>("Inicio")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Inversion")
                        .HasColumnType("money");

                    b.Property<bool>("Masculino")
                        .HasColumnType("bit");

                    b.Property<int>("NIT")
                        .HasColumnType("int");

                    b.Property<DateTime>("Nacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("NumeroPedidos")
                        .HasColumnType("int");

                    b.Property<int>("Telefono")
                        .HasColumnType("int");

                    b.HasKey("ClienteId");

                    b.ToTable("T_Cliente");
                });

            modelBuilder.Entity("Transport.Models.Tablas.Departamento", b =>
                {
                    b.Property<int>("DepartamentoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.HasKey("DepartamentoId");

                    b.ToTable("T_Departamento");
                });

            modelBuilder.Entity("Transport.Models.Tablas.Directorio", b =>
                {
                    b.Property<int>("DirectorioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Contacto")
                        .HasColumnType("int");

                    b.Property<string>("Correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Indicaciones")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("ProductoId")
                        .HasColumnType("int");

                    b.Property<int>("TipoLugarID")
                        .HasColumnType("int");

                    b.HasKey("DirectorioId");

                    b.HasIndex("ProductoId");

                    b.HasIndex("TipoLugarID")
                        .IsUnique();

                    b.ToTable("T_Directorio");
                });

            modelBuilder.Entity("Transport.Models.Tablas.Planta", b =>
                {
                    b.Property<int>("PlantaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DepartamentoID")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("Procesamiento")
                        .HasColumnType("bit");

                    b.HasKey("PlantaId");

                    b.HasIndex("DepartamentoID")
                        .IsUnique();

                    b.ToTable("T_Planta");
                });

            modelBuilder.Entity("Transport.Models.Tablas.Producto", b =>
                {
                    b.Property<int>("ProductoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("CostoUnidad")
                        .HasColumnType("money");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("Existencias")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("UnidadMedida")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.HasKey("ProductoId");

                    b.ToTable("T_Producto");
                });

            modelBuilder.Entity("Transport.Models.Tablas.ProductoAsignado", b =>
                {
                    b.Property<int>("ProductoID")
                        .HasColumnType("int");

                    b.Property<int>("PlantaID")
                        .HasColumnType("int");

                    b.HasKey("ProductoID", "PlantaID");

                    b.HasIndex("PlantaID");

                    b.ToTable("T_ProductoAsignado");
                });

            modelBuilder.Entity("Transport.Models.Tablas.SolicitudTransporte", b =>
                {
                    b.Property<int>("SolicitudTransporteID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int>("ClienteID")
                        .HasColumnType("int");

                    b.Property<int>("Contacto")
                        .HasColumnType("int");

                    b.Property<int>("DestinoID")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaEntrega")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaSolicitud")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Pagado")
                        .HasColumnType("bit");

                    b.Property<int>("ProductoID")
                        .HasColumnType("int");

                    b.Property<string>("Receptor")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Total")
                        .HasColumnType("money");

                    b.Property<string>("UnidadMedida")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.HasKey("SolicitudTransporteID");

                    b.HasIndex("ClienteID")
                        .IsUnique();

                    b.HasIndex("DestinoID");

                    b.HasIndex("ProductoID");

                    b.ToTable("T_SolicitudTransporte");
                });

            modelBuilder.Entity("Transport.Models.Tablas.TipoLugar", b =>
                {
                    b.Property<int>("TipoLugarID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Lugar")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("TipoLugarID");

                    b.ToTable("T_TipoLugar");
                });

            modelBuilder.Entity("Transport.Models.Tablas.TipoVehiculo", b =>
                {
                    b.Property<int>("TipoVehiculoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Capacidad")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("UnidadMedida")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.HasKey("TipoVehiculoID");

                    b.ToTable("T_TipoVehiculo");
                });

            modelBuilder.Entity("Transport.Models.Tablas.Vehiculo", b =>
                {
                    b.Property<int>("VehiculoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Linea")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<bool>("Mantenimiento")
                        .HasColumnType("bit");

                    b.Property<int>("Modelo")
                        .HasColumnType("int");

                    b.Property<string>("Placa")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.Property<int?>("PlantaId")
                        .HasColumnType("int");

                    b.Property<bool>("Ruta")
                        .HasColumnType("bit");

                    b.Property<int>("TipoVehiculoID")
                        .HasColumnType("int");

                    b.HasKey("VehiculoId");

                    b.HasIndex("PlantaId");

                    b.HasIndex("TipoVehiculoID")
                        .IsUnique();

                    b.ToTable("T_Vehiculo");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Transport.Models.Tablas.Directorio", b =>
                {
                    b.HasOne("Transport.Models.Tablas.Producto", null)
                        .WithMany("Directorios")
                        .HasForeignKey("ProductoId");

                    b.HasOne("Transport.Models.Tablas.TipoLugar", "TipoLugar")
                        .WithOne("Directorio")
                        .HasForeignKey("Transport.Models.Tablas.Directorio", "TipoLugarID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TipoLugar");
                });

            modelBuilder.Entity("Transport.Models.Tablas.Planta", b =>
                {
                    b.HasOne("Transport.Models.Tablas.Departamento", "Departamento")
                        .WithOne("Planta")
                        .HasForeignKey("Transport.Models.Tablas.Planta", "DepartamentoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Departamento");
                });

            modelBuilder.Entity("Transport.Models.Tablas.ProductoAsignado", b =>
                {
                    b.HasOne("Transport.Models.Tablas.Planta", "Planta")
                        .WithMany("ProductosAsignados")
                        .HasForeignKey("PlantaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Transport.Models.Tablas.Producto", "Producto")
                        .WithMany("ProductosAsignados")
                        .HasForeignKey("ProductoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Planta");

                    b.Navigation("Producto");
                });

            modelBuilder.Entity("Transport.Models.Tablas.SolicitudTransporte", b =>
                {
                    b.HasOne("Transport.Models.Tablas.Cliente", "Cliente")
                        .WithOne("SolicitudTransporte")
                        .HasForeignKey("Transport.Models.Tablas.SolicitudTransporte", "ClienteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Transport.Models.Tablas.Directorio", "Destino")
                        .WithMany()
                        .HasForeignKey("DestinoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Transport.Models.Tablas.Producto", "Producto")
                        .WithMany()
                        .HasForeignKey("ProductoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Destino");

                    b.Navigation("Producto");
                });

            modelBuilder.Entity("Transport.Models.Tablas.Vehiculo", b =>
                {
                    b.HasOne("Transport.Models.Tablas.Planta", null)
                        .WithMany("Vehiculos")
                        .HasForeignKey("PlantaId");

                    b.HasOne("Transport.Models.Tablas.TipoVehiculo", "TipoVehiculo")
                        .WithOne("Vehiculo")
                        .HasForeignKey("Transport.Models.Tablas.Vehiculo", "TipoVehiculoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TipoVehiculo");
                });

            modelBuilder.Entity("Transport.Models.Tablas.Cliente", b =>
                {
                    b.Navigation("SolicitudTransporte");
                });

            modelBuilder.Entity("Transport.Models.Tablas.Departamento", b =>
                {
                    b.Navigation("Planta");
                });

            modelBuilder.Entity("Transport.Models.Tablas.Planta", b =>
                {
                    b.Navigation("ProductosAsignados");

                    b.Navigation("Vehiculos");
                });

            modelBuilder.Entity("Transport.Models.Tablas.Producto", b =>
                {
                    b.Navigation("Directorios");

                    b.Navigation("ProductosAsignados");
                });

            modelBuilder.Entity("Transport.Models.Tablas.TipoLugar", b =>
                {
                    b.Navigation("Directorio");
                });

            modelBuilder.Entity("Transport.Models.Tablas.TipoVehiculo", b =>
                {
                    b.Navigation("Vehiculo");
                });
#pragma warning restore 612, 618
        }
    }
}