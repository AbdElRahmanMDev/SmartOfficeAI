using FluentValidation;
using Mapster;
using MapsterMapper;
using SharpGrip.FluentValidation.AutoValidation.Mvc.Extensions;
using SmartOfficeAI.Features.Common;
using SmartOfficeAI.Persistance;
using SmartOfficeAI.Persistance.Data;
using System.Reflection;

namespace SmartOfficeAI
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddSmartOfficeAIServices(this IServiceCollection services, string connectionString)
        {


            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

            // 2️⃣ Register Mapster
            var config = TypeAdapterConfig.GlobalSettings;
            config.Scan(Assembly.GetExecutingAssembly());
            services.AddSingleton(config);
            services.AddScoped<IMapper, ServiceMapper>();

            // 3️⃣ Register FluentValidation
            services.AddFluentValidationAutoValidation();
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            services.AddScoped<RequestHandlerBaseParameters>();

            services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(connectionString));

            services.AddScoped(typeof(Repository<>));

            return services;
        }
    }
}
