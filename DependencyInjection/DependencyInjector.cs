using AutoMapper;
using DataAccess.DAO;
using DataAccess.DAO.ComercioDao;
using DataAccess.DAO.ComercioDao.ComercioImp;
using DataAccess.DAO.UserDao;
using DataAccess.DAO.UserDao.Imp;
using Entities.Context;
using Entities.Models;
using Facade.ComercioFacade;
using Facade.ComercioFacade.Imp;
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
using Services.ComercioService;
using Services.ComercioService.Imp;
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
            Services.AddTransient<IArticuloFacade, ArticuloFacade>();
            Services.AddTransient<IArticuloService, ArticuloService>();
            Services.AddTransient<IArticuloDao, ArticuloDao>();

            Services.AddTransient<IUserFacade, UserFacade>();
            Services.AddTransient<IUserService, UserService>();
            Services.AddTransient<IUserDao, UserDao>();

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