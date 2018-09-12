using PetShopMenu.Core.DomainService;
using PetShopMenu.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetStoreMenu.Infrastructure.Data.RepositoriesSQL
{
    public class PetRepository : IPetRepository
    {
        readonly PetStoreMenuContext _ctx;

        

        public Pet Create(Pet pet)
        {
            throw new NotImplementedException();
        }

        public Pet Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Pet ReadById(int id)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public Pet Update(Pet petUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
