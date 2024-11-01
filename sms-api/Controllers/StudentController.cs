using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using sms_api.Models;

namespace sms_api.Controllers
{
    [Route("api/student")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpGet]
        [Route("{id}")]
        public ActionResult<Student> GetName(int id)
        {
            if (id == 1)
            {
                Student std1 = new Student() { Id = 1, Name = "Yashu", Phone = 1234567898, Email = "yashu@gmail.com" };
                return Ok(std1);
            }
            else
            {
                Student std1 = new Student() { Id = id, Name = "Nidhi G S", Phone = 1234567898, Email = "yashu@gmail.com" };
                return Ok(std1);
            }
        }

    }
}
