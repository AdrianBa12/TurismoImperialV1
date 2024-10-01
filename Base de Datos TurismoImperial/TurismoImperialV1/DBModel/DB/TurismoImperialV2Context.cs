using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DBModel.DB;

public partial class TurismoImperialV2Context : DbContext
{
    public TurismoImperialV2Context()
    {
    }

    public TurismoImperialV2Context(DbContextOptions<TurismoImperialV2Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Agencia> Agencia { get; set; }

    public virtual DbSet<Asiento> Asientos { get; set; }

    public virtual DbSet<Buses> Buses { get; set; }

    public virtual DbSet<Caja> Cajas { get; set; }

    public virtual DbSet<Ciudad> Ciudads { get; set; }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Comprobantes> Comprobantes { get; set; }

    public virtual DbSet<Conductor> Conductors { get; set; }

    public virtual DbSet<DetallesViaje> DetallesViajes { get; set; }

    public virtual DbSet<Empleados> Empleados { get; set; }

    public virtual DbSet<EstadoPago> EstadoPagos { get; set; }

    public virtual DbSet<EstadoReserva> EstadoReservas { get; set; }

    public virtual DbSet<Incidencias> Incidencias { get; set; }

    public virtual DbSet<MantenimientoBuses> MantenimientoBuses { get; set; }

    public virtual DbSet<MetodoPago> MetodoPagos { get; set; }

    public virtual DbSet<Opiniones> Opiniones { get; set; }

    public virtual DbSet<Pagos> Pagos { get; set; }

    public virtual DbSet<Paradas> Paradas { get; set; }

    public virtual DbSet<Pasajero> Pasajeros { get; set; }

    public virtual DbSet<Persona> Personas { get; set; }

    public virtual DbSet<Reserva> Reservas { get; set; }

    public virtual DbSet<ResumenCarrito> ResumenCarritos { get; set; }

    public virtual DbSet<RevisionesBuses> RevisionesBuses { get; set; }

    public virtual DbSet<Roles> Roles { get; set; }

    public virtual DbSet<Rutas> Rutas { get; set; }

    public virtual DbSet<RutasBuses> RutasBuses { get; set; }

    public virtual DbSet<Terminal> Terminals { get; set; }

    public virtual DbSet<TipoDocumento> TipoDocumentos { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    public virtual DbSet<Vehiculo> Vehiculos { get; set; }

    public virtual DbSet<Viajes> Viajes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-PIEF6RR\\MSSQLSERVERDEV2; Initial Catalog=TurismoImperialV2;Integrated Security=True;Trusted_Connection=true;TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Agencia>(entity =>
        {
            entity.HasKey(e => e.IdAgencia).HasName("PK__Agencia__DF8DA369E546D875");

            entity.Property(e => e.IdAgencia).HasColumnName("ID_Agencia");
            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("Created_at");
            entity.Property(e => e.Direccion)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Asiento>(entity =>
        {
            entity.HasKey(e => e.IdAsiento).HasName("PK__Asiento__5A5EB97191B7FF9B");

            entity.ToTable("Asiento");

            entity.Property(e => e.IdAsiento)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ID_Asiento");
            entity.Property(e => e.AsientoReservadoId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AsientoReservado_ID");
            entity.Property(e => e.NumeroAsiento)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Numero_Asiento");
            entity.Property(e => e.NumeroPiso).HasColumnName("Numero_Piso");
            entity.Property(e => e.PrecioPen)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("Precio_PEN");
            entity.Property(e => e.ScheduleId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Schedule_ID");
            entity.Property(e => e.Tarifa)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TipoAsiento)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Tipo_Asiento");
        });

        modelBuilder.Entity<Buses>(entity =>
        {
            entity.HasKey(e => e.IdBuses).HasName("PK__Buses__FB24738045BA161C");

            entity.Property(e => e.IdBuses).HasColumnName("ID_Buses");
            entity.Property(e => e.FechaLlegada)
                .HasPrecision(0)
                .HasColumnName("Fecha_Llegada");
            entity.Property(e => e.FechaSalida)
                .HasPrecision(0)
                .HasColumnName("Fecha_Salida");
            entity.Property(e => e.IdConductor).HasColumnName("ID_Conductor");
            entity.Property(e => e.IdRutas).HasColumnName("ID_Rutas");
            entity.Property(e => e.NumeroAsientos).HasColumnName("Numero_Asientos");
            entity.Property(e => e.PrecioMinimo)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("Precio_Minimo");
            entity.Property(e => e.PrecioPromedio)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("Precio_Promedio");
            entity.Property(e => e.Servicio)
                .HasMaxLength(25)
                .IsUnicode(false);

            entity.HasOne(d => d.IdConductorNavigation).WithMany(p => p.Buses)
                .HasForeignKey(d => d.IdConductor)
                .HasConstraintName("FK__Buses__ID_Conduc__6383C8BA");

            entity.HasOne(d => d.IdRutasNavigation).WithMany(p => p.Buses)
                .HasForeignKey(d => d.IdRutas)
                .HasConstraintName("FK__Buses__ID_Rutas__6477ECF3");
        });

        modelBuilder.Entity<Caja>(entity =>
        {
            entity.HasKey(e => e.IdCaja).HasName("PK__Caja__7217CFD62F53984F");

            entity.ToTable("Caja");

            entity.Property(e => e.IdCaja).HasColumnName("ID_Caja");
            entity.Property(e => e.CierreOptimo)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("Cierre_Optimo");
            entity.Property(e => e.CierreReal)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("Cierre_Real");
            entity.Property(e => e.Codigo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.FechaCreacion)
                .HasPrecision(0)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("Fecha_Creacion");
            entity.Property(e => e.Gastos)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("decimal(10, 2)");
            entity.Property(e => e.IdAgencia).HasColumnName("ID_Agencia");
            entity.Property(e => e.IdTerminal).HasColumnName("ID_Terminal");
            entity.Property(e => e.MontoApertura)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("Monto_Apertura");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(220)
                .IsUnicode(false);

            entity.HasOne(d => d.IdAgenciaNavigation).WithMany(p => p.Cajas)
                .HasForeignKey(d => d.IdAgencia)
                .HasConstraintName("FK__Caja__ID_Agencia__40F9A68C");

            entity.HasOne(d => d.IdTerminalNavigation).WithMany(p => p.Cajas)
                .HasForeignKey(d => d.IdTerminal)
                .HasConstraintName("FK__Caja__ID_Termina__41EDCAC5");
        });

        modelBuilder.Entity<Ciudad>(entity =>
        {
            entity.HasKey(e => e.IdCiudad).HasName("PK__Ciudad__05C00C1C070CE2C6");

            entity.ToTable("Ciudad");

            entity.Property(e => e.IdCiudad).HasColumnName("ID_Ciudad");
            entity.Property(e => e.Codigo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(25)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.IdCliente).HasName("PK__Cliente__E005FBFFCBA66F68");

            entity.ToTable("Cliente");

            entity.Property(e => e.IdCliente).HasColumnName("ID_Cliente");
            entity.Property(e => e.Apellidos)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Direccion)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaCreacion)
                .HasPrecision(0)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("Fecha_Creacion");
            entity.Property(e => e.Nombres)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.NumeroDocumento)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("Numero_documento");
            entity.Property(e => e.RazonSocial)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Razon_Social");
            entity.Property(e => e.Telefono)
                .HasMaxLength(9)
                .IsUnicode(false);
            entity.Property(e => e.TipoDocumento)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Tipo_Documento");
        });

        modelBuilder.Entity<Comprobantes>(entity =>
        {
            entity.HasKey(e => e.IdComprobante).HasName("PK__Comproba__7DE63600B3EC5AC9");

            entity.Property(e => e.IdComprobante).HasColumnName("ID_Comprobante");
            entity.Property(e => e.FechaEmision)
                .HasPrecision(0)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("Fecha_Emision");
            entity.Property(e => e.IdCliente).HasColumnName("ID_Cliente");
            entity.Property(e => e.IdPago).HasColumnName("ID_Pago");
            entity.Property(e => e.MontoTotal)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("Monto_Total");
            entity.Property(e => e.NumeroComprobante)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Numero_Comprobante");
            entity.Property(e => e.TipoComprobante)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Tipo_Comprobante");

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.Comprobantes)
                .HasForeignKey(d => d.IdCliente)
                .HasConstraintName("FK__Comproban__ID_Cl__3B40CD36");

            entity.HasOne(d => d.IdPagoNavigation).WithMany(p => p.Comprobantes)
                .HasForeignKey(d => d.IdPago)
                .HasConstraintName("FK__Comproban__ID_Pa__3C34F16F");
        });

        modelBuilder.Entity<Conductor>(entity =>
        {
            entity.HasKey(e => e.IdConductor).HasName("PK__Conducto__24F451ABB8B95A6E");

            entity.ToTable("Conductor");

            entity.Property(e => e.IdConductor).HasColumnName("ID_Conductor");
            entity.Property(e => e.Apellidos)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EstadoConductor)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Estado_Conductor");
            entity.Property(e => e.FechaContratacion).HasColumnName("Fecha_Contratacion");
            entity.Property(e => e.FechaNacimiento).HasColumnName("Fecha_Nacimiento");
            entity.Property(e => e.FechaRegistro)
                .HasPrecision(0)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("Fecha_Registro");
            entity.Property(e => e.IdVehiculo).HasColumnName("ID_Vehiculo");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.NumeroLicencia)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Numero_Licencia");
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.IdVehiculoNavigation).WithMany(p => p.Conductors)
                .HasForeignKey(d => d.IdVehiculo)
                .HasConstraintName("FK__Conductor__ID_Ve__4BAC3F29");
        });

        modelBuilder.Entity<DetallesViaje>(entity =>
        {
            entity.HasKey(e => e.IdDetallesViaje).HasName("PK__Detalles__1EF28AC3DED83E3A");

            entity.ToTable("DetallesViaje");

            entity.Property(e => e.IdDetallesViaje).HasColumnName("ID_DetallesViaje");
            entity.Property(e => e.DuracionMinima).HasColumnName("Duracion_Minima");
            entity.Property(e => e.DuracionPromedio).HasColumnName("Duracion_Promedio");
            entity.Property(e => e.IdRutasBuses).HasColumnName("ID_RutasBuses");
            entity.Property(e => e.PrecioMinimo)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("Precio_Minimo");
            entity.Property(e => e.PrecioPromedio)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("Precio_Promedio");
            entity.Property(e => e.PrimeraSalida).HasColumnName("Primera_Salida");
            entity.Property(e => e.TerminalLlegadaId).HasColumnName("Terminal_LlegadaID");
            entity.Property(e => e.TerminalSalidaId).HasColumnName("Terminal_SalidaID");
            entity.Property(e => e.UltimaSalida).HasColumnName("Ultima_Salida");

            entity.HasOne(d => d.IdRutasBusesNavigation).WithMany(p => p.DetallesViajes)
                .HasForeignKey(d => d.IdRutasBuses)
                .HasConstraintName("FK__DetallesV__ID_Ru__5EBF139D");

            entity.HasOne(d => d.TerminalLlegada).WithMany(p => p.DetallesViajeTerminalLlegada)
                .HasForeignKey(d => d.TerminalLlegadaId)
                .HasConstraintName("FK__DetallesV__Termi__60A75C0F");

            entity.HasOne(d => d.TerminalSalida).WithMany(p => p.DetallesViajeTerminalSalida)
                .HasForeignKey(d => d.TerminalSalidaId)
                .HasConstraintName("FK__DetallesV__Termi__5FB337D6");
        });

        modelBuilder.Entity<Empleados>(entity =>
        {
            entity.HasKey(e => e.IdEmpleados).HasName("PK__Empleado__EFACC927ADB208F3");

            entity.Property(e => e.IdEmpleados).HasColumnName("ID_Empleados");
            entity.Property(e => e.Apellido)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FechaRegistro)
                .HasPrecision(0)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("Fecha_registro");
            entity.Property(e => e.IdAgencia).HasColumnName("ID_Agencia");
            entity.Property(e => e.IdRol).HasColumnName("ID_Rol");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.IdRolNavigation).WithMany(p => p.Empleados)
                .HasForeignKey(d => d.IdRol)
                .HasConstraintName("FK__Empleados__ID_Ro__208CD6FA");
        });

        modelBuilder.Entity<EstadoPago>(entity =>
        {
            entity.HasKey(e => e.IdEstadoPago).HasName("PK__EstadoPa__3ECA89D50E7FE367");

            entity.ToTable("EstadoPago");

            entity.Property(e => e.IdEstadoPago)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ID_EstadoPago");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EstadoReserva>(entity =>
        {
            entity.HasKey(e => e.IdEstadoReserva).HasName("PK__EstadoRe__2BBAE8FD41F9303A");

            entity.ToTable("EstadoReserva");

            entity.Property(e => e.IdEstadoReserva)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ID_EstadoReserva");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Incidencias>(entity =>
        {
            entity.HasKey(e => e.IncidenciaId).HasName("PK__Incidenc__D0002B7EC90936A5");

            entity.Property(e => e.IncidenciaId).HasColumnName("incidencia_id");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnName("fecha");
            entity.Property(e => e.FechaRegistro)
                .HasPrecision(0)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("Fecha_registro");
            entity.Property(e => e.IdBus).HasColumnName("ID_Bus");
            entity.Property(e => e.IdViaje).HasColumnName("ID_Viaje");

            entity.HasOne(d => d.IdBusNavigation).WithMany(p => p.Incidencia)
                .HasForeignKey(d => d.IdBus)
                .HasConstraintName("FK__Incidenci__ID_Bu__151B244E");

            entity.HasOne(d => d.IdViajeNavigation).WithMany(p => p.Incidencia)
                .HasForeignKey(d => d.IdViaje)
                .HasConstraintName("FK__Incidenci__ID_Vi__160F4887");
        });

        modelBuilder.Entity<MantenimientoBuses>(entity =>
        {
            entity.HasKey(e => e.IdMantenimientoBuses).HasName("PK__Mantenim__BEC93B0190FE1D7D");

            entity.Property(e => e.IdMantenimientoBuses).HasColumnName("ID_MantenimientoBuses");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.FechaMantenimiento).HasColumnName("Fecha_Mantenimiento");
            entity.Property(e => e.FechaRegistro)
                .HasPrecision(0)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("Fecha_registro");
            entity.Property(e => e.IdBus).HasColumnName("ID_Bus");

            entity.HasOne(d => d.IdBusNavigation).WithMany(p => p.MantenimientoBuses)
                .HasForeignKey(d => d.IdBus)
                .HasConstraintName("FK__Mantenimi__ID_Bu__0D7A0286");
        });

        modelBuilder.Entity<MetodoPago>(entity =>
        {
            entity.HasKey(e => e.IdMetodoPago).HasName("PK__MetodoPa__E2BFEC3E7954DB98");

            entity.ToTable("MetodoPago");

            entity.Property(e => e.IdMetodoPago)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ID_MetodoPago");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Opiniones>(entity =>
        {
            entity.HasKey(e => e.IdOpinion).HasName("PK__Opinione__3DD07AB974E315C0");

            entity.Property(e => e.IdOpinion).HasColumnName("ID_opinion");
            entity.Property(e => e.Comentarios)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.FechaOpinion)
                .HasPrecision(0)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("Fecha_opinion");
            entity.Property(e => e.IdRutas).HasColumnName("ID_Rutas");
            entity.Property(e => e.IdUsuario).HasColumnName("ID_usuario");

            entity.HasOne(d => d.IdRutasNavigation).WithMany(p => p.Opiniones)
                .HasForeignKey(d => d.IdRutas)
                .HasConstraintName("FK__Opiniones__ID_Ru__73BA3083");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Opiniones)
                .HasForeignKey(d => d.IdUsuario)
                .HasConstraintName("FK__Opiniones__ID_us__72C60C4A");
        });

        modelBuilder.Entity<Pagos>(entity =>
        {
            entity.HasKey(e => e.IdPagos).HasName("PK__Pagos__ECD14654724161CA");

            entity.Property(e => e.IdPagos).HasColumnName("ID_Pagos");
            entity.Property(e => e.EstadoPagoId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("Estado_PagoID");
            entity.Property(e => e.FechaPago)
                .HasPrecision(0)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("Fecha_pago");
            entity.Property(e => e.IdReserva).HasColumnName("ID_Reserva");
            entity.Property(e => e.MetodoPagoId)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Metodo_PagoID");
            entity.Property(e => e.MontoPagado)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("Monto_pagado");

            entity.HasOne(d => d.EstadoPago).WithMany(p => p.Pagos)
                .HasForeignKey(d => d.EstadoPagoId)
                .HasConstraintName("FK__Pagos__Estado_Pa__30C33EC3");

            entity.HasOne(d => d.IdReservaNavigation).WithMany(p => p.Pagos)
                .HasForeignKey(d => d.IdReserva)
                .HasConstraintName("FK__Pagos__ID_Reserv__2EDAF651");

            entity.HasOne(d => d.MetodoPago).WithMany(p => p.Pagos)
                .HasForeignKey(d => d.MetodoPagoId)
                .HasConstraintName("FK__Pagos__Metodo_Pa__2FCF1A8A");
        });

        modelBuilder.Entity<Paradas>(entity =>
        {
            entity.HasKey(e => e.IdParadas).HasName("PK__Paradas__B7F53DB718E7F6D4");

            entity.Property(e => e.IdParadas).HasColumnName("ID_Paradas");
            entity.Property(e => e.Direccion)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Fecha).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.IdViaje).HasColumnName("ID_Viaje");
            entity.Property(e => e.NombreCiudad)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Pasajero>(entity =>
        {
            entity.HasKey(e => e.IdPasajero).HasName("PK__Pasajero__A3E2FDAC711F3A2D");

            entity.ToTable("Pasajero");

            entity.Property(e => e.IdPasajero).HasColumnName("ID_Pasajero");
            entity.Property(e => e.ApellidoMaterno)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Apellido_Materno");
            entity.Property(e => e.ApellidoPaterno)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Apellido_Paterno");
            entity.Property(e => e.FechaNacimiento).HasColumnName("Fecha_Nacimiento");
            entity.Property(e => e.FechaRegistro)
                .HasPrecision(0)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("Fecha_Registro");
            entity.Property(e => e.Genero)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.IdTipoDocumento)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ID_TipoDocumento");
            entity.Property(e => e.Nacionalidad)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nombres)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.NumeroDocumento)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Numero_Documento");

            entity.HasOne(d => d.IdTipoDocumentoNavigation).WithMany(p => p.Pasajeros)
                .HasForeignKey(d => d.IdTipoDocumento)
                .HasConstraintName("FK__Pasajero__ID_Tip__797309D9");
        });

        modelBuilder.Entity<Persona>(entity =>
        {
            entity.HasKey(e => e.IdPersona).HasName("PK__Persona__E9916EC1CA117B4F");

            entity.ToTable("Persona");

            entity.Property(e => e.IdPersona).HasColumnName("ID_Persona");
            entity.Property(e => e.ApellidoMaterno)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ApellidoPaterno)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Correo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Genero)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.NumeroDocumento)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Numero_Documento");
            entity.Property(e => e.Telefono)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TipoDocumento)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Tipo_Documento");
        });

        modelBuilder.Entity<Reserva>(entity =>
        {
            entity.HasKey(e => e.IdReserva).HasName("PK__Reserva__12CAD9F4830DE09D");

            entity.ToTable("Reserva");

            entity.Property(e => e.IdReserva).HasColumnName("ID_Reserva");
            entity.Property(e => e.CodigoBoleto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Codigo_boleto");
            entity.Property(e => e.EstadoReservaId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("EstadoReserva_ID");
            entity.Property(e => e.FechaReserva)
                .HasPrecision(0)
                .HasColumnName("Fecha_reserva");
            entity.Property(e => e.IdRutas).HasColumnName("ID_Rutas");
            entity.Property(e => e.IdUsuario).HasColumnName("ID_Usuario");
            entity.Property(e => e.NumeroAsientos).HasColumnName("Numero_asientos");
            entity.Property(e => e.PrecioTotal)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("Precio_total");

            entity.HasOne(d => d.EstadoReserva).WithMany(p => p.Reservas)
                .HasForeignKey(d => d.EstadoReservaId)
                .HasConstraintName("FK__Reserva__EstadoR__07C12930");

            entity.HasOne(d => d.IdRutasNavigation).WithMany(p => p.Reservas)
                .HasForeignKey(d => d.IdRutas)
                .HasConstraintName("FK__Reserva__ID_Ruta__06CD04F7");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Reservas)
                .HasForeignKey(d => d.IdUsuario)
                .HasConstraintName("FK__Reserva__ID_Usua__05D8E0BE");
        });

        modelBuilder.Entity<ResumenCarrito>(entity =>
        {
            entity.HasKey(e => e.IdResumenCarrito).HasName("PK__Resumen___1A356E084BDDB095");

            entity.ToTable("Resumen_Carrito");

            entity.Property(e => e.IdResumenCarrito).HasColumnName("ID_ResumenCarrito");
            entity.Property(e => e.PrecioTotalPen)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("Precio_Total_PEN");
            entity.Property(e => e.PrecioTotalUsd)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("Precio_Total_USD");
        });

        modelBuilder.Entity<RevisionesBuses>(entity =>
        {
            entity.HasKey(e => e.IdRevicionesBuses).HasName("PK__Revision__0DB0F02D6A4EB863");

            entity.Property(e => e.IdRevicionesBuses).HasColumnName("ID_RevicionesBuses");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.FechaRegistro)
                .HasPrecision(0)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("Fecha_registro");
            entity.Property(e => e.FechaRevision).HasColumnName("Fecha_Revision");
            entity.Property(e => e.IdBus).HasColumnName("ID_Bus");

            entity.HasOne(d => d.IdBusNavigation).WithMany(p => p.RevisionesBuses)
                .HasForeignKey(d => d.IdBus)
                .HasConstraintName("FK__Revisione__ID_Bu__114A936A");
        });

        modelBuilder.Entity<Roles>(entity =>
        {
            entity.HasKey(e => e.IdRoles).HasName("PK__Roles__30F629935D170F0C");

            entity.HasIndex(e => e.NombreRol, "UQ__Roles__320FDA7D5E59FF1F").IsUnique();

            entity.Property(e => e.IdRoles).HasColumnName("ID_Roles");
            entity.Property(e => e.FechaRegistro)
                .HasPrecision(0)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("Fecha_registro");
            entity.Property(e => e.NombreRol)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nombre_Rol");
        });

        modelBuilder.Entity<Rutas>(entity =>
        {
            entity.HasKey(e => e.IdRutas).HasName("PK__Rutas__E3D47DDE3FA8601F");

            entity.Property(e => e.IdRutas).HasColumnName("ID_Rutas");
            entity.Property(e => e.CiudadDestino)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("Ciudad_Destino");
            entity.Property(e => e.CiudadId)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("Ciudad_ID");
            entity.Property(e => e.CiudadOrigen)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("Ciudad_origen");
            entity.Property(e => e.CiudadSeoId)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("Ciudad_SeoID");
            entity.Property(e => e.DestinoId)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("Destino_ID");
            entity.Property(e => e.DestinoSeoId)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("Destino_SeoID");
        });

        modelBuilder.Entity<RutasBuses>(entity =>
        {
            entity.HasKey(e => e.IdRutasBuses).HasName("PK__RutasBus__0026225AB13EECA4");

            entity.Property(e => e.IdRutasBuses).HasColumnName("ID_RutasBuses");
            entity.Property(e => e.CiudadDestinoId).HasColumnName("Ciudad_DestinoID");
            entity.Property(e => e.CiudadOrigenId).HasColumnName("Ciudad_OrigenID");
            entity.Property(e => e.Destino)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.DistanciaKm).HasColumnName("Distancia_Km");
            entity.Property(e => e.DuracionMin)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Duracion_Min");
            entity.Property(e => e.DuracionPromedio)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Duracion_Promedio");
            entity.Property(e => e.Origen)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.PrecioMinimo)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("Precio_Minimo");
            entity.Property(e => e.PrecioPromedio)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("Precio_Promedio");
            entity.Property(e => e.PrimeraHoraSalida).HasColumnName("PrimeraHora_Salida");
            entity.Property(e => e.TerminalEntrante)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("Terminal_Entrante");
            entity.Property(e => e.TerminalSaliente)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("Terminal_Saliente");
            entity.Property(e => e.TotalBusesDiarios).HasColumnName("TotalBuses_Diarios");
            entity.Property(e => e.UltimaHoraSalida).HasColumnName("UltimaHora_Salida");

            entity.HasOne(d => d.CiudadDestino).WithMany(p => p.RutasBuseCiudadDestinos)
                .HasForeignKey(d => d.CiudadDestinoId)
                .HasConstraintName("FK__RutasBuse__Ciuda__5BE2A6F2");

            entity.HasOne(d => d.CiudadOrigen).WithMany(p => p.RutasBuseCiudadOrigens)
                .HasForeignKey(d => d.CiudadOrigenId)
                .HasConstraintName("FK__RutasBuse__Ciuda__5AEE82B9");
        });

        modelBuilder.Entity<Terminal>(entity =>
        {
            entity.HasKey(e => e.IdTerminal).HasName("PK__Terminal__9EC7D52FCF4CF151");

            entity.ToTable("Terminal");

            entity.Property(e => e.IdTerminal).HasColumnName("ID_Terminal");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("Created_at");
            entity.Property(e => e.Direccion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.IdCiudad).HasColumnName("ID_Ciudad");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("telefono");

            entity.HasOne(d => d.IdCiudadNavigation).WithMany(p => p.Terminals)
                .HasForeignKey(d => d.IdCiudad)
                .HasConstraintName("FK__Terminal__Create__3F466844");
        });

        modelBuilder.Entity<TipoDocumento>(entity =>
        {
            entity.HasKey(e => e.IdTipoDocumento).HasName("PK__TipoDocu__C4F1D09D0D915E82");

            entity.ToTable("TipoDocumento");

            entity.Property(e => e.IdTipoDocumento)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ID_TipoDocumento");
            entity.Property(e => e.NombreDocumento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OperadorId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OperadorID");
            entity.Property(e => e.RegexValidacion)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("PK__Usuario__DE4431C550951933");

            entity.ToTable("Usuario");

            entity.Property(e => e.IdUsuario).HasColumnName("ID_Usuario");
            entity.Property(e => e.Cargo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Contraseña)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.IdPersona).HasColumnName("ID_Persona");
            entity.Property(e => e.Username)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.IdPersonaNavigation).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.IdPersona)
                .HasConstraintName("FK__Usuario__ID_Pers__6EF57B66");
        });

        modelBuilder.Entity<Vehiculo>(entity =>
        {
            entity.HasKey(e => e.IdVehiculo).HasName("PK__Vehiculo__FEFD7E3332AED853");

            entity.ToTable("Vehiculo");

            entity.Property(e => e.IdVehiculo).HasColumnName("ID_Vehiculo");
            entity.Property(e => e.EstadoVehiculo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Estado_Vehiculo");
            entity.Property(e => e.MarcaModelo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Marca_Modelo");
            entity.Property(e => e.Matricula)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.NumeroAsientos).HasColumnName("Numero_Asientos");
        });

        modelBuilder.Entity<Viajes>(entity =>
        {
            entity.HasKey(e => e.IdViajes).HasName("PK__Viajes__4831D8204802C9BA");

            entity.Property(e => e.IdViajes).HasColumnName("ID_Viajes");
            entity.Property(e => e.FechaLlegada)
                .HasPrecision(0)
                .HasColumnName("fecha_llegada");
            entity.Property(e => e.FechaSalida)
                .HasPrecision(0)
                .HasColumnName("fecha_salida");
            entity.Property(e => e.IdBus).HasColumnName("ID_Bus");
            entity.Property(e => e.IdConductor).HasColumnName("ID_Conductor");
            entity.Property(e => e.IdRutas).HasColumnName("ID_Rutas");
            entity.Property(e => e.NumeroAsientos)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("Numero_Asientos");
            entity.Property(e => e.PrecioMinimo)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("Precio_Minimo");
            entity.Property(e => e.Servicio)
                .HasMaxLength(25)
                .IsUnicode(false);

            entity.HasOne(d => d.IdBusNavigation).WithMany(p => p.Viajes)
                .HasForeignKey(d => d.IdBus)
                .HasConstraintName("FK__Viajes__ID_Bus__6754599E");

            entity.HasOne(d => d.IdConductorNavigation).WithMany(p => p.Viajes)
                .HasForeignKey(d => d.IdConductor)
                .HasConstraintName("FK__Viajes__ID_Condu__68487DD7");

            entity.HasOne(d => d.IdRutasNavigation).WithMany(p => p.Viajes)
                .HasForeignKey(d => d.IdRutas)
                .HasConstraintName("FK__Viajes__ID_Rutas__693CA210");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
