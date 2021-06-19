using Data;
using Models;
using System;
using Validator;
using FluentValidation;
using Service.Email.Account;
using ViewModels.LegalPerson;
using ViewModels.NaturalPerson;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

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
            services.AddTransient<IValidator<LegalPersonViewModel>, LegalPersonValidation>();
            services.AddTransient<IValidator<NaturalPersonViewModel>, NaturalPersonValidation>();
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

            #region Db Context
            services.AddDbContext<DatabaseContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("MyConnectionString")));
            #endregion


            #region Identity Setting
            // Identity Setting
            services.AddIdentity<IdentityUser, IdentityRole>(options =>
            {
                #region User
                // Require Unique Email
                options.User.RequireUniqueEmail = true;
                // Allowed UserName Characters
                options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                #endregion

                #region SignIn
                // Require Confirmed Email
                options.SignIn.RequireConfirmedEmail = true;
                //Require Confirmed Account
                options.SignIn.RequireConfirmedAccount = false;
                // Require Confirmed PhoneNumber
                options.SignIn.RequireConfirmedPhoneNumber = false;
                #endregion

                #region Password
                // Required Length
                options.Password.RequiredLength = 8;
                // Require Digit
                options.Password.RequireDigit = true;
                // Required Unique Chars
                options.Password.RequiredUniqueChars = 0;
                // Require Uppercase
                options.Password.RequireUppercase = true;
                // Require Lowercase
                options.Password.RequireLowercase = true;
                // Require Non Alphanumeric
                options.Password.RequireNonAlphanumeric = true;
                #endregion

                #region LockOut
                // Allowed For NewUsers
                options.Lockout.AllowedForNewUsers = true;
                // Max Failed Access Attempts
                options.Lockout.MaxFailedAccessAttempts = 5;
                // Default Lockout TimeSpan
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(10);
                #endregion

            })
            #endregion

            // Token Error Message
            .AddEntityFrameworkStores<DatabaseContext>()
            .AddDefaultTokenProviders();

            services.Configure<DataProtectionTokenProviderOptions>(options =>
            {
                options.TokenLifespan = TimeSpan.FromMinutes(10);
            });

            // Message Sender
            services.AddScoped<IMessageSender, MessageSender>();

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

            app.UseAuthentication();

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