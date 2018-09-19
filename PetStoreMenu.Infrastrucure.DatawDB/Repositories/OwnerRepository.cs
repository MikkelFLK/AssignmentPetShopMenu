using Microsoft.EntityFrameworkCore;
using PetShopMenu.Core.DomainService;
using PetShopMenu.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PetStoreMenu.Infrastrucure.DatawDB.Repositories
{
    public class OwnerRepository : IOwnerRepository
    {
        readonly PetStoreMenuContextcs _ctx;
        public OwnerRepository(PetStoreMenuContextcs ctx)
        {
            _ctx = ctx;
        }

        public Owner Create(Owner owner)
        {
            var own = _ctx.Owners.Add(owner).Entity;
            _ctx.SaveChanges();
            return own;

        }

        public Owner Delete(int id)
        {
            var ownerRemoved = _ctx.Remove(new Owner { OwnerId = id }).Entity;
            _ctx.SaveChanges();
            return ownerRemoved;
        }

        public Owner ReadById(int id)
        {
            return _ctx.Owners.Include(o => o.Pets).FirstOrDefault(o => o.OwnerId == id);
        }

        public IEnumerable<Owner> ReadOwners()
        {
            return _ctx.Owners;
        }

        public Owner Update(Owner owner)
        {
            throw new NotImplementedException();
        }
    }
}
