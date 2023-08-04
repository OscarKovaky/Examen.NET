using AutoMapper;
using DataAccess.DAO.Factura.Imp;
using DataAccess.DAO.UserDao;
using DataAccess.DAO.UserDao.Imp;
using Entities.Context;
using Entities.Models;
using Facade.FacturaFacade;
using Facade.FacturaFacade.Imp;
using Facade.UserFacade;
using Facade.UserFacade.Imp;

using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Security.Imp;
using Security.TokenService;
using Services.FacturaService;
using Services.FacturaService.Imp;
using Services.Mapping;
using Services.UserService;
using Services.UserService.Imp;
using System.Text;

namespace DependencyInjection
{
    public static class DependencyInjector
    {
        private static IServiceCollection Services { get; set; }
        public static IConfiguration Configuration { get; }

        public static IServiceCollection RegisterServices(IServiceCollection services)
        {
            Services = services;

            Services.AddTransient<IUserDao, UserDao>();

            Services.AddTransient<IFacturaSystemFacade, FacturaSystemFacade>();
            Services.AddTransient<IFacturaSystem, FacturaSystemDao>();
            Services.AddTransient<IFacturaService, FacturaSystemService>();



            Services.AddTransient<IJwtGenerador,JwtGenerador>();
            Services.AddTransient<IUsuarioSesion, ComercioToken>();

            Services.AddTransient<IDataBaseContext, DataBaseContext>();

            var builder = Services.AddIdentityCore<Cliente>();
            var identityBuilder = new IdentityBuilder(builder.UserType, builder.Services);

            identityBuilder.AddRoles<IdentityRole>();
            identityBuilder.AddClaimsPrincipalFactory<UserClaimsPrincipalFactory<Cliente, IdentityRole>>();

            identityBuilder.AddEntityFrameworkStores<DataBaseContext>();
            identityBuilder.AddSignInManager<SignInManager<Cliente>>();

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("Mi-palabra-secreta"));
            Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(opt => {
                opt.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = key,
                    ValidateAudience = false,
                    ValidateIssuer = false
                };
            });

            // Configurar CORS con una política personalizada
            services.AddCors(options =>
            {
                options.AddPolicy("MiPoliticaCORS", builder =>
                {
                    builder.AllowAnyOrigin() // Permitir solicitudes desde cualquier origen
                           .AllowAnyMethod() // Permitir cualquier método HTTP (GET, POST, etc.)
                           .AllowAnyHeader(); // Permitir cualquier encabezado en la solicitud
                });
            });

            return Services;
        }

        /// <summary>
        /// Method to add Db Context.
        /// </summary>
        /// <param name="configuration">Configuration Options.</param>
        public static void AddDbContext()
        {
            Services.AddDbContext<DataBaseContext>(options => options.UseSqlServer(Configuration.GetConnectionString("ConnectionDB")));
        }

        public static void AddAutoMapper()
        {
            var mappingConfig = new MapperConfiguration(mc => { mc.AddProfile(new AutoMapperProfile()); });
            Services.AddSingleton(mappingConfig.CreateMapper());
        }
    }
}