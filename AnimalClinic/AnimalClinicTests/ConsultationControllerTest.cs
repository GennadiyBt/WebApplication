using AnimalClinic.Controllers;
using AnimalClinic.Models.Requests;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalClinicTests
{
    public class ConsultationControllerTest
    {
        private ConsultationController _consultationController;

        public ConsultationControllerTest()
        {
            _consultationController = new ConsultationController();
        }

        [Fact]
        public void ConsultationCreateBadRequestTest()
        {
            CreateConsultationRequest createConsultatioRequest = new CreateConsultationRequest();
            createConsultatioRequest.ConsultationDate = DateTime.Now.AddYears(-10);
            createConsultatioRequest.ClientId = 1;
            createConsultatioRequest.PetId = 1;
            createConsultatioRequest.Description = "test string";


            ActionResult<int> operationResult = _consultationController.Create(createConsultatioRequest);

            int expectedOperationValue = 0;

            Assert.IsType<BadRequestObjectResult>(operationResult.Result);
            Assert.Equal<int>(expectedOperationValue, (int)((BadRequestObjectResult)operationResult.Result).Value);
        }

        [Fact]
        public void ConsultationCreateTest()
        {
            // МЕТОД ТЕСТИРОВАНИЯ СОСТОИТ ИЗ УСЛОВНЫХ 3 ЧАСТЕЙ

            // [1] Подготовка данных для тестирования
            CreateConsultationRequest createConsultatioRequest = new CreateConsultationRequest();
            createConsultatioRequest.Description = "Персик";
            createConsultatioRequest.ConsultationDate = DateTime.Now.AddYears(-1);
            createConsultatioRequest.ClientId = 1;
            createConsultatioRequest.PetId = 1;

            // [2] Исполнение тестируемого метода
            ActionResult<int> operationResult = _consultationController.Create(createConsultatioRequest);

            // [3] Подготовка эталонного результата (expected), проверка результата
            int expectedOperationValue = 1;


            Assert.IsType<OkObjectResult>(operationResult.Result);
            Assert.Equal<int>(expectedOperationValue, (int)((OkObjectResult)operationResult.Result).Value);

        }

        [Theory]
        [InlineData(0)]
        [InlineData(-10)]
        [InlineData(-1000)]
        [InlineData(-54)]
        public void DeletePetBadRequestTest(int consultationId)
        {
            // [2] Исполнение тестируемого метода
            ActionResult<int> operationResult = _consultationController.Delete(consultationId);

            // [3] Подготовка эталонного результата (expected), проверка результата
            int expectedOperationValue = 0;


            Assert.IsType<BadRequestObjectResult>(operationResult.Result);
            Assert.Equal<int>(expectedOperationValue, (int)((BadRequestObjectResult)operationResult.Result).Value);

        }

        [Theory]
        [InlineData(1)]
        [InlineData(10)]
        [InlineData(1000)]
        [InlineData(54)]
        public void DeletePetTest(int consultationId)
        {
            // [2] Исполнение тестируемого метода
            ActionResult<int> operationResult = _consultationController.Delete(consultationId);

            // [3] Подготовка эталонного результата (expected), проверка результата
            int expectedOperationValue = 1;


            Assert.IsType<OkObjectResult>(operationResult.Result);
            Assert.Equal<int>(expectedOperationValue, (int)((OkObjectResult)operationResult.Result).Value);

        }



    }
}
