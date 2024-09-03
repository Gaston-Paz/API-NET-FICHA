using Entities;

namespace DataAccess.Interfaces
{
    public interface IPacienteRepository: IBaseRepository<Paciente>
    {
        Task<List<Paciente>> GetAllPacientesSelectorAsync();
        Task<List<Paciente>> GetAllPacientesPaginadoAsync();
    }
}
