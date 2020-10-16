using MassTransit;
using MassTransit.ExtensionsDependencyInjectionIntegration;
using MassTransit.Platform.Abstractions;
using Microsoft.Extensions.DependencyInjection;

namespace Library.OnPlatform
{
    public class LibraryStartup : IPlatformStartup
    {
        public void ConfigureMassTransit(IServiceCollectionBusConfigurator configurator, IServiceCollection services)
        {
            services.AddSingleton<LibraryService>();
            configurator.AddConsumer<BorrowBookConsumer>();
        }

        public void ConfigureBus<TEndpointConfigurator>(IBusFactoryConfigurator<TEndpointConfigurator> configurator,
            IBusRegistrationContext context) where TEndpointConfigurator : IReceiveEndpointConfigurator
        {
        }
    }
}