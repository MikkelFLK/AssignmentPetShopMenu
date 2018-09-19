using Microsoft.EntityFrameworkCore;
using PetShopMenu.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetStoreMenu.Infrastrucure.DatawDB
{
    public class PetStoreMenuContextcs: DbContext
    {

        public PetStoreMenuContextcs(DbContextOptions<PetStoreMenuContextcs> opt) : base(opt)
        {

        }

        public DbSet<Pet> Pets { get; set; }
        public DbSet<Owner> Owners { get; set; }



    }
}
