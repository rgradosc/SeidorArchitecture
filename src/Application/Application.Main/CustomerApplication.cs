using SeidorArchitecture.DigitalB89.Application.DTO;
using SeidorArchitecture.DigitalB89.Application.Interfaces;
using SeidorArchitecture.DigitalB89.Domain.Entity;
using SeidorArchitecture.DigitalB89.Domain.Interfaces;
using SeidorArchitecture.DigitalB89.Transversal.Common;
using AutoMapper;
using System.Threading.Tasks;
using System.Collections.Generic;
using System;

namespace SeidorArchitecture.DigitalB89.Application.Main
{
    public class CustomerApplication : ICustomerApplication
    {
        private readonly ICustomerDomain domain;
        private readonly IMapper mapper;

        public CustomerApplication(ICustomerDomain domain,IMapper mapper)
        {
            this.domain = domain;
            this.mapper = mapper;
        }

        public Response<CustomerDTO> Get(string dni)
        {
            var response = new Response<CustomerDTO>();

            try
            {
                var customer = domain.Get(dni);
                response.Data = mapper.Map<CustomerDTO>(customer);

                if (response.Data != null)
                {
                    response.IsSuccess = true;
                    response.Message = "Consulta exitosa";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }

        public Response<IEnumerable<CustomerDTO>> GetAll()
        {
            var response = new Response<IEnumerable<CustomerDTO>>();

            try
            {
                var customers = domain.GetAll();
                response.Data = mapper.Map<IEnumerable<CustomerDTO>>(customers);

                if (response.Data != null)
                {
                    response.IsSuccess = true;
                    response.Message = "Consulta exitosa";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }

        public Response<bool> Insert(AddCustomerDTO addCustomerDTO)
        {
            var response = new Response<bool>();

            try
            {
                var customer = mapper.Map<Customer>(addCustomerDTO);
                response.Data = domain.Insert(customer);

                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Registro exitoso";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }

        public Response<bool> Update(CreditCustomerDTO creditCustomerDTO)
        {
            var response = new Response<bool>();

            try
            {
                var customer = mapper.Map<Customer>(creditCustomerDTO);
                response.Data = domain.Update(customer);

                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Actualizacíón exitosa";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }

        public Response<bool> Delete(string dni)
        {
            var response = new Response<bool>();

            try
            {
                response.Data = domain.Delete(dni);

                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Eliminación exitosa";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }

        public async Task<Response<CustomerDTO>> GetAsync(string dni)
        {
            var response = new Response<CustomerDTO>();

            try
            {
                var customer = await domain.GetAsync(dni);
                response.Data = mapper.Map<CustomerDTO>(customer);

                if (response.Data != null)
                {
                    response.IsSuccess = true;
                    response.Message = "Consulta exitosa";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }

        public async Task<Response<IEnumerable<CustomerDTO>>> GetAllAsync()
        {
            var response = new Response<IEnumerable<CustomerDTO>>();

            try
            {
                var customers = await domain.GetAllAsync();
                response.Data = mapper.Map<IEnumerable<CustomerDTO>>(customers);

                if (response.Data != null)
                {
                    response.IsSuccess = true;
                    response.Message = "Consulta exitosa";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }

        public async Task<Response<bool>> InsertAsync(AddCustomerDTO addCustomerDTO)
        {
            var response = new Response<bool>();

            try
            {
                var customer = mapper.Map<Customer>(addCustomerDTO);
                response.Data = await domain.InsertAsync(customer);

                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Registro exitoso";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }

        public async Task<Response<bool>> UpdateAsync(CreditCustomerDTO creditCustomerDTO)
        {
            var response = new Response<bool>();

            try
            {
                var customer = mapper.Map<Customer>(creditCustomerDTO);
                response.Data = await domain.UpdateAsync(customer);

                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Actualizacíón exitosa";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }

        public async Task<Response<bool>> DeleteAsync(string dni)
        {
            var response = new Response<bool>();

            try
            {
                response.Data = await domain.DeleteAsync(dni);

                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Eliminación exitosa";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }

    }
}
