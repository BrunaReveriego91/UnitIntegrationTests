using Microsoft.AspNetCore.Mvc;
using TesteIntegracao.Domain;

namespace API
{
    public class StartupApiTests
    {
        public StartupApiTests(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<ICaixa, Caixa>();
            services.AddMvc(options => options.EnableEndpointRouting = false);
            //OR
            services.AddControllers(options => options.EnableEndpointRouting = false);
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        public void Configure(IApplicationBuilder app, Microsoft.AspNetCore.Hosting.IHostingEnvironment env)
        {
            app.UseMvc();
        }

    }
}
