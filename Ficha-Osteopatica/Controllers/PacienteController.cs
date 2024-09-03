using Microsoft.AspNetCore.Mvc;
using BusinessLogic.Interfaces;
using DTOs;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PacienteController : ControllerBase
    {

        private readonly ILogger<PacienteController> _logger;
        private IPacienteLogic _pacienteLogic;

        public PacienteController(
            ILogger<PacienteController> logger, 
            IPacienteLogic pacienteLogic
            )
        {
            _logger = logger;
            _pacienteLogic = pacienteLogic;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllPacientes()
        {
            string _errorMessage = "No se pudo obtener el listado de pacientes";
            try
            {
                List<PacienteDTO> pacientes = await _pacienteLogic.GetAllAsync();
                return Ok(pacientes); // Devuelve 200 OK con el listado de pacientes
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new
                {
                    Message = _errorMessage,
                    Exception = ex
                });
            }
        }



    }

}
