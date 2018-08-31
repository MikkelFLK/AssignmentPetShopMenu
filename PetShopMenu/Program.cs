using Microsoft.Extensions.DependencyInjection;
using PetShopMenu.Core.ApplicationService;
using PetShopMenu.Core.ApplicationService.Impl;
using PetShopMenu.Core.DomainService;
using PetStoreMenu.Infrastructure.Data;
using System;

namespace PetShopMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            FakeDB.InitData();
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddScoped<IPetRepository, PetRepository>();
            serviceCollection.AddScoped<IPetService, PetService>();
            serviceCollection.AddScoped<IPrinter, Printer>();

            var serviceProvider = serviceCollection.BuildServiceProvider();
            var printer = serviceProvider.GetRequiredService<IPrinter>();
            printer.PrintUI();
            
        }
    }
}
