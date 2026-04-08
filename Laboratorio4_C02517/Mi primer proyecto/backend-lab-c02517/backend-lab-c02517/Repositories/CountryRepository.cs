using backend_lab_c02517.Models;
using Dapper;
using Microsoft.Data.SqlClient; // Lo cambie (en lugar de system) porque me daba error de trust server certificate

namespace backend_lab_c02517.Repositories
{
    public class CountryRepository
    {
        private readonly string _connectionString;

        public CountryRepository()
        {
            var builder = WebApplication.CreateBuilder();
            _connectionString =
              builder.Configuration.GetConnectionString("CountryContext");
        }

        public List<CountryModel> GetCountries()
        {
            using var connection = new SqlConnection(_connectionString); 
            string query = "SELECT * FROM dbo.Country";
            return connection.Query<CountryModel>(query).ToList();
        }
    }
}