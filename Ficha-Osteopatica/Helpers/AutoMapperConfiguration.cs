using AutoMapper;
using DTOs;
using Entities;

namespace Ficha_Osteopatica.Helpers
{
    public static class AutoMapperConfiguration
    {
        public static void ValidateConfiguration(IServiceProvider serviceProvider)
        {
            var mapper = serviceProvider.GetRequiredService<IMapper>();
            mapper.ConfigurationProvider.AssertConfigurationIsValid();
        }

    }

    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Paciente, PacienteDTO>().ReverseMap();
            CreateMap<Antecedente, AntecedenteDTO>().ReverseMap();
            CreateMap<ConsultaInicial, ConsultaInicialDTO>().ReverseMap();
            CreateMap<Tratamiento, TratamientoDTO>().ReverseMap();
            CreateMap<Usuario, UsuarioDTO>().ReverseMap();
            CreateMap<Rol, RolDTO>().ReverseMap();
        }
    }
}
