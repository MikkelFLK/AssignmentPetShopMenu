using Microsoft.EntityFrameworkCore;
using PetShopMenu.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetStoreMenu.Infrastructure.Data
{
    public class PetStoreMenuContext: DbContext
    {
        public DbSet<Pet> Pets { get; set; }
        public DbSet<Owner> Owners { get; set; }
    }
}
