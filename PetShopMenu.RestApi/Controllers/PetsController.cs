﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PetShopMenu.Core.ApplicationService;
using PetShopMenu.Core.Entity;

namespace PetShopMenu.RestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetsController : ControllerBase
    {
        private readonly IPetService _petService;

        public PetsController(IPetService petService)
        {
            _petService = petService;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Pet>> Get([FromQuery] Filter filter)
        {
            try
            {
                return Ok(_petService.GetFilteredOrders(filter));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Pet> Get(int id)
        {
            if (id < 1) return BadRequest("Id must be greater than 0");
            return _petService.FindPetById(id);
        }

        // POST api/values
        [HttpPost]
        public ActionResult<Pet> Post([FromBody] Pet pet)
        {
            if (string.IsNullOrEmpty(pet.PetName))
            {
                return BadRequest("Input pet name");
            }
            if (string.IsNullOrEmpty(pet.PetType))
            {
                return BadRequest("Input pet type");
            }
            if (string.IsNullOrEmpty(pet.Color))
            {
                return BadRequest("Input color");
            }
            if (string.IsNullOrEmpty(pet.PreviousOwner))
            {
                return BadRequest("Input previous owner");
            }
            return _petService.CreatePet(pet);
        }

        // PUT api/values/5 --Update
        [HttpPut("{id}")]
        public ActionResult<Pet> Put(int id, [FromBody] Pet pet)
        {
            if (id < 1 || id != pet.PetId)
            {
                return BadRequest("Parameter Id and customer ID must be the same");
            }
            return Ok(_petService.UpdatePet(pet));
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult<Pet> Delete(int id)
        {
            var pet = _petService.DeletePet(id);
            if (pet == null)
            {
                return StatusCode(404, "Did not find Pet with ID " + id);
            }
            return Ok($"Pet with Id: {id} is Deleted");
        }
    }
}
