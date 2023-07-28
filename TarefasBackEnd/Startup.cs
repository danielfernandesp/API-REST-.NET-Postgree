using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TarefasBackEnd.Repositories;
using Microsoft.EntityFrameworkCore;

namespace TarefasBackEnd
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<DataContext>(options => options.UseInMemoryDatabase("BDTarefas"));
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints( endpoints => 
            {
                endpoints.MapGet("/", async context =>
                
                {
                    await context.Response.WriteAsync("Hello World");
                });
            });
        }
    }
}