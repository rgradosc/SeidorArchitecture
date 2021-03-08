using SeidorArchitecture.DigitalB89.Domain.Entity;
using SeidorArchitecture.DigitalB89.Application.DTO;
using AutoMapper;

namespace SeidorArchitecture.DigitalB89.Transversal.Mapper
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
