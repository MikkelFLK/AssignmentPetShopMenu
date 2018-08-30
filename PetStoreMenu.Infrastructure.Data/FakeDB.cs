using PetShopMenu.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetStoreMenu.Infrastructure.Data
{
    public static class FakeDB
    {
        public static List<Pet> Pets = new List<Pet>();

        public static void InitData()
        {
            var pet1 = new Pet()
            {
                PetId = 1,
                PetName = "Fred",
                PetType = "Dog",
                Birthdate = new DateTime(1000, 12, 12),
                SoldDate = new DateTime(1200, 12, 12),
                Color = "Grey",
                PreviousOwner = "Bob",
                Price = 9.99
            };
            Pets.Add(pet1);

        }
      
    }
}
