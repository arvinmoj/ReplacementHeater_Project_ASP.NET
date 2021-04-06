using Models;
using Validator;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using FluentValidation.AspNetCore;
using FluentValidation;

namespace My_Application
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
            services.AddControllersWithViews()
               .AddRazorRuntimeCompilation()
               .AddFluentValidation();

            #region Fluent Validation
            services.AddTransient<IValidator<Installer>, InstallerValidation>();
            services.AddTransient<IValidator<LegalPerson>, LegalPersonValidation>();
            services.AddTransient<IValidator<NaturalPerson>, NaturalPersonValidation>();
            services.AddTransient<IValidator<ReplacementHeater>, ReplacementHeaterValidation>();
            #endregion

            services.AddTransient<Data.IUnitOfWork, Data.UnitOfWork>(sp =>
            {
                Data.Tools.Options options =
                    new Data.Tools.Options
                    {
                        Provider =
                            (Data.Tools.Enums.Provider)
                            System.Convert.ToInt32(Configuration.GetSection(key: "databaseProvider").Value),

                        //using Microsoft.EntityFrameworkCore;
                        //ConnectionString =
                        //	Configuration.GetConnectionString().GetSection(key: "MyConnectionString").Value,

                        ConnectionString =
                            Configuration.GetSection(key: "ConnectionStrings").GetSection(key: "MyConnectionString").Value,
                    };

                return new Data.UnitOfWork(options: options);
            });


            //#region Db Context
            //services.AddDbContext<DatabaseContext>(options =>
            //        options.UseSqlServer(Configuration.GetConnectionString("MyConnectionString")));
            //#endregion

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
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
