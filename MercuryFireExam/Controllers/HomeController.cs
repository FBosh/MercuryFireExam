﻿using MercuryFireExam.Bases;
using Microsoft.AspNetCore.Mvc;

namespace MercuryFireExam.Controllers
{
    public class HomeController : MercuryFireExamControllerBase
    {
        [HttpGet]
        public IActionResult Get([FromServices] IWebHostEnvironment env) => Ok($"{env.ApplicationName}: {env.EnvironmentName}");
    }
}
