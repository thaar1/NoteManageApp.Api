using Microsoft.Extensions.DependencyInjection;
using NoteManagementApp.Appliction.Interfaces;
using NoteManagementApp.Infrastructure.Repositories;


namespace NoteManagementApp.Appliction 
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<INoteRepository, NoteRepository>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            return services;
        }
    }
}
