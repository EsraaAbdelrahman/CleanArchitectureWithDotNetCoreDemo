using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CleanArch.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService courseService;

        public CourseController(ICourseService _courseservice)
        {
            courseService=_courseservice ;
        }
        [HttpPost]
        public IActionResult Post([FromBody] CourseViewModel course)
        {
            courseService.Create(course);
           return Ok(course);
        }
    }
}
