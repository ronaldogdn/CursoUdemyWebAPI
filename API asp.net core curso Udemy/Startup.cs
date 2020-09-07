using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_asp.net_core_curso_Udemy.DataBase;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace API_asp.net_core_curso_Udemy
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //add o DbContext para conexão com o banco
            services.AddDbContext<MimicContext>(options =>{
                //Database é o nome da pasta;Mimic é o nome do banco
                options.UseSqlite("Data Source=Database\\Mimic.db");
            });
            //
            services.AddRazorPages();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                //se for possível usa HTTPS
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            //a partir do core 3.0 não se usa mais app.UseMvc para API
            app.UseRouting();
            //mapeamento das rotas
            app.UseEndpoints(endpoint => endpoint.MapControllers());
        }
    }
}
