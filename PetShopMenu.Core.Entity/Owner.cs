﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PetShopMenu.Core.Entity
{
    public class Owner
    {
        public int OwnerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Pet> Pets { get; set; }

    }
}
