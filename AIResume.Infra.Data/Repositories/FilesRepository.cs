using AIResume.Domain.Dto.Configuration;
using AIResume.Domain.Interface;
using Dapper;
using System.Data.SqlClient;

namespace AIResume.Infra.Data.Repositories
{
    public class FilesRepository : IFilesRepository
    {
        private readonly ApplicationConfig _applicationConfig;
        public FilesRepository(ApplicationConfig applicationConfig) 
        {
            _applicationConfig = applicationConfig;   
        }

        public void Exemplo()
        {
            using var connection = new SqlConnection(_applicationConfig.ConnectionString);
            var response = connection.Query("select * from teste");
        }
    }
}
