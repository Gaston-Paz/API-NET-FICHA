using Dapper;
using DataAccess.Interfaces;
using Entities;

namespace DataAccess.Repositories
{
    public class PacienteRepository: BaseRepository<Paciente>, IPacienteRepository
    {
        const string _tableName = "Pacientes";
        public PacienteRepository(DapperDataContext dapperDataContext) : base(dapperDataContext, _tableName)
        {

        }

        public async Task<List<Paciente>> GetAllPacientesAsync()
        {
            var response = await GetDbConnection().QueryAsync<Paciente>(GetAllCommand);
            return response.ToList();
        }

        public async Task<List<Paciente>> GetAllPacientesPaginadoAsync()
        {
            var response = await GetDbConnection().QueryAsync<Paciente>("Paginado");
            return response.ToList();
        }

        public async Task<List<Paciente>> GetAllPacientesSelectorAsync()
        {
            var response = await GetDbConnection().QueryAsync<Paciente>("Selector");
            return response.ToList();
        }
    }
}
