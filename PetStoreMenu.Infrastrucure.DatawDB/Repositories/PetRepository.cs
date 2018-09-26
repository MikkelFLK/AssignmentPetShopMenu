using Microsoft.EntityFrameworkCore;
using PetShopMenu.Core.DomainService;
using PetShopMenu.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PetStoreMenu.Infrastrucure.DatawDB.Repositories
{
    public class PetRepository : IPetRepository
    {
        readonly PetStoreMenuContextcs _ctx;
        public PetRepository(PetStoreMenuContextcs ctx)
        {
            _ctx = ctx;
        }

        public Pet Create(Pet pet)
        {
            if (pet.Owner != null && _ctx.ChangeTracker.Entries<Owner>().FirstOrDefault(ce => ce.Entity.OwnerId == pet.Owner.OwnerId)== null)
            {
                _ctx.Attach(pet.Owner);
            }
            var newPet = _ctx.Pets.Add(pet).Entity;
            _ctx.SaveChanges();
            return newPet;
        }

        public Pet Delete(int id)
        {
            var petRemoved = _ctx.Remove(new Pet { PetId = id }).Entity;
            _ctx.SaveChanges();
            return petRemoved;
        }

        public Pet ReadById(int id)
        {
            return _ctx.Pets.Include(p => p.Owner).FirstOrDefault(p => p.PetId == id);
        }

        public IEnumerable<Pet> ReadByPrice()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Pet> ReadByType(string type)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Pet> ReadPets()
        {
            return _ctx.Pets;
        }

        public Pet Update(Pet petUpdate)
        {
            _ctx.Attach(petUpdate).State = EntityState.Modified;
            _ctx.Entry(petUpdate).Reference(p => p.Owner).IsModified = true;
            _ctx.SaveChanges();

            return petUpdate;
        }
    }
}
