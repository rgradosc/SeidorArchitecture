using System.Data;

namespace SeidorArchitecture.DigitalB89.Transversal.Common
{
    public interface IConnectionFactory
    {
        IDbConnection GetDbConnection { get; }
    }
}
