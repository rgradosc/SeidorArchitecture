using SeidorArchitecture.ECommerce.Domain.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SeidorArchitecture.ECommerce.Infrastructure.Interfaces
{
    public interface ICustomerRepository
    {
        #region Metodos sincronos

        bool Insert(Customer customer);

        bool Update(Customer customer);

        bool Delete(string dni);

        Customer Get(string dni);

        IEnumerable<Customer> GetAll();

        #endregion

        #region Metodos asincronos
        Task<bool> InsertAsync(Customer customer);

        Task<bool> UpdateAsync(Customer customer);

        Task<bool> DeleteAsync(string dni);

        Task<Customer> GetAsync(string dni);

        Task<IEnumerable<Customer>> GetAllAsync();

        #endregion
    }
}
