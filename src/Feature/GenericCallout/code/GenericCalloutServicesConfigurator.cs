using Feature.GenericCallout.Controllers;
using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;

namespace Feature.GenericCallout
{
    public class GenericCalloutServicesConfigurator : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient(typeof(GenericCalloutController));
            serviceCollection.AddTransient(typeof(GenericCalloutApiController));
        }
    }
}