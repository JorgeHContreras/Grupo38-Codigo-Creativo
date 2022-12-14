// <auto-generated />
using System;
using CCM.App.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CCM.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    partial class AppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CCM.App.Dominio.Eventos", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("Anotacion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("asunto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("fecha")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.ToTable("Eventos");
                });

            modelBuilder.Entity("CCM.App.Dominio.Persona", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("cedula")
                        .HasColumnType("int");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("personas");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Persona");
                });

            modelBuilder.Entity("CCM.App.Dominio.Usuario", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("Contraseña")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreUsuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("tipoUsuario")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("usuarios");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Usuario");
                });

            modelBuilder.Entity("CCM.App.Dominio.Registro", b =>
                {
                    b.HasBaseType("CCM.App.Dominio.Persona");

                    b.Property<string>("apartamento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("asunto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("fechaDeEntrada")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("fechaDeSalida")
                        .HasColumnType("datetime2");

                    b.HasDiscriminator().HasValue("Registro");
                });

            modelBuilder.Entity("CCM.App.Dominio.Residente", b =>
                {
                    b.HasBaseType("CCM.App.Dominio.Persona");

                    b.Property<string>("apartamento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Residente_apartamento");

                    b.HasDiscriminator().HasValue("Residente");
                });

            modelBuilder.Entity("CCM.App.Dominio.UsuarioHistorial", b =>
                {
                    b.HasBaseType("CCM.App.Dominio.Usuario");

                    b.Property<DateTime>("fecha")
                        .HasColumnType("datetime2");

                    b.HasDiscriminator().HasValue("UsuarioHistorial");
                });

            modelBuilder.Entity("CCM.App.Dominio.RegistroParqueadero", b =>
                {
                    b.HasBaseType("CCM.App.Dominio.Registro");

                    b.Property<string>("observaciones")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("parqueadero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("placa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("RegistroParqueadero");
                });

            modelBuilder.Entity("CCM.App.Dominio.ResidenteCorrespondencia", b =>
                {
                    b.HasBaseType("CCM.App.Dominio.Residente");

                    b.Property<string>("Receptor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Remitente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("asunto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ResidenteCorrespondencia_asunto");

                    b.Property<DateTime>("fecha")
                        .HasColumnType("datetime2");

                    b.HasDiscriminator().HasValue("ResidenteCorrespondencia");
                });
#pragma warning restore 612, 618
        }
    }
}
