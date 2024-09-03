using AutoMapper;
using BusinessLogic.Interfaces;
using DataAccess.Interfaces;
using DTOs;
using Entities;

namespace BusinessLogic.Logics
{
    public class PacienteLogic : BaseLogic<Paciente, PacienteDTO>, IPacienteLogic
    {
        private readonly IPacienteRepository _pacienteRepository;
        private readonly IMapper _mapper;
        public PacienteLogic(IPacienteRepository pacienteRepository, IMapper mapper) : base(pacienteRepository, mapper)
        {
            _pacienteRepository = pacienteRepository;
            _mapper = mapper;
        }

        public async Task<List<PacienteDTO>> GetAllPacientesPaginadoAsync()
        {
            List<Paciente> pacientes = await _pacienteRepository.GetAllPacientesPaginadoAsync();
            return _mapper.Map<List<PacienteDTO>>(pacientes);
        }

        public async Task<List<PacienteDTO>> GetAllPacientesSelectorAsync()
        {
            List<Paciente> pacientes = await _pacienteRepository.GetAllPacientesSelectorAsync();
            return _mapper.Map<List<PacienteDTO>>(pacientes);
        }
    }
}
