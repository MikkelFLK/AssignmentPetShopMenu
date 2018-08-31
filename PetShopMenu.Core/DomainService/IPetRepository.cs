using PetShopMenu.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetShopMenu.Core.DomainService
{
    public interface IPetRepository
    {
        IEnumerable<Pet> ReadPets();

        Pet Create(Pet pet);

        Pet Delete(int id);
        Pet ReadById(int id);

        Pet Update(Pet petUpdate);

        IEnumerable<Pet> ReadByType(string type);
    }
}
