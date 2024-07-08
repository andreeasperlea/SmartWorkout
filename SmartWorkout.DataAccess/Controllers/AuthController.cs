using Microsoft.AspNetCore.Mvc;
using SmartWorkout.DataAccess.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartWorkout.DataAccess.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private IRepository _clientRepository;
        [HttpPost("login")]
        public ActionResult<string> Login(LoginDto loginDto)
        {

        }
    }
}
