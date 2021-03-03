using SeidorArchitecture.ECommerce.Transversal.Common;
using SeidorArchitecture.ECommerce.Infrastructure.Interfaces;
using SeidorArchitecture.ECommerce.Domain.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;
using Dapper;
using System.Data;

namespace SeidorArchitecture.ECommerce.Infrastructure.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly IConnectionFactory connectionFactory;

        public CustomerRepository(IConnectionFactory connectionFactory)
        {
            this.connectionFactory = connectionFactory;
        }

        public bool Delete(string dni)
        {
            using (var connection = connectionFactory.GetDbConnection)
            {
                var p = new DynamicParameters();
                p.Add("@DNI", dni);

                var result = connection.Execute("dbo.CustomersDelete", param: p, commandType: CommandType.StoredProcedure);

                return result > 0;
            }
        }

        public async Task<bool> DeleteAsync(string dni)
        {
            using (var connection = connectionFactory.GetDbConnection)
            {
                var p = new DynamicParameters();
                p.Add("@DNI", dni);

                var result = await connection.ExecuteAsync("dbo.CustomersDelete", param: p, commandType: CommandType.StoredProcedure);

                return result > 0;
            }
        }

        public Customer Get(string dni)
        {
            using (var connection = connectionFactory.GetDbConnection)
            {
                var p = new DynamicParameters();
                p.Add("@DNI", dni);
                
                var customer = connection.QuerySingle<Customer>("dbo.CustomersGetByDNI", param: p, commandType: CommandType.StoredProcedure);

                return customer;
            }
        }

        public async Task<Customer> GetAsync(string dni)
        {
            using (var connection = connectionFactory.GetDbConnection)
            {
                var p = new DynamicParameters();
                p.Add("@DNI", dni);

                var customer = await connection.QuerySingleAsync<Customer>("dbo.CustomersGetByDNI", param: p, commandType: CommandType.StoredProcedure);

                return customer;
            }
        }

        public IEnumerable<Customer> GetAll()
        {
            using (var connection = connectionFactory.GetDbConnection)
            {

                var customers = connection.Query<Customer>("dbo.CustomersList", commandType: CommandType.StoredProcedure);

                return customers;
            }
        }

        public async Task<IEnumerable<Customer>> GetAllAsync()
        {
            using (var connection = connectionFactory.GetDbConnection)
            {

                var customers = await connection.QueryAsync<Customer>("dbo.CustomersList", commandType: CommandType.StoredProcedure);

                return customers;
            }
        }

        public bool Insert(Customer customer)
        {
            using (var connection = connectionFactory.GetDbConnection)
            {
                var p = new DynamicParameters();
                p.Add("@DNI", customer.DNI);
                p.Add("@Cliente", customer.Cliente);
                p.Add("@FechaNacimiento", customer.FechaNacimiento);
                p.Add("@Saldo", customer.Saldo);
                p.Add("@Puntos", customer.Puntos);
                
                var result = connection.Execute("dbo.CustomersInsert", param: p, commandType: CommandType.StoredProcedure);

                return result > 0;
            }
        }

        public async Task<bool> InsertAsync(Customer customer)
        {
            using (var connection = connectionFactory.GetDbConnection)
            {
                var p = new DynamicParameters();
                p.Add("@DNI", customer.DNI);
                p.Add("@Cliente", customer.Cliente);
                p.Add("@FechaNacimiento", customer.FechaNacimiento);
                p.Add("@Saldo", customer.Saldo);
                p.Add("@Puntos", customer.Puntos);

                var result = await connection.ExecuteAsync("dbo.CustomersInsert", param: p, commandType: CommandType.StoredProcedure);

                return result > 0;
            }
        }

        public bool Update(Customer customer)
        {
            using (var connection = connectionFactory.GetDbConnection)
            {
                var p = new DynamicParameters();
                p.Add("@DNI", customer.DNI);
                p.Add("@Saldo", customer.Saldo);
                p.Add("@Puntos", customer.Puntos);

                var result = connection.Execute("dbo.CustomersUpdate", param: p, commandType: CommandType.StoredProcedure);

                return result > 0;
            }
        }

        public async Task<bool> UpdateAsync(Customer customer)
        {
            using (var connection = connectionFactory.GetDbConnection)
            {
                var p = new DynamicParameters();
                p.Add("@DNI", customer.DNI);
                p.Add("@Cliente", customer.Cliente);
                p.Add("@FechaNacimiento", customer.FechaNacimiento);
                p.Add("@Saldo", customer.Saldo);
                p.Add("@Puntos", customer.Puntos);

                var result = await connection.ExecuteAsync("dbo.CustomersUpdate", param: p, commandType: CommandType.StoredProcedure);

                return result > 0;
            }
        }
    }
}
