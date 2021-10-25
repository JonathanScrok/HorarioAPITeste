using HorarioAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HorarioAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BeaHelperLoginController : ControllerBase
    {
        private readonly ILogger<BeaHelperLoginController> _logger;

        public BeaHelperLoginController(ILogger<BeaHelperLoginController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            return " Acesso a controller de Login";
        }

        [HttpGet("login")]
        public IEnumerable<Login> GetLogin()
        {
            return Enumerable.Range(1, 5).Select(index => new Login
            {
                Id_Usuario = 1212121,
                Email = "teste@gmail.com",
                Senha = "100101"
            })
            .ToArray();
        }
    }

}

