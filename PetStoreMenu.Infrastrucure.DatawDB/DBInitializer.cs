﻿using PetShopMenu.Core.Entity;
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

            string password = "1234";
            byte[] passwordHashJoe, passwordSaltJoe, passwordHashAnn, passwordSaltAnn;
            CreatePasswordHash(password, out passwordHashJoe, out passwordSaltJoe);
            CreatePasswordHash(password, out passwordHashAnn, out passwordSaltAnn);

            var user1 = ctx.Users.Add(new User()
            {
                Username = "UserJoe",
                PasswordHash = passwordHashJoe,
                PasswordSalt = passwordSaltJoe,
                IsAdmin = false
            }).Entity;

            var user2 = ctx.Users.Add(new User()
            {
                Username = "AdminAnn",
                PasswordHash = passwordHashAnn,
                PasswordSalt = passwordSaltAnn,
                IsAdmin = true
            }).Entity;

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
            var own3 = ctx.Owners.Add(new Owner()
            {
                FirstName = "Owen",
                LastName = "Ownerson"
            }).Entity;
            var own4 = ctx.Owners.Add(new Owner()
            {
                FirstName = "Beth",
                LastName = "Catlady"
            }).Entity;
            var own5 = ctx.Owners.Add(new Owner()
            {
                FirstName = "Number",
                LastName = "Five"
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
            ctx.Pets.Add(new Pet()
            {
                PetName = "Mittens",
                PetType = "Cat",
                Birthdate = new DateTime(1000, 12, 12),
                SoldDate = new DateTime(1200, 12, 12),
                Color = "Grey",
                PreviousOwner = "Bob",
                Price = 5.99,
                Owner = own4
            });
            ctx.Pets.Add(new Pet()
            {
                PetName = "Paul",
                PetType = "Cat",
                Birthdate = new DateTime(1000, 12, 12),
                SoldDate = new DateTime(1200, 12, 12),
                Color = "Grey",
                PreviousOwner = "Bob",
                Price = 44.99,
                Owner = own4
            });
            ctx.Pets.Add(new Pet()
            {
                PetName = "Popeye",
                PetType = "Lion",
                Birthdate = new DateTime(1000, 12, 12),
                SoldDate = new DateTime(1200, 12, 12),
                Color = "Grey",
                PreviousOwner = "Bob",
                Price = 20.99,
                Owner = own3
            });

            ctx.SaveChanges();
        }
        private static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }
    }
}
