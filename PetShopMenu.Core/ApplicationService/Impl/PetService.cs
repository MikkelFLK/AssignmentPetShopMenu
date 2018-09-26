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
        readonly IOwnerRepository _ownerRepo;

        public PetService(IPetRepository petRepository, IOwnerRepository ownerRepository)
        {
            _petRepo = petRepository;
            _ownerRepo = ownerRepository;
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
            var pet = _petRepo.ReadById(id);
            
            return pet;
            
        }

        public List<Pet> FindPetByType(string type)
        {
            var list = _petRepo.ReadPets();
            var question = list.Where(pet => pet.PetType.Equals(type));
            question.OrderBy(pet => pet.PetType);
            return question.ToList();
        }

        public List<Pet> Get5CheapestPets()
        {
            return _petRepo.ReadPets().OrderBy(pet => pet.Price).Take(5).ToList();
        }

        public List<Pet> GetPets()
        {
            return _petRepo.ReadPets().ToList();
        }

        public Pet NewPet(string petName, string type, DateTime birthDate, DateTime soldDate, string color, string previousOwner, double price, int ownerId)
        {
            var pet = new Pet()
            {
                PetName = petName,
                PetType = type,
                Birthdate = birthDate,
                SoldDate = soldDate,
                Color = color,
                PreviousOwner = previousOwner,
                Price = price,
                Owner = new Owner() { OwnerId = ownerId}
            };
            return pet;
        }

        public List<Pet> SortByPrice()
        {
            var list = _petRepo.ReadPets();
            var question = list.OrderBy(pet => pet.Price);
            return question.ToList();
 
        }

        public Pet UpdatePet(Pet petUpdate)
        {
            return _petRepo.Update(petUpdate);
        }
    }
}
