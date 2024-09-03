using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class AntecedenteDTO
    {
        public int Id { get; set; }
        public string Cirugias { get; set; } = string.Empty;
        public string Contencion { get; set; } = string.Empty;
        public string ImplanteSuperior { get; set; } = string.Empty;
        public string ImplanteInferior { get; set; } = string.Empty;
        public bool Ortodoncia { get; set; }
        public int EdadOrtodoncia { get; set; }
        public string PiezasFaltantesSuperiores { get; set; } = string.Empty;
        public string PiezasFaltantesInferiores { get; set; } = string.Empty;
        public string PlacaDeDescanso { get; set; } = string.Empty;
        public string Intestinal { get; set; } = string.Empty;
        public string Digestivo { get; set; } = string.Empty;
        public string Cardiaco { get; set; } = string.Empty;
        public string Oseo { get; set; } = string.Empty;
        public string Urogenital { get; set; } = string.Empty;
        public string Respiratorio { get; set; } = string.Empty;
        public string Medicacion { get; set; } = string.Empty;
        public string Otros { get; set; } = string.Empty;
        public string Fracturas { get; set; } = string.Empty;
        public string DolorDeCabeza { get; set; } = string.Empty;
        public string Alimentacion { get; set; } = string.Empty;
        public string Embarazos { get; set; } = string.Empty;
        public string Partos { get; set; } = string.Empty;
        public string AbortosInducidos { get; set; } = string.Empty;
        public string AbortosEspontaneos { get; set; } = string.Empty;
        public string Menstruacion { get; set; } = string.Empty;
        public string Frecuencia { get; set; } = string.Empty;
        public string Duracion { get; set; } = string.Empty;
        public string Protesis { get; set; } = string.Empty;
        public string Volumen { get; set; } = string.Empty;
        public string Fuma { get; set; } = string.Empty;
        public string OtrasDrogas { get; set; } = string.Empty;
        public string Perdidas { get; set; } = string.Empty;
        public string Accidentes { get; set; } = string.Empty;
        public string Diabetes { get; set; } = string.Empty;
        public int IdPaciente { get; set; }
    }
}
