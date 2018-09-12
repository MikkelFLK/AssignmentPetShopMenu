using PetShopMenu.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetStoreMenu.Infrastructure.Data
{
    public static class FakeDB
    {
        public static List<Pet> Pets = new List<Pet>();
        public static List<Owner> Owners = new List<Owner>();
        public static void InitData()
        {
            var owner1 = new Owner()
            {
                OwnerId = 1,
                FirstName = "Garry",
                LastName = "Petowner"
            };
            Owners.Add(owner1);
            var owner2 = new Owner()
            {
                OwnerId = 2,
                FirstName = "Jill",
                LastName = "Crazycatlady"
            };
            Owners.Add(owner2);

            var pet1 = new Pet()
            {
                PetId = 1,
                PetName = "Fred",
                PetType = "Dog",
                Birthdate = new DateTime(1000, 12, 12),
                SoldDate = new DateTime(1200, 12, 12),
                Color = "Grey",
                PreviousOwner = "Bob",
                Price = 9.99,
                Owner = new Owner() {OwnerId = 1}
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
                Price = 45.99,
                Owner = new Owner() { OwnerId = 1 }
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
                Price = 99.99,
                Owner = new Owner() { OwnerId = 2 }
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
                Price = 3.99,
                Owner = new Owner() { OwnerId = 2 }
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
                Price = 88.99,
                Owner = new Owner() { OwnerId = 1 }
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
                Price = 900.99,
                Owner = new Owner() { OwnerId = 2 }
            };
            Pets.Add(pet6);
        }
      
    }
}
