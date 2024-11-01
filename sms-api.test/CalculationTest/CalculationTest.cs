using sms_api.Calculations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sms_api.test.CalculationTest
{
    public class CalculationTest
    {
        [Fact]
        public void GetPercentage_Maxmarkswith0_Return0()
        {
            //Arrange
            Calculator calculator = new Calculator();
            //Act
            var response = calculator.GetPercentage(0,24);
            //Assert
            Assert.Equal(0, response);
        }

        [Fact]
        public void GetPercentage_ValidMaxMaxrks_ReturnValidPercentage()
        {
            //Arrange
            Calculator calculator = new Calculator();
            //Act
            var response = calculator.GetPercentage(20, 10);
            //Assert
            Assert.Equal(50, response);
        }

        [Fact]
        public void GetAverage_NumberOfSubjects0_return0()
        {
            //Arrange
            Calculator calculator = new Calculator();
            //Act
            var response = calculator.GetAverage(200, 0);
            //Assert
            Assert.Equal(0, response);

        }

        [Fact]
        public void GetAverage_WithValidSubjectsNumber_Return_Valid()
        {
            //Arrange
            Calculator calculator = new Calculator();
            //Act
            var response = calculator.GetAverage(100, 10);
            //Assert
            Assert.Equal(10, response);
        }
    }
}
