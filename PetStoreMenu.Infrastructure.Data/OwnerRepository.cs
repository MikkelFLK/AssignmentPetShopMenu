﻿using PetShopMenu.Core.DomainService;
using PetShopMenu.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetStoreMenu.Infrastructure.Data
{
    public class OwnerRepository : IOwnerRepository
    {
        static int id = 1;
        public Owner Create(Owner owner)
        {
            owner.OwnerId = id++;
            FakeDB.Owners.Add(owner);
            return owner;
        }

        public Owner Delete(int id)
        {
            var ownerFound = this.ReadById(id);
            if(ownerFound != null)
            {
                FakeDB.Owners.Remove(ownerFound);
                return ownerFound;
            }
            return null;
        }

        public Owner ReadById(int id)
        {
            foreach (var owner in FakeDB.Owners)
            {
                if(owner.OwnerId == id)
                {
                    return owner;
                }           
            }
            return null;
        }

        public IEnumerable<Owner> ReadOwners()
        {
            return FakeDB.Owners;
        }

        public Owner Update(Owner owner)
        {
            var ownerFromDB = this.ReadById(owner.OwnerId);
            if(ownerFromDB != null)
            {
                ownerFromDB.FirstName = owner.FirstName;
                ownerFromDB.LastName = owner.LastName;
                return ownerFromDB;
            }
            return null;
        }
    }
}
