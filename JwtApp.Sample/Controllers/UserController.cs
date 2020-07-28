using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace JwtApp.Sample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly JwtSettings _jwtSettings;
        public UserController(IOptions<JwtSettings> jwtSettings)
        {
            _jwtSettings = jwtSettings.Value;
        }

        [HttpPost]
        [Route("get_token")]
        public IActionResult GetToken()
        {
            return Ok(JwtHelper.Token(_jwtSettings));
        }

        [Authorize]
        [HttpPost]
        [Route("get_user")]
        public IActionResult GetUser()
        {
            //获取当前请求用户的信息，包含token信息
            var user = HttpContext.User;
            return Ok();
        }
    }
}
