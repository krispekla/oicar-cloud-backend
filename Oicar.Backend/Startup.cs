using System.Text;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Oicar.Dal;
using Oicar.Service.Interfaces;
using Oicar.Service.Services;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Oicar.Api.Helpers;

namespace Oicar.Backend
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            configuration.GetConnectionString("default");
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // configure strongly typed settings objects
            var appSettingsSection = Configuration.GetSection("AppSettings");
            services.Configure<AppSettings>(appSettingsSection);

            // configure jwt authentication
            var appSettings = appSettingsSection.Get<AppSettings>();
            var key = Encoding.ASCII.GetBytes(appSettings.Secret);
            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = false;
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };
            });



            services.AddScoped<IUserService, UserService>();
            services.AddTransient<IUserCloudConfigurationService, UserCloudConfigurationService>();
            services.AddTransient<ICalculatorService, CalculatorService>();
            services.AddTransient<ICloudFunctionService, CloudFunctionService>();
            services.AddTransient<ICloudStorageService, CloudStorageService>();
            services.AddTransient<ICloudVMService, CloudVMService>();
            services.AddTransient<ICloudNewsService, CloudNewsService>();
            services.AddTransient<IDbSQLService, DbSQLService>();
            services.AddDbContext<OicarContext>(options =>
                options.UseNpgsql(Configuration.GetConnectionString("default")));

            services.AddCors();
            services.AddControllers().AddNewtonsoftJson(options =>
      options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
   );
            services.AddSwaggerGen(c =>
             {
                 c.SwaggerDoc("v1", new OpenApiInfo { Title = "Oicar Cloud API", Version = "v1" });
                 c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                 {
                     In = ParameterLocation.Header,
                     Description = "Please insert JWT with Bearer into field",
                     Name = "Authorization",
                     Type = SecuritySchemeType.ApiKey
                 });
                 c.AddSecurityRequirement(new OpenApiSecurityRequirement {
                       {
                         new OpenApiSecurityScheme
                         {
                           Reference = new OpenApiReference
                           {
                             Type = ReferenceType.SecurityScheme,
                             Id = "Bearer"
                           }
                          },
                          new string[] { }
                        }
                      });
             });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Oicar Cloud API V1");
                c.RoutePrefix = string.Empty;
            });

            app.UseRouting();

            app.UseCors(x => x
              .AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader());

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
