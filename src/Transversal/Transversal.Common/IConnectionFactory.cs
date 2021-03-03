using System.Data;

namespace SeidorArchitecture.ECommerce.Transversal.Common
{
    public interface IConnectionFactory
    {
        IDbConnection GetDbConnection { get; }
    }
}
