using Microsoft.AspNetCore.Mvc;
using SmartWorkout.DataAccess.Dtos;
using SmartWorkout.DataAccess.Entities;
using SmartWorkout.DataAccess.IRepository;
using SmartWorkout.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartWorkout.DataAccess.Controllers
{
    [Route("/api/")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private IGenericRepository<Client> _clientRepository;
        private IGenericRepository<AdminUser> _adminUserRepository;

        public AuthController(ClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        [HttpGet("check")]
        public ActionResult HealthCheck()
        {
            return Ok("Running");
        }

        [HttpPost("login")]
        public ActionResult<string> LoginUser(LoginDto loginDto)
        {
            if(_clientRepository.GetAll().FirstOrDefault(c => c.Email == loginDto.Email && c.Password == loginDto.Password) != null)
            {
                return Ok();
            }
            return Unauthorized();
        }

		[HttpPost("loginAdmin")]
		public ActionResult<string> LoginAdmin(LoginDto loginDto)
        {
			if (_adminUserRepository.GetAll().FirstOrDefault(au => au.Email == loginDto.Email && au.Password == loginDto.Password) != null)
			{
				return Ok();
			}
			return Unauthorized();
		}
    }
}
