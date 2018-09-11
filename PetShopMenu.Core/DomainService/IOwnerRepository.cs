using PetShopMenu.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetShopMenu.Core.DomainService
{
    public interface IOwnerRepository
    {
        IEnumerable<Owner> ReadOwners();
        Owner Create(Owner owner);
        Owner ReadById(int id);
        Owner Update(Owner owner);
        Owner Delete(int id);
    }
}
