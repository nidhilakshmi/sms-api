using Microsoft.AspNetCore.Mvc;
using sms_api.Controllers;
using sms_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sms_api.test.ControllersTest
{
    public class StudentControllerTest
    {
        [Fact]
        public void GetName_WithId1_ReturnsYashu()
        {
            // Arrange
            var controller = new StudentController();

            // Act
            var response = controller.GetName(1);
            var okResult = response.Result as OkObjectResult;
            var std = (Student)okResult.Value;

            // Assert
            Assert.IsType<OkObjectResult>(okResult); // Ensure it's an OkObjectResult

            Assert.Equal(1, std.Id);
            Assert.Equal("Yashu", std.Name);
            Assert.Equal(1234567898, std.Phone);
            Assert.Equal("yashu@gmail.com", std.Email);
        }

        [Fact]
        public void GetName_WithOtherId_ReturnsNidhi()
        {
            // Arrange
            var controller = new StudentController();

            // Act
            var response = controller.GetName(10);

            // Assert
            var okResult = response.Result as OkObjectResult;
            var std = (Student)okResult.Value;

            // Assert
            Assert.IsType<OkObjectResult>(okResult); // Ensure it's an OkObjectResult
            Assert.Equal(10, std.Id);
            Assert.Equal("Nidhi G S", std.Name);
            Assert.Equal(1234567898, std.Phone);
            Assert.Equal("yashu@gmail.com", std.Email);
        }
    }
}
