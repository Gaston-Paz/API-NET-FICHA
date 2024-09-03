
using BusinessLogic.Interfaces;
using BusinessLogic.Logics;
using DataAccess;
using DataAccess.Interfaces;
using DataAccess.Repositories;

namespace Ficha_Osteopatica.Helpers
{
    public static class InjectServices
    {
        public static IServiceCollection InjectRepositories(this IServiceCollection services)
        {
            services.AddScoped<IPacienteRepository, PacienteRepository>();

            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));

            return services;
        }

        public static IServiceCollection InjectLogics(this IServiceCollection services)
        {
            services.AddScoped<IPacienteLogic, PacienteLogic>();

            services.AddScoped(typeof(IBaseLogic<,>), typeof(BaseLogic<,>));

            return services;
        }

        public static IServiceCollection InjectDB(this IServiceCollection services)
        {
            services.AddScoped<DapperDataContext>();

            return services;
        }

        public static IServiceCollection InjectAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(config =>
            {
                config.AddProfile<MappingProfile>();
                // Puedes añadir más perfiles aquí si los tienes
            });

            return services;
        }
    }
}
