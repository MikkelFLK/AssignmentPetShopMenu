using PetShopMenu.Core.DomainService;
using PetShopMenu.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetStoreMenu.Infrastructure.Data
{
    public class PetRepository : IPetRepository
    {
        static int id = 1;
        public Pet Create(Pet pet)
        {
            pet.PetId = id++;
            FakeDB.Pets.Add(pet);
            return pet;
        }

        public Pet ReadById(int id)
        {
            foreach (var pet in FakeDB.Pets)
            {
                if(pet.PetId == id)
                {
                    return pet;
                }
            }
            return null;
        }

        public Pet Delete(int id)
        {
            var petFound = this.ReadById(id);
            if(petFound != null)
            {
                FakeDB.Pets.Remove(petFound);
                return petFound;
            }
            return null;
        }

        public IEnumerable<Pet> ReadPets()
        {
            FakeDB.InitData();
            return FakeDB.Pets;
        }
    }
}
