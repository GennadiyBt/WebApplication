using AnimalClinic.Models;
using AnimalClinic.Models.Requests;
using AnimalClinic.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace AnimalClinic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private IClientRepository _clientRepository;

        public ClientController(IClientRepository clientRepository) {
            _clientRepository = clientRepository;
        }

        [HttpPost("create")]
        [SwaggerOperation(OperationId = "ClientCreate")]
        public ActionResult<int> Create([FromBody] CreateClientRequest createClientRequest)
        {
            Client client = new Client();
            client.Document = createClientRequest.Document;
            client.SurName = createClientRequest.SurName;
            client.FirstName = createClientRequest.FirstName;
            client.Birthday = createClientRequest.Birthday;
            client.Patronymic = createClientRequest.Patronymic;
            int res = _clientRepository.Create(client);
            return Ok(res);
        }

        [HttpPut("update")]
        [SwaggerOperation(OperationId = "ClientUpdate")]
        public ActionResult<int> Update([FromBody] UpdateClientRequest updateClientRequest)
        {
            Client client = new Client();
            client.ClientId = updateClientRequest.ClientId;
            client.Document = updateClientRequest.Document;
            client.SurName = updateClientRequest.SurName;
            client.FirstName = updateClientRequest.FirstName;
            client.Patronymic = updateClientRequest.Patronymic;
            client.Birthday = updateClientRequest.Birthday;
            int res = _clientRepository.Update(client);
            return Ok(res);
        }

        [HttpDelete("delete")]
        [SwaggerOperation(OperationId = "ClientDelete")]
        public ActionResult<int> Delete([FromQuery] int clientId)
        {
            int res = _clientRepository.Delete(clientId);
            return Ok(res);
        }

        [HttpGet("get-all")]
        [SwaggerOperation(OperationId = "ClientGetAll")]
        public ActionResult<List<Client>> GetAll()
        {
            List<Client> clients = _clientRepository.GetAll();
            return Ok(clients);
        }

        [HttpGet("get-by-id")]
        [SwaggerOperation(OperationId = "ClientGetById")]
        public ActionResult<Client> GetById ([FromQuery] int clientId) {
            Client client = _clientRepository.GetById(clientId);
            return Ok(client);
        }
    }
}
