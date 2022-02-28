using Microsoft.Extensions.DependencyInjection;
using TesteIntegracao.Domain;

namespace TesteIntegracao.UnitTests
{
    public class IntegrationTestFixture
    {
        public IntegrationTestFixture()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddTransient<ICaixa, Caixa>();

            ServiceProvider = serviceCollection.BuildServiceProvider();

        }

        public ServiceProvider ServiceProvider { get; set; }
    }
}
