using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class PacienteDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
        public string Localidad { get; set; } = string.Empty;
        public string Ocupacion { get; set; } = string.Empty;
        public string Celular { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateTime FechaNacimiento { get; set; }
        public string Otros { get; set; } = string.Empty;
        public string DeParteDe { get; set; } = string.Empty;
        public string ComoNacio { get; set; } = string.Empty;
        public byte[] FotoPerfil { get; set; } = new byte[0];

        public ConsultaInicialDTO ConsultaInicial { get; set; } = new ConsultaInicialDTO();
        public AntecedenteDTO Antecedentes { get; set; } = new AntecedenteDTO();
        public List<TratamientoDTO> Tratamientos { get; set; } = new List<TratamientoDTO>();
    }
}
