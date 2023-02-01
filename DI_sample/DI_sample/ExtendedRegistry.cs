using DI_sample.Controllers;

namespace DI_sample
{
    public class ExtendedRegistry
    {
        public static void RegisterModules(IServiceCollection services)
        {
            services.AddScoped<ICustomClass, CustomClass>();
            services.AddTransient<IDummy, Dummy>();
        }
    }
}
