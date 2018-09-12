using System;
using System.Collections.Generic;
using System.Text;

namespace PetShopMenu.Core.Entity
{
    public class Pet
    {
        public int PetId { get; set; }
        public string PetName { get; set; }
        public string PetType { get; set; }
        public DateTime Birthdate { get; set; }
        public DateTime SoldDate { get; set; }
        public string Color { get; set; }
        public string PreviousOwner { get; set; }
        public double Price { get; set; }
        public Owner Owner { get; set; }

    }
}
