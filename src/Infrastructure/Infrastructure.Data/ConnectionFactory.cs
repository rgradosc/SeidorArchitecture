using SeidorArchitecture.DigitalB89.Transversal.Common;
using Microsoft.Extensions.Configuration;
using System;
using System.Data;
using System.Data.SqlClient;

namespace SeidorArchitecture.DigitalB89.Infrastructure.Data
{
    public class ConnectionFactory : IConnectionFactory
    {
        private readonly IConfiguration configuration;

        public ConnectionFactory(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public IDbConnection GetDbConnection 
        { 
            get 
            {
                var sqlConnection = new SqlConnection();
                if(sqlConnection == null) { return null; }

                sqlConnection.ConnectionString = configuration.GetConnectionString("DefaultConnection");
                sqlConnection.Open();
                return sqlConnection;
            }
        }
    }
}
