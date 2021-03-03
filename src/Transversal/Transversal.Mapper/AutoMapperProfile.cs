using SeidorArchitecture.ECommerce.Domain.Entity;
using SeidorArchitecture.ECommerce.Application.DTO;
using AutoMapper;

namespace SeidorArchitecture.ECommerce.Transversal.Mapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Customer, CustomerDTO>().ReverseMap();
        }
    }
}
