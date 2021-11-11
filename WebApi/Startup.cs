using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServiceLayer.Products;
using ServiceLayer.Customers;
using ServiceLayer.Order;
using ServiceLayer.Manufacturer;
using ServiceLayer.Emails;
using System.Net.Mail;

namespace WebApi
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

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "WebApi", Version = "v1" });
            });

            services.AddRazorPages();

            //SMTP
            services.AddScoped(prov => new SmtpClient("127.0.0.1",25));

            services.AddDbContext<Datalayer.AppContext>(options => options.UseSqlServer(Configuration.GetConnectionString("Webshop")));
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IManufacturerService, ManufacturerService>();

            services.AddTransient<IEmailSenderService, EmailSenderService>(s => new EmailSenderService(s.GetRequiredService<SmtpClient>(),"Noreply@shop.dk"));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseWebAssemblyDebugging();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "WebApi v1"));
            }

            app.UseBlazorFrameworkFiles(); // Sørger for at blazor webassembly appen kan loade de frameworks (DLL) den skal bruge for at køre i browseren 

            app.UseStaticFiles(); //loader statiske filer fx billeder fra serveren

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapControllers();
                endpoints.MapFallbackToFile("index.html");  // setter default endpoint til index.html
            });
        }
    }
}
