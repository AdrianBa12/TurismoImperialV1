using AutoMapper;
using DBModel.DB;
using Models.RequestResponse;

namespace UtilMapper
{
	public class AutoMapperProfiles : Profile
	{
		public AutoMapperProfiles()
		{

			CreateMap<Buses, BusesRequest>().ReverseMap();
			CreateMap<Buses, BusesResponse>().ReverseMap();


		}
	}
}
