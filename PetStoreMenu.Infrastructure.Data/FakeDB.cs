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

            var pet2 = new Pet()
            {
                PetId = 2,
                PetName = "Bod",
                PetType = "Cat",
                Birthdate = new DateTime(1000, 12, 12),
                SoldDate = new DateTime(1200, 12, 12),
                Color = "Grey",
                PreviousOwner = "Bob",
                Price = 45.99
            };
            Pets.Add(pet2);

            var pet3 = new Pet()
            {
                PetId = 3,
                PetName = "Gob",
                PetType = "Dog",
                Birthdate = new DateTime(1000, 12, 12),
                SoldDate = new DateTime(1200, 12, 12),
                Color = "Grey",
                PreviousOwner = "Bob",
                Price = 99.99
            };
            Pets.Add(pet3);

            var pet4 = new Pet()
            {
                PetId = 4,
                PetName = "Tom",
                PetType = "Goat",
                Birthdate = new DateTime(1000, 12, 12),
                SoldDate = new DateTime(1200, 12, 12),
                Color = "Grey",
                PreviousOwner = "Bob",
                Price = 3.99
            };
            Pets.Add(pet4);

            var pet5 = new Pet()
            {
                PetId = 5,
                PetName = "Cid",
                PetType = "Cat",
                Birthdate = new DateTime(1000, 12, 12),
                SoldDate = new DateTime(1200, 12, 12),
                Color = "Grey",
                PreviousOwner = "Bob",
                Price = 88.99
            };
            Pets.Add(pet5);

            var pet6 = new Pet()
            {
                PetId = 6,
                PetName = "John",
                PetType = "Goat",
                Birthdate = new DateTime(1000, 12, 12),
                SoldDate = new DateTime(1200, 12, 12),
                Color = "Grey",
                PreviousOwner = "Bob",
                Price = 900.99
            };
            Pets.Add(pet6);
        }
      
    }
}
