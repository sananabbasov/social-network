using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;
using K401SocialApp.Business.Abstract;
using K401SocialApp.Entities.Dtos.UserDtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace K401SocialApp.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IUserService _userService;

        public AuthController(IUserService userService)
        {
            _userService = userService;
        }


        [HttpPost("register")]
        public IActionResult Register([FromBody]UserRegisterDto userRegister)
        {
            var result =_userService.Register(userRegister);
            if (result.Success)
                return Ok(result);

            return BadRequest(result);

        }
        // localhost:5000/api/auth/verifypassword?email=ehmed@compar.edu.az&token=klsdf-sfdfsd-sdfsdfs
        [HttpGet("verifypassword")]
        public IActionResult VerifyPassword([FromQuery]string email, [FromQuery] string token)
        {
            var result = _userService.VerifyEmail(email, token);
            if (result.Success)
                return Ok(result);

            return BadRequest(result);

        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] UserLoginDto userLogin)
        {
            var result = _userService.Login(userLogin);
            if (result.Success)
                return Ok(result);

            return BadRequest();

        }

        [HttpGet("me")]
        [Authorize]
        public IActionResult GetUserData()
        {
            var _bearer_token = Request.Headers[HeaderNames.Authorization].ToString().Replace("Bearer ", "");
            var handler = new JwtSecurityTokenHandler();
            var jwtSecurityToken = handler.ReadJwtToken(_bearer_token);
            var userId = jwtSecurityToken.Claims.FirstOrDefault(x => x.Type == "nameid").Value;
            int id = Convert.ToInt32(userId);
            var res = _userService.GetUserByToken(id);

            return Ok(res);
        }

    }
}

