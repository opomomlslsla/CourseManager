using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Data;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public static class InfrastrucureDI
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services,
            IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnectionString");

            services.AddDbContext<Context>(options =>
            {
                options.UseSqlServer(connectionString, builder =>
                {
                    builder.EnableRetryOnFailure(5, TimeSpan.FromSeconds(10), null);
                });

            });

            services.AddScoped<IRepository<Course>, CourseRepository>();
            services.AddScoped<IRepository<Disciplline>, DisciplineRepository>();
            services.AddScoped<IRepository<Group>,GroupRepository>();
            services.AddScoped<IRepository<Tutor>, TutorRepository>();
            services.AddScoped<IRepository<Student>, StudentRepository>();

            return services;
        }
    }
}
