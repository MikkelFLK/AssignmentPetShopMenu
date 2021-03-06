﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PetShopMenu.Core.DomainService;
using PetShopMenu.Core.Entity;

namespace PetShopMenu.Core.ApplicationService.Impl
{
    public class OwnerService : IOwnerService
    {
        readonly IOwnerRepository _ownerRepo;
        public OwnerService(IOwnerRepository ownerRepository)
        {
            _ownerRepo = ownerRepository;
        }

        public Owner CreateOwner(Owner owner)
        {
            return _ownerRepo.Create(owner);
        }

        public Owner DeleteOwner(int id)
        {
            return _ownerRepo.Delete(id);
        }

        public Owner FindOwnerById(int id)
        {
            return _ownerRepo.ReadById(id);
        }

        public List<Owner> GetOwners()
        {
            return _ownerRepo.ReadOwners().ToList();
        }

        public Owner NewOwner(string firstName, string lastName)
        {
            var owner = new Owner()
            {
                FirstName = firstName,
                LastName = lastName
            };
            return owner;
        }

        public Owner UpdateOwner(Owner owner)
        {
            return _ownerRepo.Update(owner);
        }
    }
}
