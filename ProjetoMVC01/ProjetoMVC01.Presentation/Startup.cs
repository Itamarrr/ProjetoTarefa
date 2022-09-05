using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoMVC01.Presentation
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //definir que o modo de navegação do projeto 
            //web é MVC (Controllers e Views)
            services.AddControllersWithViews();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //habilitar a pasta /wwwroot
            app.UseStaticFiles();

            app.UseRouting();

            //mapeando a página inicial do projeto
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "defolt",
                    pattern: "{controller=Home}/{action=Index}"                                      
                    );
                //endpoints.MapGet("/", async context => itamar tirou para poder ser iniciado atravez da controller HomeControlle
                //{
                //    await context.Response.WriteAsync("Hello World!");
                //});
            });
        }
    }
}
