using AnimalClinic.Controllers;
using AnimalClinic.Models.Requests;
using AnimalClinic.Services;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace AnimalClinicTests
{
    public class PetConrollerTests
    {

        private PetController _petController;

        private Mock<IPetRepository> _mockPetRepository;

        public PetConrollerTests()
        {
            _mockPetRepository = new Mock<IPetRepository>();
            _petController = new PetController(_mockPetRepository.Object);

        }
        
        [Fact]
        public void PetCreateBadRequestTest()
        {
            CreatePetRequest createPetRequest = new CreatePetRequest();
            createPetRequest.Birthday = DateTime.Now.AddYears(-35);
            createPetRequest.ClientId = 1;


            ActionResult<int> operationResult = _petController.Create(createPetRequest);

            int expectedOperationValue = 0;

            Assert.IsType<BadRequestObjectResult>(operationResult.Result);
            Assert.Equal<int>(expectedOperationValue, (int)((BadRequestObjectResult)operationResult.Result).Value);
        }
        
        

        [Theory]
        [InlineData(0)]
        [InlineData(-10)]
        [InlineData(-1000)]
        [InlineData(-54)]
        public void DeletePetBadRequestTest(int petId)
        {
            // [2] Исполнение тестируемого метода
            ActionResult<int> operationResult = _petController.Delete(petId);

            // [3] Подготовка эталонного результата (expected), проверка результата
            int expectedOperationValue = 0;


            Assert.IsType<BadRequestObjectResult>(operationResult.Result);
            Assert.Equal<int>(expectedOperationValue, (int)((BadRequestObjectResult)operationResult.Result).Value);

        }

    }
}
