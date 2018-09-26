using PetShopMenu.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetShopMenu.Core.DomainService
{
    public interface IPetRepository
    {
        IEnumerable<Pet> ReadPets();
        IEnumerable<Pet> ReadPetsFiltered(Filter filter);


        Pet Create(Pet pet);

        Pet Delete(int id);
        Pet ReadById(int id);

        Pet Update(Pet petUpdate);

        IEnumerable<Pet> ReadByType(string type);

        IEnumerable<Pet> ReadByPrice();
        int Count();
    }
}
