using Moq;
using BackendWebAPI.Controllers;
using BackendWebAPI.Services;
using BackendWebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace BackendWebAPI.Test
{
    [TestClass]
    public class PremiumCalculatorTests
    {
        private readonly Mock<IPremiumService> _serviceMock = new Mock<IPremiumService>();

        [TestMethod]
        public void PremiumController_GetPremiumOKResult()
        {
            //Arrange
            double sum = 20000;
            string occupation = "Doctor";
            int age = 25;
            double premium = 41.667;

            _serviceMock.Setup<double>(x => x.CalculatePremium(It.IsAny<PremiumDetail>())).Returns(premium);
            PremiumCalculatorController premiumCalculator = new PremiumCalculatorController(Mock.Of<Microsoft.Extensions.Logging.ILogger<PremiumCalculatorController>>(), _serviceMock.Object);

            //Act
            var result = premiumCalculator.CalculatePremium(age, sum, occupation).Result;

            //Assert
            Assert.IsInstanceOfType(result, typeof(OkObjectResult));
            var resultValue = ((OkObjectResult)result).Value;
            var resultStatusCode = (int?)((OkObjectResult)result).StatusCode;
            Assert.AreEqual(200, resultStatusCode);
            Assert.AreEqual(41.667, resultValue);
        }

        [TestMethod]
        public void PremiumController_GetPremiumBadRequest()
        {
            //Arrange
            double sum = 20000;
            string occupation = "Doctor";
            int age = 25;
            double premium = -1;

            _serviceMock.Setup<double>(x => x.CalculatePremium(It.IsAny<PremiumDetail>())).Returns(premium);
            PremiumCalculatorController premiumCalculator = new PremiumCalculatorController(Mock.Of<Microsoft.Extensions.Logging.ILogger<PremiumCalculatorController>>(), _serviceMock.Object);

            //Act
            var result = premiumCalculator.CalculatePremium(age, sum, occupation).Result;

            //Assert
            Assert.IsInstanceOfType(result, typeof(BadRequestResult));
            var resultStatusCode = (int?)((BadRequestResult)result).StatusCode;
            Assert.AreEqual(400, resultStatusCode);
        }
    }
}
