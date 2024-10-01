using AutoMapper;
using DBModel.DB;

using Models.RequestResponse;


namespace UtilMapper
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
        
            CreateMap<Agencia, AgenciaRequest>().ReverseMap();
            CreateMap<Agencia, AgenciaResponse>().ReverseMap();

            CreateMap<Asiento, AsientoRequest>().ReverseMap();
            CreateMap<Asiento, AsientoResponse>().ReverseMap();

            CreateMap<Buses, BusesRequest>().ReverseMap();
            CreateMap<Buses, BusesResponse>().ReverseMap();

            CreateMap<Caja, CajaRequest>().ReverseMap();
            CreateMap<Caja,CajaResponse>().ReverseMap();

			CreateMap<Ciudad, CiudadRequest>().ReverseMap();
			CreateMap<Ciudad, CiudadResponse>().ReverseMap();

			CreateMap<Cliente, ClienteRequest>().ReverseMap();
			CreateMap<Cliente, ClienteResponse>().ReverseMap();

			CreateMap<Comprobantes, ComprobantesRequest>().ReverseMap();
			CreateMap<Comprobantes, ComprobantesResponse>().ReverseMap();

			CreateMap<Conductor, ConductorRequest>().ReverseMap();
			CreateMap<Conductor, ConductorResponse>().ReverseMap();

			CreateMap<DetallesViaje, DetallesViajeRequest>().ReverseMap();
			CreateMap<DetallesViaje, DetallesViajeResponse>().ReverseMap();

			CreateMap<Empleados, EmpleadosRequest>().ReverseMap();
			CreateMap<Empleados, EmpleadosResponse>().ReverseMap();

			CreateMap<EstadoPago, EstadoPagoRequest>().ReverseMap();
			CreateMap<EstadoPago, EstadoPagoResponse>().ReverseMap();

			CreateMap<EstadoReserva, EstadoReservaRequest>().ReverseMap();
			CreateMap<EstadoReserva, EstadoReservaResponse>().ReverseMap();

			CreateMap<Incidencias, IncidenciasRequest>().ReverseMap();
			CreateMap<Incidencias, IncidenciasResponse>().ReverseMap();

			CreateMap<MantenimientoBuses, MantenimientoBusesRequest>().ReverseMap();
			CreateMap<MantenimientoBuses, MantenimientoBusesResponse>().ReverseMap();

			CreateMap<MetodoPago, MetodoPagoRequest>().ReverseMap();
			CreateMap<MetodoPago, MetodoPagoResponse>().ReverseMap();

			CreateMap<Opiniones, OpinionesRequest>().ReverseMap();
			CreateMap<Opiniones, OpinionesResponse>().ReverseMap();

			CreateMap<Pagos, PagosRequest>().ReverseMap();
			CreateMap<Pagos, PagosResponse>().ReverseMap();

			CreateMap<Paradas, ParadasRequest>().ReverseMap();
			CreateMap<Paradas, ParadasResponse>().ReverseMap();

			CreateMap<Pasajero, PasajeroRequest>().ReverseMap();
			CreateMap<Pasajero, PasajeroResponse>().ReverseMap();

			CreateMap<Persona, PersonaRequest>().ReverseMap();
			CreateMap<Persona, PersonaResponse>().ReverseMap();

			CreateMap<Reserva, ReservaRequest>().ReverseMap();
			CreateMap<Reserva, ReservaResponse>().ReverseMap();

			CreateMap<ResumenCarrito, ResumenCarritoRequest>().ReverseMap();
			CreateMap<ResumenCarrito, ResumenCarritoResponse>().ReverseMap();

			CreateMap<RevisionesBuses, RevisionesBusesRequest>().ReverseMap();
            CreateMap<RevisionesBuses, RevisionesBusesResponse>().ReverseMap();

			CreateMap<Roles, RolesRequest>().ReverseMap();
			CreateMap<Roles, RolesResponse>().ReverseMap();

			CreateMap<Rutas, RutasRequest>().ReverseMap();
            CreateMap<Rutas, RutasResponse>().ReverseMap();

			CreateMap<RutasBuses, RutasBusesRequest>().ReverseMap();
			CreateMap<RutasBuses, RutasBusesResponse>().ReverseMap();

			CreateMap<Terminal, TerminalRequest>().ReverseMap();
            CreateMap<Terminal, TerminalResponse>().ReverseMap();

            CreateMap<TipoDocumento, TipoDocumentoRequest>().ReverseMap();
            CreateMap<TipoDocumento, TipoDocumentoResponse>().ReverseMap();

			CreateMap<Usuario, UsuarioRequest>().ReverseMap();
			CreateMap<Usuario, UsuarioResponse>().ReverseMap();

			CreateMap<Vehiculo, VehiculoRequest>().ReverseMap();
            CreateMap<Vehiculo, VehiculoResponse>().ReverseMap();

			CreateMap<Viajes, ViajesRequest>().ReverseMap();
			CreateMap<Viajes, ViajesResponse>().ReverseMap();
			CreateMap<ViajesRequest, ViajesResponse>().ReverseMap();
			CreateMap<GenericFilterResponse<ViajesResponse>, GenericFilterResponse<Viajes>>().ReverseMap();
		}

    }
}
