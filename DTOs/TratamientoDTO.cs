using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class TratamientoDTO
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string Motivo { get; set; } = string.Empty;
        public string TrianguloDeTalla { get; set; } = string.Empty;
        public string AlturaDeIliacos { get; set; } = string.Empty;
        public string Barral { get; set; } = string.Empty;
        public string Esferas { get; set; } = string.Empty;
        public string Especifico { get; set; } = string.Empty;
        public string Sedestacion { get; set; } = string.Empty;
        public DateTime ProximoTurno { get; set; }
        public int IdPaciente { get; set; }
    }
}
