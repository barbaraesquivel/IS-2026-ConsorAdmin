using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Consorcio> Consorcios { get; set; }

    public virtual DbSet<Consorcistum> Consorcista { get; set; }

    public virtual DbSet<Expensa> Expensas { get; set; }

    public virtual DbSet<LogBitacora> LogBitacoras { get; set; }

    public virtual DbSet<Pago> Pagos { get; set; }

    public virtual DbSet<Permiso> Permisos { get; set; }

    public virtual DbSet<Proveedor> Proveedors { get; set; }

    public virtual DbSet<Servicio> Servicios { get; set; }

    public virtual DbSet<Unidad> Unidads { get; set; }

    public virtual DbSet<UnidadConsorcistum> UnidadConsorcista { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    public virtual DbSet<UsuarioPermiso> UsuarioPermisos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer(DBConfigurations.getDbConectionString());
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Consorcio>(entity =>
        {
            entity.HasKey(e => e.IdConsorcio);

            entity.ToTable("CONSORCIO");

            entity.Property(e => e.IdConsorcio)
                .HasMaxLength(20)
                .HasColumnName("id_consorcio");
            entity.Property(e => e.CantUnidades).HasColumnName("cant_unidades");
            entity.Property(e => e.Direccion)
                .HasMaxLength(300)
                .HasColumnName("direccion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(200)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Consorcistum>(entity =>
        {
            entity.HasKey(e => e.IdConsorcista);

            entity.ToTable("CONSORCISTA");

            entity.HasIndex(e => e.IdUsuario, "UQ_CONSORCISTA_usuario").IsUnique();

            entity.Property(e => e.IdConsorcista)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("id_consorcista");
            entity.Property(e => e.Dni)
                .HasMaxLength(20)
                .HasColumnName("dni");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.Telefono)
                .HasMaxLength(30)
                .HasColumnName("telefono");

            entity.HasOne(d => d.IdUsuarioNavigation).WithOne(p => p.Consorcistum)
                .HasForeignKey<Consorcistum>(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CONSORCISTA_USUARIO");
        });

        modelBuilder.Entity<Expensa>(entity =>
        {
            entity.HasKey(e => e.IdExpensa);

            entity.ToTable("EXPENSA");

            entity.Property(e => e.IdExpensa)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("id_expensa");
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .HasDefaultValue("Pendiente")
                .HasColumnName("estado");
            entity.Property(e => e.IdUnidad).HasColumnName("id_unidad");
            entity.Property(e => e.Monto)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("monto");
            entity.Property(e => e.Periodo)
                .HasMaxLength(7)
                .HasColumnName("periodo");
            entity.Property(e => e.Vencimiento).HasColumnName("vencimiento");

            entity.HasOne(d => d.IdUnidadNavigation).WithMany(p => p.Expensas)
                .HasForeignKey(d => d.IdUnidad)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EXPENSA_UNIDAD");
        });

        modelBuilder.Entity<LogBitacora>(entity =>
        {
            entity.HasKey(e => e.IdLog);

            entity.ToTable("LOG_BITACORA");

            entity.Property(e => e.IdLog).HasColumnName("id_log");
            entity.Property(e => e.Accion)
                .HasMaxLength(200)
                .HasColumnName("accion");
            entity.Property(e => e.Detalle).HasColumnName("detalle");
            entity.Property(e => e.FechaHora)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fecha_hora");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.Modulo)
                .HasMaxLength(100)
                .HasColumnName("modulo");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.LogBitacoras)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LOG_USUARIO");
        });

        modelBuilder.Entity<Pago>(entity =>
        {
            entity.HasKey(e => e.IdPago);

            entity.ToTable("PAGO");

            entity.Property(e => e.IdPago)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("id_pago");
            entity.Property(e => e.Fecha).HasColumnName("fecha");
            entity.Property(e => e.IdExpensa).HasColumnName("id_expensa");
            entity.Property(e => e.MedioPago)
                .HasMaxLength(100)
                .HasColumnName("medio_pago");
            entity.Property(e => e.Monto)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("monto");
            entity.Property(e => e.NroComprobante)
                .HasMaxLength(100)
                .HasColumnName("nro_comprobante");

            entity.HasOne(d => d.IdExpensaNavigation).WithMany(p => p.Pagos)
                .HasForeignKey(d => d.IdExpensa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PAGO_EXPENSA");
        });

        modelBuilder.Entity<Permiso>(entity =>
        {
            entity.HasKey(e => e.IdPermiso);

            entity.ToTable("PERMISO");

            entity.HasIndex(e => e.Codigo, "UQ_PERMISO_codigo").IsUnique();

            entity.Property(e => e.IdPermiso).HasColumnName("id_permiso");
            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .HasColumnName("codigo");
            entity.Property(e => e.Nombre)
                .HasMaxLength(200)
                .HasColumnName("nombre");
            entity.Property(e => e.Tipo)
                .HasMaxLength(20)
                .HasColumnName("tipo");
        });

        modelBuilder.Entity<Proveedor>(entity =>
        {
            entity.HasKey(e => e.IdProveedor);

            entity.ToTable("PROVEEDOR");

            entity.HasIndex(e => e.Cuit, "UQ_PROVEEDOR_cuit").IsUnique();

            entity.HasIndex(e => e.IdUsuario, "UQ_PROVEEDOR_usuario").IsUnique();

            entity.Property(e => e.IdProveedor)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("id_proveedor");
            entity.Property(e => e.Cuit)
                .HasMaxLength(20)
                .HasColumnName("cuit");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.Rubro)
                .HasMaxLength(100)
                .HasColumnName("rubro");

            entity.HasOne(d => d.IdUsuarioNavigation).WithOne(p => p.Proveedor)
                .HasForeignKey<Proveedor>(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PROVEEDOR_USUARIO");
        });

        modelBuilder.Entity<Servicio>(entity =>
        {
            entity.HasKey(e => e.IdServicio);

            entity.ToTable("SERVICIO");

            entity.Property(e => e.IdServicio)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("id_servicio");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .HasColumnName("descripcion");
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .HasDefaultValue("Pendiente")
                .HasColumnName("estado");
            entity.Property(e => e.Factura)
                .HasMaxLength(300)
                .HasColumnName("factura");
            entity.Property(e => e.Fecha).HasColumnName("fecha");
            entity.Property(e => e.IdConsorcio)
                .HasMaxLength(20)
                .HasColumnName("id_consorcio");
            entity.Property(e => e.IdProveedor).HasColumnName("id_proveedor");
            entity.Property(e => e.Monto)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("monto");

            entity.HasOne(d => d.IdConsorcioNavigation).WithMany(p => p.Servicios)
                .HasForeignKey(d => d.IdConsorcio)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SERVICIO_CONSORCIO");

            entity.HasOne(d => d.IdProveedorNavigation).WithMany(p => p.Servicios)
                .HasForeignKey(d => d.IdProveedor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SERVICIO_PROVEEDOR");
        });

        modelBuilder.Entity<Unidad>(entity =>
        {
            entity.HasKey(e => e.IdUnidad);

            entity.ToTable("UNIDAD");

            entity.Property(e => e.IdUnidad).HasColumnName("id_unidad");
            entity.Property(e => e.Depto)
                .HasMaxLength(10)
                .HasColumnName("depto");
            entity.Property(e => e.IdConsorcio)
                .HasMaxLength(20)
                .HasColumnName("id_consorcio");
            entity.Property(e => e.Piso)
                .HasMaxLength(10)
                .HasColumnName("piso");
            entity.Property(e => e.Superficie)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("superficie");

            entity.HasOne(d => d.IdConsorcioNavigation).WithMany(p => p.Unidads)
                .HasForeignKey(d => d.IdConsorcio)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UNIDAD_CONSORCIO");
        });

        modelBuilder.Entity<UnidadConsorcistum>(entity =>
        {
            entity.HasKey(e => e.IdUnidadConsorcista);

            entity.ToTable("UNIDAD_CONSORCISTA");

            entity.Property(e => e.IdUnidadConsorcista).HasColumnName("id_unidad_consorcista");
            entity.Property(e => e.IdConsorcista).HasColumnName("id_consorcista");
            entity.Property(e => e.IdUnidad).HasColumnName("id_unidad");
            entity.Property(e => e.TipoVinculo)
                .HasMaxLength(50)
                .HasColumnName("tipo_vinculo");

            entity.HasOne(d => d.IdConsorcistaNavigation).WithMany(p => p.UnidadConsorcista)
                .HasForeignKey(d => d.IdConsorcista)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UC_CONSORCISTA");

            entity.HasOne(d => d.IdUnidadNavigation).WithMany(p => p.UnidadConsorcista)
                .HasForeignKey(d => d.IdUnidad)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UC_UNIDAD");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario);

            entity.ToTable("USUARIO");

            entity.HasIndex(e => e.Username, "UQ_USUARIO_username").IsUnique();

            entity.Property(e => e.IdUsuario)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("id_usuario");
            entity.Property(e => e.Activo)
                .HasDefaultValue(true)
                .HasColumnName("activo");
            entity.Property(e => e.PasswordHash)
                .HasMaxLength(255)
                .HasColumnName("password_hash");
            entity.Property(e => e.Bloqueado)
                .HasMaxLength(50)
                .HasColumnName("Bloqueado");
            entity.Property(e => e.TipoUsuario)
                .HasMaxLength(50)
                .HasColumnName("tipo_usuario");
            entity.Property(e => e.Username)
                .HasMaxLength(100)
                .HasColumnName("username");
        });

        modelBuilder.Entity<UsuarioPermiso>(entity =>
        {
            entity.HasKey(e => e.IdUsuarioPermiso);

            entity.ToTable("USUARIO_PERMISO");

            entity.Property(e => e.IdUsuarioPermiso).HasColumnName("id_usuario_permiso");
            entity.Property(e => e.IdPermiso).HasColumnName("id_permiso");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

            entity.HasOne(d => d.IdPermisoNavigation).WithMany(p => p.UsuarioPermisos)
                .HasForeignKey(d => d.IdPermiso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UP_PERMISO");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.UsuarioPermisos)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UP_USUARIO");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
