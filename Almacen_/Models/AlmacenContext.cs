using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Almacen_.Models;

public partial class AlmacenContext : DbContext
{
    public AlmacenContext()
    {
    }

    public AlmacenContext(DbContextOptions<AlmacenContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Categorium> Categoria { get; set; }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<DetalleVentum> DetalleVenta { get; set; }

    public virtual DbSet<Entradum> Entrada { get; set; }

    public virtual DbSet<Factura> Facturas { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    public virtual DbSet<PuestoUsuario> PuestoUsuarios { get; set; }

    public virtual DbSet<Reporte> Reportes { get; set; }

    public virtual DbSet<Salidum> Salida { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    public virtual DbSet<Venta> Ventas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=Localhost; Database=Almacen; Trusted_Connection=True; TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Categorium>(entity =>
        {
            entity.HasKey(e => e.CategoriaId);

            entity.Property(e => e.CategoriaId)
                .ValueGeneratedNever()
                .HasColumnName("Categoria_ID");
            entity.Property(e => e.CategoriaDescripcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Categoria_Descripcion");
            entity.Property(e => e.CategoriaNombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Categoria_Nombre");
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.ToTable("Cliente");

            entity.Property(e => e.ClienteId)
                .ValueGeneratedNever()
                .HasColumnName("Cliente_ID");
            entity.Property(e => e.ClienteApellido)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Cliente_Apellido");
            entity.Property(e => e.ClienteCorreo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Cliente_Correo");
            entity.Property(e => e.ClienteDireccion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Cliente_Direccion");
            entity.Property(e => e.ClienteNombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Cliente_Nombre");
            entity.Property(e => e.ClienteTelefono).HasColumnName("Cliente_Telefono");
        });

        modelBuilder.Entity<DetalleVentum>(entity =>
        {
            entity.HasKey(e => e.DetalleVentaId);

            entity.ToTable("Detalle_Venta");

            entity.Property(e => e.DetalleVentaId)
                .ValueGeneratedNever()
                .HasColumnName("Detalle_Venta_ID");
            entity.Property(e => e.ProductoId).HasColumnName("Producto_ID");
            entity.Property(e => e.VentaId).HasColumnName("Venta_ID");
        });

        modelBuilder.Entity<Entradum>(entity =>
        {
            entity.HasKey(e => e.EntradaId);

            entity.Property(e => e.EntradaId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Entrada_ID");
            entity.Property(e => e.EntradaCantidad).HasColumnName("Entrada_Cantidad");
            entity.Property(e => e.EntradaFecha)
                .HasColumnType("datetime")
                .HasColumnName("Entrada_Fecha");
        });

        modelBuilder.Entity<Factura>(entity =>
        {
            entity.Property(e => e.FacturaId)
                .ValueGeneratedNever()
                .HasColumnName("Factura_ID");
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.Property(e => e.ProductoId).HasColumnName("Producto_ID");
            entity.Property(e => e.ProductoDescripcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Producto_Descripcion");
            entity.Property(e => e.ProductoImagen)
                .HasColumnType("image")
                .HasColumnName("Producto_Imagen");
            entity.Property(e => e.ProductoNombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Producto_Nombre");
            entity.Property(e => e.ProductoPrecio).HasColumnName("Producto_Precio");
        });

        modelBuilder.Entity<PuestoUsuario>(entity =>
        {
            entity.HasKey(e => e.PuestoId);

            entity.ToTable("Puesto_Usuario");

            entity.Property(e => e.PuestoId)
                .ValueGeneratedNever()
                .HasColumnName("Puesto_ID");
            entity.Property(e => e.PuestoDescripcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Puesto_Descripcion");
            entity.Property(e => e.PuestoNombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Puesto_Nombre");
        });

        modelBuilder.Entity<Reporte>(entity =>
        {
            entity.Property(e => e.ReporteId)
                .ValueGeneratedNever()
                .HasColumnName("Reporte_ID");
        });

        modelBuilder.Entity<Salidum>(entity =>
        {
            entity.HasKey(e => e.SalidaId);

            entity.Property(e => e.SalidaId)
                .ValueGeneratedNever()
                .HasColumnName("Salida_ID");
            entity.Property(e => e.SalidaCantidad).HasColumnName("Salida_Cantidad");
            entity.Property(e => e.SalidaFecha)
                .HasColumnType("datetime")
                .HasColumnName("Salida_Fecha");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.Property(e => e.UsuarioId)
                .ValueGeneratedNever()
                .HasColumnName("Usuario_ID");
            entity.Property(e => e.UsuarioApellido)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Usuario_Apellido");
            entity.Property(e => e.UsuarioCorreo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Usuario_Correo");
            entity.Property(e => e.UsuarioNombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Usuario_Nombre");
            entity.Property(e => e.UsuarioPassword)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Usuario_Password");
            entity.Property(e => e.UsuarioTelefono).HasColumnName("Usuario_Telefono");
        });

        modelBuilder.Entity<Venta>(entity =>
        {
            entity.Property(e => e.VentaId)
                .ValueGeneratedNever()
                .HasColumnName("Venta_ID");
            entity.Property(e => e.VentaFecha)
                .HasColumnType("datetime")
                .HasColumnName("Venta_Fecha");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
