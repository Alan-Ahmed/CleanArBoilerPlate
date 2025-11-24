using CleanArchBoilerplate.Application.Common.Interfaces;
using CleanArchBoilerplate.Application.Example.Interfaces;
using CleanArchBoilerplate.Application.Example.Services;
using CleanArchBoilerplate.Infrastructure.Persistence;
using CleanArchBoilerplate.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchBoilerplate.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddDbContext<AppDbContext>(opt =>
            opt.UseInMemoryDatabase("BoilerplateDb"));

        services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        services.AddScoped<IExampleService, ExampleService>();

        return services;
    }
}
