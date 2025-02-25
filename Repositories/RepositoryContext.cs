using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Repositories
{
    public class RepositoryContext
    {
        private readonly string _connectionString;

        public RepositoryContext()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["PharmacyDB"].ConnectionString;
        }

        public IDbConnection CreateConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}