using AnimalClinic.Models.Requests;
using AnimalClinic.Models;
using AnimalClinic.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

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
        [SwaggerOperation(OperationId = "PetCreate")]
        public ActionResult<int> Create([FromBody] CreatePetRequest createPetRequest)
        {
            Pet pet = new Pet();
            pet.ClientId = createPetRequest.ClientId;
            pet.Name = createPetRequest.Name;
            pet.Birthday = createPetRequest.Birthday;
            int res = _petRepository.Create(pet);
            if (string.IsNullOrEmpty(createPetRequest.Name) ||
                createPetRequest.Name.Length < 1) //||
                //createPetRequest.Birthday < DateTime.Now.AddYears(-25))
            {
                return BadRequest(0); // HTTP 400 BadRequestObjectResult
            }
            return Ok(res);
        }

        [HttpPut("update")]
        [SwaggerOperation(OperationId = "PetUpdate")]
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
        [SwaggerOperation(OperationId = "PetDelite")]
        public ActionResult<int> Delete([FromQuery] int petId)
        {
            if (petId <= 0)
            {
                return BadRequest(0);
            }
            int res = _petRepository.Delete(petId);
            return Ok(res);
        }

        [HttpGet("get-all")]
        [SwaggerOperation(OperationId = "PetGetAll")]
        public ActionResult<List<Pet>> GetAll()
        {
            List<Pet> pets = _petRepository.GetAll();
            return Ok(pets);
        }

        [HttpGet("get-by-id")]
        [SwaggerOperation(OperationId = "PetGetById")]
        public ActionResult<Pet> GetById([FromQuery] int petId)
        {
            Pet pet = _petRepository.GetById(petId);
            return Ok(pet);
        }
    }
}

