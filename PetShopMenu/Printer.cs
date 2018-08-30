using PetShopMenu.Core.ApplicationService;
using PetShopMenu.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetShopMenu
{
    public class Printer: IPrinter
    {
        readonly IPetService _petService;
 
        public Printer(IPetService petService)
        {
            _petService = petService;
        }

        public void PrintUI()
        {
            string[] menuItems =
            {
                "List all Pets",//1
                "Create new Pet",//2
                "Delete Pet",//3
                "Update a Pet",//4
                "Search Pets by Type",//5
                "Sort Pets by Price",//6
                "Get 5 cheapest Pets",//7
                "Exit"//8
            };

            var selection = PrintMenu(menuItems);
            while (selection != 8)
            {
                switch (selection)
                {
                    case 1:
                        var pets = _petService.GetPets();
                        PrintPets(pets);
                        break;
                    case 2:
                        var petName = AskQuestion("Pet name: ");
                        var type = AskQuestion("Pet Type: ");
                        var birthDate = AskQuestion("Pet Birthdate: ");
                        var soldDate = AskQuestion("Pet Sold Date: ");
                        var color = AskQuestion("Pet Color: ");
                        var previousOwner = AskQuestion("Previous owner: ");
                        var price = AskQuestion("Pet Price: ");
                        var pet = _petService.NewPet(petName, type, Convert.ToDateTime(birthDate), Convert.ToDateTime(soldDate), color, previousOwner, Convert.ToDouble(price));
                        _petService.CreatePet(pet);
                        break;
                    case 3:
                        var idToDelete = FindPetId();
                        _petService.DeletePet(idToDelete);
                        break;
                    case 4:
                        
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    default:
                        break;
                }
                selection = PrintMenu(menuItems);
                Console.Clear();
            }
            AskQuestion("Press enter to exit");
        }

        int FindPetId()
        {
            Console.WriteLine("Insert Pet Id: ");
            int id;
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Please insert a number");
            }
            return id;
        }

        private void PrintPets(List<Pet> pets)
        {
            Console.WriteLine("\nList of Pets");
            foreach (var Pet in pets)
            {
                Console.WriteLine($"Id: {Pet.PetId} Name: {Pet.PetName} " +
                    $"Type: {Pet.PetType} Birthdate: {Pet.Birthdate} " +
                    $"SoldDate: {Pet.SoldDate} Color: {Pet.Color} " +
                    $"Previous Owner {Pet.PreviousOwner} Price {Pet.Price}");
            }
        }

        int PrintMenu(string[] menuItems)
        {
            Console.WriteLine("\nPetShop Menu\n");
            Console.WriteLine("Please select a command\n");
            for (int i = 0; i < menuItems.Length; i++)
            {
                Console.WriteLine((i + 1) + ":" + menuItems[i]);
            }
            int selection;
            while (!int.TryParse(Console.ReadLine(), out selection) || selection < 1 || selection > 8)
            {
                Console.WriteLine("\nPlease input a valid command");
            }
            return selection;
        }

        string AskQuestion(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }
    }
}
