
namespace Entities
{
    public class Paciente
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

        public ConsultaInicial ConsultaInicial { get; set; } = new ConsultaInicial();
        public Antecedente Antecedentes { get; set; } = new Antecedente();
        public List<Tratamiento> Tratamientos { get; set; } = new List<Tratamiento>();

    }
}
