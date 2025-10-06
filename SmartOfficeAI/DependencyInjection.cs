namespace SmartOfficeAI
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddSmartOfficeAI(this IServiceCollection services)
        {
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
            return services;
        }
    }
}
