using SeidorArchitecture.ECommerce.Domain.Entity;
using SeidorArchitecture.ECommerce.Domain.Interfaces;
using SeidorArchitecture.ECommerce.Infrastructure.Interfaces;
using System.Threading.Tasks;
using System.Collections.Generic;
using System;

namespace SeidorArchitecture.ECommerce.Domain.Core
{
    public class CustomerDomain : ICustomerDomain
    {
        private readonly ICustomerRepository repository;

        public CustomerDomain(ICustomerRepository repository)
        {
            this.repository = repository;
        }

        public bool Delete(string customerId)
        {
            return repository.Delete(customerId);
        }

        public async Task<bool> DeleteAsync(string customerId)
        {
            return await repository.DeleteAsync(customerId);
        }

        public Customer Get(string customerId)
        {
            return repository.Get(customerId);
        }

        public IEnumerable<Customer> GetAll()
        {
            return repository.GetAll();
        }

        public async Task<IEnumerable<Customer>> GetAllAsync()
        {
            return await repository.GetAllAsync();
        }

        public async Task<Customer> GetAsync(string customerId)
        {
            return await repository.GetAsync(customerId);
        }

        public bool Insert(Customer customer)
        {
            var edad = DateTime.Now.Year - customer.FechaNacimiento.Year;

            if (edad <= 40)
            {
                customer.Puntos = 1000;
            }
            else
            {
                customer.Puntos = 100;
            }

            return repository.Insert(customer);
        }

        public async Task<bool> InsertAsync(Customer customer)
        {
            return await repository.InsertAsync(customer);
        }

        public bool Update(Customer customer)
        {
            return repository.Update(customer);
        }

        public async Task<bool> UpdateAsync(Customer customer)
        {
            return await repository.UpdateAsync(customer);
        }
    }
}
