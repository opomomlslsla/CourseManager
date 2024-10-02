namespace Application;

using Mapster;
using Microsoft.Extensions.DependencyInjection;
using FastExpressionCompiler;
using MapsterMapper;
using Application.Services;

public static class ApplicationDI
{
    public static void AddApplicationServices(this IServiceCollection services)
    {
        var config = new TypeAdapterConfig
        {
            Compiler = exp => exp.CompileFast()
        };

        services.AddSingleton(config);

        services.AddScoped<IMapper, ServiceMapper>();
        services.AddScoped<CourseService>();
        services.AddScoped<DisciplineService>();
        services.AddScoped<StudentService>();
        services.AddScoped<TutorService>();
        services.AddScoped<GroupService>();
        
    }
}