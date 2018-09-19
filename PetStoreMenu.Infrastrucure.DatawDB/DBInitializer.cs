using PetShopMenu.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetStoreMenu.Infrastrucure.DatawDB
{
    public class DBInitializer
    {
        public static void SeedDB(PetStoreMenuContextcs ctx)
        {
            ctx.Database.EnsureDeleted();
            ctx.Database.EnsureCreated();


            var own1 = ctx.Owners.Add(new Owner()
            {
                FirstName = "Bob",
                LastName = "Johnson"
            }).Entity;
            var own2 = ctx.Owners.Add(new Owner()
            {
                FirstName = "Sam",
                LastName = "Something"
            }).Entity;

            ctx.Pets.Add(new Pet()
            {
                PetName = "Fred",
                PetType = "Dog",
                Birthdate = new DateTime(1000, 12, 12),
                SoldDate = new DateTime(1200, 12, 12),
                Color = "Grey",
                PreviousOwner = "Bob",
                Price = 9.99,
                Owner = own1
            });
            ctx.Pets.Add(new Pet()
            {
                PetName = "Truck",
                PetType = "Duck",
                Birthdate = new DateTime(1000, 12, 12),
                SoldDate = new DateTime(1200, 12, 12),
                Color = "Red",
                PreviousOwner = "Bob",
                Price = 99.50,
                Owner = own1
            });
            ctx.Pets.Add(new Pet()
            {
                PetName = "Liam",
                PetType = "Cat",
                Birthdate = new DateTime(1000, 12, 12),
                SoldDate = new DateTime(1200, 12, 12),
                Color = "Cyan",
                PreviousOwner = "Clint",
                Price = 999.99,
                Owner = own2
            });

            ctx.SaveChanges();
        }
    }
}
