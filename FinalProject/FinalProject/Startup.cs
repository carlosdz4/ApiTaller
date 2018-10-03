using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Persistence;
using Services;
using Models;
using Services.Interfaces;
using NSwag.AspNetCore;
using System.Reflection;
using NJsonSchema;

namespace FinalProject
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            
            services.AddDbContext<FinalProjectDbContext>(options => {
                options.UseSqlServer("Server=DESKTOP-R0METLD\\SQLEXPRESS;Initial Catalog=FinalProject;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                });
            services.AddScoped<ICrudService<Empleado>, EmpleadoServices>();
            services.AddScoped<ICrudService<Area_Reparacion>, Area_ReparacionServices>();
            services.AddScoped<ICrudService<Cita>, CitaServices>();
            services.AddScoped<ICrudService<Cliente>, ClienteServices>();
            services.AddScoped<ICrudService<Departamentos>, DepartamentosServices>();
            services.AddScoped<ICrudService<Empleado_Atiende>, Empleado_AtiendeServices>();
            services.AddScoped<ICrudService<Factura>, FacturaService>();
            services.AddScoped<ICrudService<Mantenimiento>, MantenimientoServices>();
            services.AddScoped<ICrudService<Mecanicos>, MecanicosServices>();
            services.AddScoped<ICrudService<Vehiculo>, VehiculoServices>();



            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }
            app.UseSwaggerUi3(typeof(Startup).GetTypeInfo().Assembly, settings =>
            {
                settings.GeneratorSettings.DefaultPropertyNameHandling =
                    PropertyNameHandling.CamelCase;
            });
            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
