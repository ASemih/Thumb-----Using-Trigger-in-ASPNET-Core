using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TriggerInEFCore.Interface;
using TriggerInEFCore.Model;

namespace TriggerInEFCore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentRepository _studentRepository;

        public StudentsController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Student student)
        {
            _studentRepository.Add(student);
            if (await _studentRepository.SaveChangesAsync())
            {
                return Ok(student);
            }
            return BadRequest();
        }
    }
}
