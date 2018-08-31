using PetShopMenu.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetShopMenu.Core.ApplicationService
{
    public interface IPetService
    {
        List<Pet> GetPets();
        Pet NewPet(string petName,
                   string type,
                   DateTime birthDate,
                   DateTime soldDate,
                   string color,
                   string previousOwner,
                   double price);
        Pet CreatePet(Pet pet);

        Pet DeletePet(int id);
        Pet FindPetById(int id);

        Pet UpdatePet(Pet petUpdate);

        List<Pet> FindPetByType(string type);

        List<Pet> SortByPrice();

        List<Pet> Get5CheapestPets();

    }
}
