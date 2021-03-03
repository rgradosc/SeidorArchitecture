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
            CreateMap<Customer, AddCustomerDTO>().ReverseMap();
            CreateMap<CreditCustomerDTO, Customer>()
                .ForMember(x => x.Puntos, options => options.MapFrom(MapAbonoPuntos))
                .ForMember(x => x.Saldo, options => options.MapFrom(y => y.Abono));
        }

        private double MapAbonoPuntos(CreditCustomerDTO creditCustomerDTO, Customer customer)
        {
            if (creditCustomerDTO.Abono >= 1000)
            {
                customer.Puntos = 200;
            }
            else
            {
                customer.Puntos = 50;
            }

            return customer.Puntos;
        }
    }
}
