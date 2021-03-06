﻿using SeidorArchitecture.DigitalB89.Application.DTO;
using SeidorArchitecture.DigitalB89.Transversal.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SeidorArchitecture.DigitalB89.Application.Interfaces
{
    public interface ICustomerApplication
    {
        #region Metodos sincronos

        Response<bool> Insert(AddCustomerDTO addCustomerDTO);

        Response<bool> Update(CreditCustomerDTO creditCustomerDTO);

        Response<bool> Delete(string dni);

        Response<CustomerDTO> Get(string dni);

        Response<IEnumerable<CustomerDTO>> GetAll();

        #endregion

        #region Metodos asincronos

        Task<Response<bool>> InsertAsync(AddCustomerDTO addCustomerDTO);

        Task<Response<bool>> UpdateAsync(CreditCustomerDTO creditCustomerDTO);

        Task<Response<bool>> DeleteAsync(string dni);

        Task<Response<CustomerDTO>> GetAsync(string dni);

        Task<Response<IEnumerable<CustomerDTO>>> GetAllAsync();

        #endregion
    }
}
