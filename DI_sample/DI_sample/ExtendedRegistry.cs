using Components;
using DI_sample.Controllers;
using EventHandler = Components.EventHandler;

namespace DI_sample
{
    public class ExtendedRegistry
    {
        public static void RegisterModules(IServiceCollection services)
        {
            services.AddScoped<ICustomClass, CustomClass>();
            services.AddTransient<IDummy, Dummy>();
            services.AddTransient<IEventHandler, EventHandler>();
            services.AddTransient<ISimpleEventPublisher, QueuePublisher>();
            services.AddTransient<ISimpleEventPublisher, DbPublisher>();
            services.AddTransient<ISimpleEventPublisher, FolderPublisher>();
            services.AddTransient<ISimpleEventPublisher, ApiPublisher>();
        }
    }
}
