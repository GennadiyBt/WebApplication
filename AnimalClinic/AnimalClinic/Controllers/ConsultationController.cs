using AnimalClinic.Models;
using AnimalClinic.Models.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace AnimalClinic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultationController : ControllerBase
    {

        [HttpPost("create")]
        [SwaggerOperation(OperationId = "ConsultationCreate")]
        public ActionResult<int> Create([FromBody] CreateConsultationRequest createConsultationRequest)
        {
            if (createConsultationRequest.PetId < 1 ||
                createConsultationRequest.ClientId < 1 ||
                createConsultationRequest.ConsultationDate < DateTime.Now.AddYears(-5))
            {
                return BadRequest(0); // HTTP 400 BadRequestObjectResult
            }
            return Ok(1); // HTTP 200 OkObjectResult
        }

        [HttpPut("update")]
        [SwaggerOperation(OperationId = "ConsultationUpdate")]
        public ActionResult<int> Update()
        {

            return Ok(1);
        }

        [HttpDelete("delete")]
        [SwaggerOperation(OperationId = "ConsultationDelete")]
        public ActionResult<int> Delete(int consultationId)
        {
            if (consultationId <= 0)
            {
                return BadRequest(0);
            }
            return Ok(1);
        }

        [HttpGet("get-all")]
        [SwaggerOperation(OperationId = "ConsultationGetAll")]
        public ActionResult<List<Pet>> GetAll()
        {
            return Ok();
        }
    }
}

