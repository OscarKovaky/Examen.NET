using AutoMapper;
using DataAccess.DAO;
using DataAccess.DAO.Imp;
using Entities.Context;
using Facade.BankFacade;
using Facade.BankFacade.Imp;
using Microsoft.Extensions.DependencyInjection;
using Services.BankService;
using Services.BankService.Imp;
using Services.Mapping;

namespace DependencyInjection
{
    public static class DependencyInjector
    {
        private static IServiceCollection Services { get; set; }

        public static IServiceCollection RegisterServices(IServiceCollection services)
        {
            Services = services;
            Services.AddTransient<IBankFacade, BankFacade>();
            Services.AddTransient<IBankService, BankService>();
            Services.AddTransient<IBankDao, BankDao>();
            Services.AddTransient<IDataBaseContext, DataBaseContext>();

            return Services;
        }

        public static void AddAutoMapper()
        {
            var mappingConfig = new MapperConfiguration(mc => { mc.AddProfile(new AutoMapperProfile()); });
            Services.AddSingleton(mappingConfig.CreateMapper());
        }
    }
}