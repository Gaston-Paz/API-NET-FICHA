using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class ConsultaInicialDTO
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string Motivo { get; set; } = string.Empty;
        public string Otros { get; set; } = string.Empty;
        public string Antiguedad { get; set; } = string.Empty;
        public string Localizacion { get; set; } = string.Empty;
        public string Intensidad { get; set; } = string.Empty;
        public string Caracteristica { get; set; } = string.Empty;
        public string Irradiacion { get; set; } = string.Empty;
        public string Atenua { get; set; } = string.Empty;
        public string ActividadFisica { get; set; } = string.Empty;
        public bool Covid { get; set; }
        public DateTime FechaCovid { get; set; }
        public int IdPaciente { get; set; }
    }
}
