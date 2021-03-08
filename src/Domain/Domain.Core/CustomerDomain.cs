using SeidorArchitecture.DigitalB89.Domain.Entity;
using SeidorArchitecture.DigitalB89.Domain.Interfaces;
using SeidorArchitecture.DigitalB89.Infrastructure.Interfaces;
using System.Threading.Tasks;
using System.Collections.Generic;
using System;

namespace SeidorArchitecture.DigitalB89.Domain.Core
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
            var edad = DateTime.Now.Year - customer.FechaNacimiento.Year;

            if (edad <= 40)
            {
                customer.Puntos = 1000;
            }
            else
            {
                customer.Puntos = 100;
            }

            return await repository.InsertAsync(customer);
        }

        public bool Update(Customer customer)
        {
            var customerStored = repository.Get(customer.DNI);

            if (customerStored != null)
            {
                customer.Saldo += customerStored.Saldo;
                customer.Puntos += customerStored.Puntos;

                return repository.Update(customer);
            }

            return false;
        }

        public async Task<bool> UpdateAsync(Customer customer)
        {
            var customerStored = await repository.GetAsync(customer.DNI);

            if (customerStored != null)
            {
                customer.Saldo += customerStored.Saldo;
                customer.Puntos += customerStored.Puntos;

                return await repository.UpdateAsync(customer);
            }

            return false;
        }
    }
}
