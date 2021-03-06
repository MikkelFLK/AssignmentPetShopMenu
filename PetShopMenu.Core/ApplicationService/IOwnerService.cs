﻿using PetShopMenu.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetShopMenu.Core.ApplicationService
{
    public interface IOwnerService
    {
        List<Owner> GetOwners();
        Owner NewOwner(string firstName, string lastName);
        Owner CreateOwner(Owner owner);
        Owner FindOwnerById(int id);
        Owner UpdateOwner(Owner owner);
        Owner DeleteOwner(int id);
    }
}
