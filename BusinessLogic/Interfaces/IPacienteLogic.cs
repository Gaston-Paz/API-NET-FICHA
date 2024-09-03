using DTOs;
using Entities;

namespace BusinessLogic.Interfaces
{
    public interface IPacienteLogic : IBaseLogic<Paciente,PacienteDTO>
    {
        Task<List<PacienteDTO>> GetAllPacientesSelectorAsync();
        Task<List<PacienteDTO>> GetAllPacientesPaginadoAsync();
    }
}
