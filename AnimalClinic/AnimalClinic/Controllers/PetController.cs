using AnimalClinic.Models.Requests;
using AnimalClinic.Models;
using AnimalClinic.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AnimalClinic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetController : ControllerBase
    {
        private IPetRepository _petRepository;

        public PetController(IPetRepository petRepository)
        {
            _petRepository = petRepository;
        }

        [HttpPost("create")]
        public ActionResult<int> Create([FromBody] CreatePetRequesr createPetRequest)
        {
            Pet pet = new Pet();
            pet.ClientId = createPetRequest.ClientId;
            pet.Name = createPetRequest.Name;
            pet.Birthday = createPetRequest.Birthday;
            int res = _petRepository.Create(pet);
            return Ok(res);
        }

        [HttpPut("update")]
        public ActionResult<int> Update([FromBody] UpdatePetRequest updatePetRequest)
        {
            Pet pet = new Pet();
            pet.PetId = updatePetRequest.PetId;
            pet.ClientId = updatePetRequest.ClientId;
            pet.Name = updatePetRequest.Name;
            pet.Birthday = updatePetRequest.Birthday;
            int res = _petRepository.Update(pet);
            return Ok(res);
        }

        [HttpDelete("delete")]
        public ActionResult<int> Delete([FromQuery] int petId)
        {
            int res = _petRepository.Delete(petId);
            return Ok(res);
        }

        [HttpGet("get-all")]
        public ActionResult<List<Pet>> GetAll()
        {
            List<Pet> pets = _petRepository.GetAll();
            return Ok(pets);
        }

        [HttpGet("get-by-id")]
        public ActionResult<Pet> GetById([FromQuery] int petId)
        {
            Pet pet = _petRepository.GetById(petId);
            return Ok(pet);
        }
    }
}

