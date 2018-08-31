using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PetShopMenu.Core.DomainService;
using PetShopMenu.Core.Entity;

namespace PetShopMenu.Core.ApplicationService.Impl
{
    public class PetService : IPetService
    {
        readonly IPetRepository _petRepo;

        public PetService(IPetRepository petRepository)
        {
            _petRepo = petRepository;
        }

        public Pet CreatePet(Pet pet)
        {
            return _petRepo.Create(pet);
        }

        public Pet DeletePet(int id)
        {
            return _petRepo.Delete(id);
        }

        public Pet FindPetById(int id)
        {
            return _petRepo.ReadById(id);
        }

        public List<Pet> GetPets()
        {
            return _petRepo.ReadPets().ToList();
        }

        public Pet NewPet(string petName, string type, DateTime birthDate, DateTime soldDate, string color, string previousOwner, double price)
        {
            var pet = new Pet()
            {
                PetName = petName,
                PetType = type,
                Birthdate = birthDate,
                SoldDate = soldDate,
                Color = color,
                PreviousOwner = previousOwner,
                Price = price
            };
            return pet;
        }

        public Pet UpdatePet(Pet petUpdate)
        {
            var pet = FindPetById(petUpdate.PetId);
            pet.PetName = petUpdate.PetName;
            pet.PetType = petUpdate.PetType;
            pet.Birthdate = petUpdate.Birthdate;
            pet.SoldDate = petUpdate.SoldDate;
            pet.Color = petUpdate.Color;
            pet.PreviousOwner = petUpdate.PreviousOwner;
            pet.Price = petUpdate.Price;
            return pet;
        }
    }
}
