using Ecommerce.Entidades;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Ecommerce.Datos
{
    public partial class EcommerceContext : DbContext
    {
        public EcommerceContext()
            : base("name=EcommerceConnection")
        {
        }

        public virtual DbSet<ARTICULOS> ARTICULOS { get; set; }
        public virtual DbSet<CARRITOS> CARRITOS { get; set; }
        public virtual DbSet<CATEGORIAS> CATEGORIAS { get; set; }
        public virtual DbSet<CLIENTES> CLIENTES { get; set; }
        public virtual DbSet<DOMICILIOS> DOMICILIOS { get; set; }
        public virtual DbSet<MARCAS> MARCAS { get; set; }
        public virtual DbSet<TALLES> TALLES { get; set; }
        public virtual DbSet<USUARIOS> USUARIOS { get; set; }
        public virtual DbSet<VENTAS> VENTAS { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ARTICULOS>()
                .Property(e => e.CODIGO)
                .IsUnicode(false);

            modelBuilder.Entity<ARTICULOS>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<ARTICULOS>()
                .Property(e => e.DESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<ARTICULOS>()
                .Property(e => e.PRECIO)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ARTICULOS>()
                .Property(e => e.IMG_URL)
                .IsUnicode(false);

            modelBuilder.Entity<ARTICULOS>()
                .Property(e => e.IMG_URL2)
                .IsUnicode(false);

            modelBuilder.Entity<ARTICULOS>()
                .HasMany(e => e.CARRITOS)
                .WithRequired(e => e.ARTICULOS)
                .HasForeignKey(e => e.ID_ARTICULO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CATEGORIAS>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<CATEGORIAS>()
                .HasMany(e => e.ARTICULOS)
                .WithOptional(e => e.CATEGORIAS)
                .HasForeignKey(e => e.ID_CATEGORIA);

            modelBuilder.Entity<CLIENTES>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTES>()
                .Property(e => e.APELLIDO)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTES>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTES>()
                .Property(e => e.TELEFONO)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTES>()
                .HasMany(e => e.VENTAS)
                .WithOptional(e => e.CLIENTES)
                .HasForeignKey(e => e.ID_CLIENTE);

            modelBuilder.Entity<DOMICILIOS>()
                .Property(e => e.CALLE)
                .IsUnicode(false);

            modelBuilder.Entity<DOMICILIOS>()
                .Property(e => e.NUMERO)
                .IsUnicode(false);

            modelBuilder.Entity<DOMICILIOS>()
                .Property(e => e.PROVINCIA)
                .IsUnicode(false);

            modelBuilder.Entity<DOMICILIOS>()
                .HasMany(e => e.CLIENTES)
                .WithRequired(e => e.DOMICILIOS)
                .HasForeignKey(e => e.ID_DOMICILIO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DOMICILIOS>()
                .HasMany(e => e.USUARIOS)
                .WithOptional(e => e.DOMICILIOS)
                .HasForeignKey(e => e.ID_DOMICILIO);

            modelBuilder.Entity<MARCAS>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<MARCAS>()
                .HasMany(e => e.ARTICULOS)
                .WithOptional(e => e.MARCAS)
                .HasForeignKey(e => e.ID_MARCA);

            modelBuilder.Entity<TALLES>()
                .Property(e => e.MEDIDA)
                .IsUnicode(false);

            modelBuilder.Entity<TALLES>()
                .HasMany(e => e.ARTICULOS)
                .WithOptional(e => e.TALLES)
                .HasForeignKey(e => e.ID_TALLE);

            modelBuilder.Entity<USUARIOS>()
                .Property(e => e.USERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<USUARIOS>()
                .Property(e => e.PASSWORD)
                .IsUnicode(false);

            modelBuilder.Entity<USUARIOS>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<USUARIOS>()
                .Property(e => e.APELLIDO)
                .IsUnicode(false);

            modelBuilder.Entity<USUARIOS>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<USUARIOS>()
                .Property(e => e.TELEFONO)
                .IsUnicode(false);

            modelBuilder.Entity<USUARIOS>()
                .HasMany(e => e.VENTAS)
                .WithOptional(e => e.USUARIOS)
                .HasForeignKey(e => e.ID_USUARIO);

            modelBuilder.Entity<VENTAS>()
                .Property(e => e.FORMA)
                .IsUnicode(false);

            modelBuilder.Entity<VENTAS>()
                .Property(e => e.MONTO)
                .HasPrecision(19, 4);

            modelBuilder.Entity<VENTAS>()
                .HasMany(e => e.CARRITOS)
                .WithRequired(e => e.VENTAS)
                .HasForeignKey(e => e.ID_VENTA)
                .WillCascadeOnDelete(false);
        }
    }
}
