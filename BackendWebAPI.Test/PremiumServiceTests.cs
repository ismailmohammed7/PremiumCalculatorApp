using BackendWebAPI.Models;
using BackendWebAPI.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendWebAPI.Test
{

    [TestClass]
    public class PremiumServiceTests
    {
        [TestMethod]
        public void CalculatePremium_ReturnNonZeroValue()
        {
            //Arrange
            PremiumDetail premiumDetail = new PremiumDetail
            {
                Age = 25,
                SumInsured = 20000,
                Occupation = "Doctor"
            };
            PremiumService premiumService = new PremiumService();

            //Act
            double premium = premiumService.CalculatePremium(premiumDetail);

            //Assert
            Assert.AreEqual(41.667, premium);
        }

        [TestMethod]
        public void CalculatePremium_ReturnNegativeValueInCaseofBadRequest()
        {
            //Arrange
            PremiumDetail premiumDetail = new PremiumDetail
            {
                Age = -25,
                SumInsured = 20000,
                Occupation = "Doctor"
            };
            PremiumService premiumService = new PremiumService();

            //Act
            double premium = premiumService.CalculatePremium(premiumDetail);

            //Assert
            Assert.AreEqual(-41.667, premium);
        }

    }
}
