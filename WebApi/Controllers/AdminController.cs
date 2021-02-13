using Business.Abstract;
using Business.Dtos;
using Core.Entities.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private IUserService _userService;
       



        public AdminController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = _userService.GetUsers();
            return Ok(result);
        }

        [HttpPost("createuser")]
        public async Task<IActionResult> CreateUser(UserDto userDto)
        {
            var result = await _userService.CreateAsync(userDto);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Data);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(UserDto userDto)
        {
            var result = await _userService.Login(userDto);
            if (result.Success)
            {
               
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

    }
}
