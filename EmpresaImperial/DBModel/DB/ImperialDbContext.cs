using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DBModel.DB;

public partial class ImperialDbContext : DbContext
{
    public ImperialDbContext()
    {
    }

    public ImperialDbContext(DbContextOptions<ImperialDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Administradores> Administradores { get; set; }

    public virtual DbSet<Asientos> Asientos { get; set; }

    public virtual DbSet<Boletos> Boletos { get; set; }

    public virtual DbSet<Buses> Buses { get; set; }

    public virtual DbSet<Clientes> Clientes { get; set; }

    public virtual DbSet<Conductores> Conductores { get; set; }

    public virtual DbSet<Descuentos> Descuentos { get; set; }

    public virtual DbSet<Empleados> Empleados { get; set; }

    public virtual DbSet<Estaciones> Estaciones { get; set; }

    public virtual DbSet<Facturacion> Facturacions { get; set; }

    public virtual DbSet<HistorialCambios> HistorialCambios { get; set; }

    public virtual DbSet<HistorialMantenimiento> HistorialMantenimientos { get; set; }

    public virtual DbSet<Horarios> Horarios { get; set; }

    public virtual DbSet<Incidencias> Incidencias { get; set; }

    public virtual DbSet<Itinerarios> Itinerarios { get; set; }

    public virtual DbSet<MantenimientoBuses> MantenimientoBuses { get; set; }

    public virtual DbSet<MetodosPago> MetodosPagos { get; set; }

    public virtual DbSet<Opiniones> Opiniones { get; set; }

    public virtual DbSet<Pagos> Pagos { get; set; }

    public virtual DbSet<Precios> Precios { get; set; }

    public virtual DbSet<Promociones> Promociones { get; set; }

    public virtual DbSet<Reembolsos> Reembolsos { get; set; }

    public virtual DbSet<Reservas> Reservas { get; set; }

    public virtual DbSet<RevisionesBuses> RevisionesBuses { get; set; }

    public virtual DbSet<Roles> Roles { get; set; }

    public virtual DbSet<Rutas> Rutas { get; set; }

    public virtual DbSet<Username> Usernames { get; set; }

    public virtual DbSet<Usuarios> Usuarios { get; set; }

    public virtual DbSet<Vehiculos> Vehiculos { get; set; }

    public virtual DbSet<Viajes> Viajes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-PIEF6RR\\MSSQLSERVERDEV2; Initial Catalog=ImperialDB;Integrated Security=True;Trusted_Connection=true;TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Administradores>(entity =>
        {
            entity.HasKey(e => e.AdministradorId).HasName("PK__Administ__8829A32F16938E20");

            entity.Property(e => e.AdministradorId).HasColumnName("administrador_id");
            entity.Property(e => e.Apellido)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("apellido");
            entity.Property(e => e.FechaRegistro)
                .HasPrecision(0)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("Fecha_registro");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.RolId).HasColumnName("rol_id");

            entity.HasOne(d => d.Rol).WithMany(p => p.Administradores)
                .HasForeignKey(d => d.RolId)
                .HasConstraintName("FK__Administr__rol_i__59C55456");
        });

        modelBuilder.Entity<Asientos>(entity =>
        {
            entity.HasKey(e => e.IdAsiento).HasName("PK__Asientos__6838AB9C2E78507E");

            entity.Property(e => e.IdAsiento).HasColumnName("ID_asiento");
            entity.Property(e => e.EstadoAsiento)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("disponible")
                .HasColumnName("Estado_asiento");
            entity.Property(e => e.IdVehiculo).HasColumnName("ID_vehiculo");
            entity.Property(e => e.NumeroAsiento).HasColumnName("Numero_asiento");

            entity.HasOne(d => d.IdVehiculoNavigation).WithMany(p => p.Asientos)
                .HasForeignKey(d => d.IdVehiculo)
                .HasConstraintName("FK__Asientos__ID_veh__662B2B3B");
        });

        modelBuilder.Entity<Boletos>(entity =>
        {
            entity.HasKey(e => e.IdBoleto).HasName("PK__Boletos__FD4C7504C35CAFBB");

            entity.HasIndex(e => e.CodigoBoleto, "UQ__Boletos__C06C4D4B83E7B270").IsUnique();

            entity.Property(e => e.IdBoleto).HasColumnName("ID_boleto");
            entity.Property(e => e.CodigoBoleto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Codigo_boleto");
            entity.Property(e => e.FechaEmision)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Fecha_emision");
            entity.Property(e => e.IdAsiento).HasColumnName("ID_asiento");
            entity.Property(e => e.IdReserva).HasColumnName("ID_reserva");

            entity.HasOne(d => d.IdReservaNavigation).WithMany(p => p.Boletos)
                .HasForeignKey(d => d.IdReserva)
                .HasConstraintName("FK__Boletos__ID_rese__6AEFE058");
        });

        modelBuilder.Entity<Buses>(entity =>
        {
            entity.HasKey(e => e.BusId).HasName("PK__Buses__6ACEF8ED18E74E1B");

            entity.Property(e => e.BusId).HasColumnName("bus_id");
            entity.Property(e => e.Capacidad).HasColumnName("capacidad");
            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("estado");
            entity.Property(e => e.FechaRegistro)
                .HasPrecision(0)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("Fecha_registro");
            entity.Property(e => e.NumeroBus)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("numero_bus");
        });

        modelBuilder.Entity<Clientes>(entity =>
        {
            entity.HasKey(e => e.ClienteId).HasName("PK__Clientes__47E34D64811C0A78");

            entity.Property(e => e.ClienteId).HasColumnName("cliente_id");
            entity.Property(e => e.Apellido)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("apellido");
            entity.Property(e => e.DocumentoId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("documento_id");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.FechaRegistro)
                .HasPrecision(0)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("Fecha_registro");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("telefono");
        });

        modelBuilder.Entity<Conductores>(entity =>
        {
            entity.HasKey(e => e.IdConductor).HasName("PK__Conducto__CD4093ECADCDDDBB");

            entity.Property(e => e.IdConductor).HasColumnName("ID_conductor");
            entity.Property(e => e.Apellidos)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EstadoConductor)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("activo")
                .HasColumnName("Estado_conductor");
            entity.Property(e => e.FechaContratacion).HasColumnName("Fecha_contratacion");
            entity.Property(e => e.FechaNacimiento).HasColumnName("Fecha_nacimiento");
            entity.Property(e => e.FechaRegistro)
                .HasPrecision(0)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("Fecha_registro");
            entity.Property(e => e.IdVehiculo).HasColumnName("ID_vehiculo");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.NumeroLicencia)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Numero_licencia");
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("telefono");

            entity.HasOne(d => d.IdVehiculoNavigation).WithMany(p => p.Conductores)
                .HasForeignKey(d => d.IdVehiculo)
                .HasConstraintName("FK__Conductor__ID_ve__2EDAF651");
        });

        modelBuilder.Entity<Descuentos>(entity =>
        {
            entity.HasKey(e => e.DescuentoId).HasName("PK__Descuent__21FF5D0674862BD9");

            entity.Property(e => e.DescuentoId).HasColumnName("descuento_id");
            entity.Property(e => e.FechaRegistro)
                .HasPrecision(0)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("Fecha_registro");
            entity.Property(e => e.MontoDescuento)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("monto_descuento");
            entity.Property(e => e.PromocionId).HasColumnName("promocion_id");
            entity.Property(e => e.ReservaId).HasColumnName("reserva_id");

            entity.HasOne(d => d.Promocion).WithMany(p => p.Descuentos)
                .HasForeignKey(d => d.PromocionId)
                .HasConstraintName("FK__Descuento__promo__3587F3E0");

            entity.HasOne(d => d.Reserva).WithMany(p => p.Descuentos)
                .HasForeignKey(d => d.ReservaId)
                .HasConstraintName("FK__Descuento__reser__367C1819");
        });

        modelBuilder.Entity<Empleados>(entity =>
        {
            entity.HasKey(e => e.EmpleadoId).HasName("PK__Empleado__6FBB65FD6117E159");

            entity.Property(e => e.EmpleadoId).HasColumnName("empleado_id");
            entity.Property(e => e.Apellido)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("apellido");
            entity.Property(e => e.FechaRegistro)
                .HasPrecision(0)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("Fecha_registro");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.RolId).HasColumnName("rol_id");

            entity.HasOne(d => d.Rol).WithMany(p => p.Empleados)
                .HasForeignKey(d => d.RolId)
                .HasConstraintName("FK__Empleados__rol_i__55F4C372");
        });

        modelBuilder.Entity<Estaciones>(entity =>
        {
            entity.HasKey(e => e.EstacionId).HasName("PK__Estacion__70998DEB73E00896");

            entity.Property(e => e.EstacionId).HasColumnName("estacion_id");
            entity.Property(e => e.Ciudad)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ciudad");
            entity.Property(e => e.Direccion)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("direccion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Facturacion>(entity =>
        {
            entity.HasKey(e => e.FacturaId).HasName("PK__Facturac__D4782DA05C671BA8");

            entity.ToTable("Facturacion");

            entity.Property(e => e.FacturaId).HasColumnName("factura_id");
            entity.Property(e => e.FechaFactura).HasColumnName("fecha_factura");
            entity.Property(e => e.FechaRegistro)
                .HasPrecision(0)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("Fecha_registro");
            entity.Property(e => e.MontoTotal)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("monto_total");
            entity.Property(e => e.ReservaId).HasColumnName("reserva_id");

            entity.HasOne(d => d.Reserva).WithMany(p => p.Facturacions)
                .HasForeignKey(d => d.ReservaId)
                .HasConstraintName("FK__Facturaci__reser__29221CFB");
        });

        modelBuilder.Entity<HistorialCambios>(entity =>
        {
            entity.HasKey(e => e.IdCambio).HasName("PK__Historia__BA5B7A6A6F3E3DE2");

            entity.Property(e => e.IdCambio).HasColumnName("ID_cambio");
            entity.Property(e => e.CambioDescripcion)
                .HasColumnType("text")
                .HasColumnName("Cambio_descripcion");
            entity.Property(e => e.FechaCambio)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Fecha_cambio");
            entity.Property(e => e.IdReserva).HasColumnName("ID_reserva");

            entity.HasOne(d => d.IdReservaNavigation).WithMany(p => p.HistorialCambios)
                .HasForeignKey(d => d.IdReserva)
                .HasConstraintName("FK__Historial__ID_re__7A3223E8");
        });

        modelBuilder.Entity<HistorialMantenimiento>(entity =>
        {
            entity.HasKey(e => e.IdMantenimiento).HasName("PK__Historia__B1E454517D7D4064");

            entity.ToTable("HistorialMantenimiento");

            entity.Property(e => e.IdMantenimiento).HasColumnName("ID_mantenimiento");
            entity.Property(e => e.Costo).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Descripcion).HasColumnType("text");
            entity.Property(e => e.FechaMantenimiento).HasColumnName("Fecha_mantenimiento");
            entity.Property(e => e.IdVehiculo).HasColumnName("ID_vehiculo");

            entity.HasOne(d => d.IdVehiculoNavigation).WithMany(p => p.HistorialMantenimientos)
                .HasForeignKey(d => d.IdVehiculo)
                .HasConstraintName("FK__Historial__ID_ve__02C769E9");
        });

        modelBuilder.Entity<Horarios>(entity =>
        {
            entity.HasKey(e => e.HorarioId).HasName("PK__Horarios__5A38722814C883B9");

            entity.Property(e => e.HorarioId).HasColumnName("horario_id");
            entity.Property(e => e.HorarioLlegada).HasColumnName("horario_llegada");
            entity.Property(e => e.HorarioSalida).HasColumnName("horario_salida");
            entity.Property(e => e.ViajeId).HasColumnName("viaje_id");

            entity.HasOne(d => d.Viaje).WithMany(p => p.Horarios)
                .HasForeignKey(d => d.ViajeId)
                .HasConstraintName("FK__Horarios__viaje___6166761E");
        });

        modelBuilder.Entity<Incidencias>(entity =>
        {
            entity.HasKey(e => e.IncidenciaId).HasName("PK__Incidenc__D0002B7ED0FF9DB2");

            entity.Property(e => e.IncidenciaId).HasColumnName("incidencia_id");
            entity.Property(e => e.BusId).HasColumnName("bus_id");
            entity.Property(e => e.Descripcion)
                .HasColumnType("text")
                .HasColumnName("descripcion");
            entity.Property(e => e.Fecha).HasColumnName("fecha");
            entity.Property(e => e.FechaRegistro)
                .HasPrecision(0)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("Fecha_registro");
            entity.Property(e => e.ViajeId).HasColumnName("viaje_id");

            entity.HasOne(d => d.Bus).WithMany(p => p.Incidencia)
                .HasForeignKey(d => d.BusId)
                .HasConstraintName("FK__Incidenci__bus_i__51300E55");

            entity.HasOne(d => d.Viaje).WithMany(p => p.Incidencia)
                .HasForeignKey(d => d.ViajeId)
                .HasConstraintName("FK__Incidenci__viaje__5224328E");
        });

        modelBuilder.Entity<Itinerarios>(entity =>
        {
            entity.HasKey(e => e.IdItinerario).HasName("PK__Itinerar__A361D2A4A7A4C305");

            entity.Property(e => e.IdItinerario).HasColumnName("ID_itinerario");
            entity.Property(e => e.HoraLlegada).HasColumnName("Hora_llegada");
            entity.Property(e => e.HoraSalida).HasColumnName("Hora_salida");
            entity.Property(e => e.IdEstacion).HasColumnName("ID_estacion");
            entity.Property(e => e.IdRuta).HasColumnName("ID_ruta");
            entity.Property(e => e.OrdenParada).HasColumnName("Orden_parada");

            entity.HasOne(d => d.IdEstacionNavigation).WithMany(p => p.Itinerarios)
                .HasForeignKey(d => d.IdEstacion)
                .HasConstraintName("FK__Itinerari__ID_es__5E8A0973");

            entity.HasOne(d => d.IdRutaNavigation).WithMany(p => p.Itinerarios)
                .HasForeignKey(d => d.IdRuta)
                .HasConstraintName("FK__Itinerari__ID_ru__5D95E53A");
        });

        modelBuilder.Entity<MantenimientoBuses>(entity =>
        {
            entity.HasKey(e => e.MantenimientoId).HasName("PK__Mantenim__520AB65144186D00");

            entity.ToTable("Mantenimiento_Buses");

            entity.Property(e => e.MantenimientoId).HasColumnName("mantenimiento_id");
            entity.Property(e => e.BusId).HasColumnName("bus_id");
            entity.Property(e => e.Descripcion)
                .HasColumnType("text")
                .HasColumnName("descripcion");
            entity.Property(e => e.FechaMantenimiento).HasColumnName("fecha_mantenimiento");
            entity.Property(e => e.FechaRegistro)
                .HasPrecision(0)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("Fecha_registro");

            entity.HasOne(d => d.Bus).WithMany(p => p.MantenimientoBuses)
                .HasForeignKey(d => d.BusId)
                .HasConstraintName("FK__Mantenimi__bus_i__498EEC8D");
        });

        modelBuilder.Entity<MetodosPago>(entity =>
        {
            entity.HasKey(e => e.IdMetodoPago).HasName("PK__MetodosP__317DAC302122FE3C");

            entity.ToTable("MetodosPago");

            entity.Property(e => e.IdMetodoPago).HasColumnName("ID_metodo_pago");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.NombreMetodo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Nombre_metodo");
        });

        modelBuilder.Entity<Opiniones>(entity =>
        {
            entity.HasKey(e => e.IdOpinion).HasName("PK__Opinione__3DD07AB9AD95AF54");

            entity.Property(e => e.IdOpinion).HasColumnName("ID_opinion");
            entity.Property(e => e.Comentarios).HasColumnType("text");
            entity.Property(e => e.FechaOpinion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Fecha_opinion");
            entity.Property(e => e.IdRuta).HasColumnName("ID_ruta");
            entity.Property(e => e.IdUsuario).HasColumnName("ID_usuario");

            entity.HasOne(d => d.IdRutaNavigation).WithMany(p => p.Opiniones)
                .HasForeignKey(d => d.IdRuta)
                .HasConstraintName("FK__Opiniones__ID_ru__7FEAFD3E");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Opiniones)
                .HasForeignKey(d => d.IdUsuario)
                .HasConstraintName("FK__Opiniones__ID_us__7EF6D905");
        });

        modelBuilder.Entity<Pagos>(entity =>
        {
            entity.HasKey(e => e.IdTransaccion).HasName("PK__Pagos__38112794432A78BB");

            entity.Property(e => e.IdTransaccion).HasColumnName("ID_transaccion");
            entity.Property(e => e.EstadoPago)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("pendiente")
                .HasColumnName("Estado_pago");
            entity.Property(e => e.FechaPago)
                .HasPrecision(0)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("Fecha_pago");
            entity.Property(e => e.IdReserva).HasColumnName("ID_reserva");
            entity.Property(e => e.MetodoPago)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Metodo_pago");
            entity.Property(e => e.MontoPagado)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("Monto_pagado");

            entity.HasOne(d => d.IdReservaNavigation).WithMany(p => p.Pagos)
                .HasForeignKey(d => d.IdReserva)
                .HasConstraintName("FK__Pagos__ID_reserv__719CDDE7");
        });

        modelBuilder.Entity<Precios>(entity =>
        {
            entity.HasKey(e => e.PrecioId).HasName("PK__Precios__AFD61C2EF6AB159C");

            entity.Property(e => e.PrecioId).HasColumnName("precio_id");
            entity.Property(e => e.Clase)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("clase");
            entity.Property(e => e.FechaVigencia).HasColumnName("fecha_vigencia");
            entity.Property(e => e.Monto)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("monto");
            entity.Property(e => e.RutaId).HasColumnName("ruta_id");

            entity.HasOne(d => d.Ruta).WithMany(p => p.Precios)
                .HasForeignKey(d => d.RutaId)
                .HasConstraintName("FK__Precios__ruta_id__74794A92");
        });

        modelBuilder.Entity<Promociones>(entity =>
        {
            entity.HasKey(e => e.IdPromocion).HasName("PK__Promocio__F5B42359AF123D2E");

            entity.HasIndex(e => e.CodigoDescuento, "UQ__Promocio__84CF6815751C3FF4").IsUnique();

            entity.Property(e => e.IdPromocion).HasColumnName("ID_promocion");
            entity.Property(e => e.CodigoDescuento)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Codigo_descuento");
            entity.Property(e => e.Descripcion).HasColumnType("text");
            entity.Property(e => e.FechaFin).HasColumnName("Fecha_fin");
            entity.Property(e => e.FechaInicio).HasColumnName("Fecha_inicio");
            entity.Property(e => e.MontoDescuento)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("Monto_descuento");
        });

        modelBuilder.Entity<Reembolsos>(entity =>
        {
            entity.HasKey(e => e.ReembolsoId).HasName("PK__Reembols__5EF9B438D61CAECC");

            entity.Property(e => e.ReembolsoId).HasColumnName("reembolso_id");
            entity.Property(e => e.FechaReembolso).HasColumnName("fecha_reembolso");
            entity.Property(e => e.FechaRegistro)
                .HasPrecision(0)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("Fecha_registro");
            entity.Property(e => e.Monto)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("monto");
            entity.Property(e => e.ReservaId).HasColumnName("reserva_id");

            entity.HasOne(d => d.Reserva).WithMany(p => p.Reembolsos)
                .HasForeignKey(d => d.ReservaId)
                .HasConstraintName("FK__Reembolso__reser__3F115E1A");
        });

        modelBuilder.Entity<Reservas>(entity =>
        {
            entity.HasKey(e => e.IdReserva).HasName("PK__Reservas__CD692CB063AAFD44");

            entity.Property(e => e.IdReserva).HasColumnName("ID_reserva");
            entity.Property(e => e.CodigoBoleto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Codigo_boleto");
            entity.Property(e => e.EstadoReserva)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("pendiente")
                .HasColumnName("Estado_reserva");
            entity.Property(e => e.FechaReserva)
                .HasPrecision(0)
                .HasColumnName("Fecha_reserva");
            entity.Property(e => e.IdRuta).HasColumnName("ID_ruta");
            entity.Property(e => e.IdUsuario).HasColumnName("ID_usuario");
            entity.Property(e => e.NumeroAsientos).HasColumnName("Numero_asientos");
            entity.Property(e => e.PrecioTotal)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("Precio_total");

            entity.HasOne(d => d.IdRutaNavigation).WithMany(p => p.Reservas)
                .HasForeignKey(d => d.IdRuta)
                .HasConstraintName("FK__Reservas__ID_rut__2180FB33");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Reservas)
                .HasForeignKey(d => d.IdUsuario)
                .HasConstraintName("FK__Reservas__ID_usu__208CD6FA");
        });

        modelBuilder.Entity<RevisionesBuses>(entity =>
        {
            entity.HasKey(e => e.RevisionId).HasName("PK__Revision__03BAF005FB1A3749");

            entity.ToTable("Revisiones_Buses");

            entity.Property(e => e.RevisionId).HasColumnName("revision_id");
            entity.Property(e => e.BusId).HasColumnName("bus_id");
            entity.Property(e => e.Descripcion)
                .HasColumnType("text")
                .HasColumnName("descripcion");
            entity.Property(e => e.FechaRegistro)
                .HasPrecision(0)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("Fecha_registro");
            entity.Property(e => e.FechaRevision).HasColumnName("fecha_revision");

            entity.HasOne(d => d.Bus).WithMany(p => p.RevisionesBuses)
                .HasForeignKey(d => d.BusId)
                .HasConstraintName("FK__Revisione__bus_i__4D5F7D71");
        });

        modelBuilder.Entity<Roles>(entity =>
        {
            entity.HasKey(e => e.IdRol).HasName("PK__Roles__182A5412C8E91CC1");

            entity.HasIndex(e => e.NombreRol, "UQ__Roles__3A0AF653105D2374").IsUnique();

            entity.Property(e => e.IdRol).HasColumnName("ID_rol");
            entity.Property(e => e.NombreRol)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nombre_rol");
        });

        modelBuilder.Entity<Rutas>(entity =>
        {
            entity.HasKey(e => e.IdRuta).HasName("PK__Rutas__7A91FD5A31CE5776");

            entity.Property(e => e.IdRuta).HasColumnName("ID_ruta");
            entity.Property(e => e.DisponibilidadAsientos).HasColumnName("Disponibilidad_asientos");
            entity.Property(e => e.DuracionEstimada).HasColumnName("Duracion_estimada");
            entity.Property(e => e.HorarioLlegada).HasColumnName("Horario_llegada");
            entity.Property(e => e.HorarioSalida).HasColumnName("Horario_salida");
            entity.Property(e => e.IdEstacionDestino).HasColumnName("ID_estacion_destino");
            entity.Property(e => e.IdEstacionOrigen).HasColumnName("ID_estacion_origen");
            entity.Property(e => e.PrecioBase)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("Precio_base");

            entity.HasOne(d => d.IdEstacionDestinoNavigation).WithMany(p => p.RutaIdEstacionDestinoNavigations)
                .HasForeignKey(d => d.IdEstacionDestino)
                .HasConstraintName("FK__Rutas__ID_estaci__1BC821DD");

            entity.HasOne(d => d.IdEstacionOrigenNavigation).WithMany(p => p.RutaIdEstacionOrigenNavigations)
                .HasForeignKey(d => d.IdEstacionOrigen)
                .HasConstraintName("FK__Rutas__ID_estaci__1AD3FDA4");
        });

        modelBuilder.Entity<Username>(entity =>
        {
            entity.HasKey(e => e.IdUsername).HasName("PK__username__5ABA01FB11C7F539");

            entity.ToTable("username");

            entity.Property(e => e.IdUsername).HasColumnName("id_username");
            entity.Property(e => e.Apellidos)
                .IsUnicode(false)
                .HasColumnName("apellidos");
            entity.Property(e => e.Contraseña)
                .IsUnicode(false)
                .HasColumnName("contraseña");
            entity.Property(e => e.Email)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.FechaRegistro)
                .HasPrecision(0)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("Fecha_registro");
            entity.Property(e => e.Nombres)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nombres");
            entity.Property(e => e.Usuario)
                .IsUnicode(false)
                .HasColumnName("usuario");
        });

        modelBuilder.Entity<Usuarios>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("PK__Usuarios__DF3D425233E75D92");

            entity.HasIndex(e => e.CorreoElectronico, "UQ__Usuarios__E0991C1BD5F6E4A2").IsUnique();

            entity.Property(e => e.IdUsuario).HasColumnName("ID_usuario");
            entity.Property(e => e.Apellidos)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Contrasena)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CorreoElectronico)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Correo_electronico");
            entity.Property(e => e.Direccion)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.FechaRegistro)
                .HasPrecision(0)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("Fecha_registro");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TipoUsuario)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("cliente")
                .HasColumnName("Tipo_usuario");

            entity.HasMany(d => d.IdRols).WithMany(p => p.IdUsuarios)
                .UsingEntity<Dictionary<string, object>>(
                    "UsuarioRole",
                    r => r.HasOne<Roles>().WithMany()
                        .HasForeignKey("IdRol")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__UsuarioRo__ID_ro__46B27FE2"),
                    l => l.HasOne<Usuarios>().WithMany()
                        .HasForeignKey("IdUsuario")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__UsuarioRo__ID_us__45BE5BA9"),
                    j =>
                    {
                        j.HasKey("IdUsuario", "IdRol").HasName("PK__UsuarioR__EEBFE7131C54C2BF");
                        j.ToTable("UsuarioRoles");
                        j.IndexerProperty<int>("IdUsuario").HasColumnName("ID_usuario");
                        j.IndexerProperty<int>("IdRol").HasColumnName("ID_rol");
                    });
        });

        modelBuilder.Entity<Vehiculos>(entity =>
        {
            entity.HasKey(e => e.IdVehiculo).HasName("PK__Vehiculo__EE94FC4DC99B1B96");

            entity.Property(e => e.IdVehiculo).HasColumnName("ID_vehiculo");
            entity.Property(e => e.EstadoVehiculo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("disponible")
                .HasColumnName("Estado_vehiculo");
            entity.Property(e => e.MarcaModelo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Marca_modelo");
            entity.Property(e => e.Matricula)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.NumeroAsientos).HasColumnName("Numero_asientos");
            entity.Property(e => e.TipoVehiculo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Tipo_vehiculo");
        });

        modelBuilder.Entity<Viajes>(entity =>
        {
            entity.HasKey(e => e.ViajeId).HasName("PK__Viajes__96EF3CD3E5F70D4F");

            entity.Property(e => e.ViajeId).HasColumnName("viaje_id");
            entity.Property(e => e.BusId).HasColumnName("bus_id");
            entity.Property(e => e.ConductorId).HasColumnName("conductor_id");
            entity.Property(e => e.FechaLlegada)
                .HasColumnType("datetime")
                .HasColumnName("fecha_llegada");
            entity.Property(e => e.FechaSalida)
                .HasColumnType("datetime")
                .HasColumnName("fecha_salida");
            entity.Property(e => e.RutaId).HasColumnName("ruta_id");

            entity.HasOne(d => d.Bus).WithMany(p => p.Viajes)
                .HasForeignKey(d => d.BusId)
                .HasConstraintName("FK__Viajes__bus_id__3A4CA8FD");

            entity.HasOne(d => d.Conductor).WithMany(p => p.Viajes)
                .HasForeignKey(d => d.ConductorId)
                .HasConstraintName("FK__Viajes__conducto__3B40CD36");

            entity.HasOne(d => d.Ruta).WithMany(p => p.Viajes)
                .HasForeignKey(d => d.RutaId)
                .HasConstraintName("FK__Viajes__ruta_id__3C34F16F");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
