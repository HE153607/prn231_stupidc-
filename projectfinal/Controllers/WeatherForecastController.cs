using Backend.Database;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Reflection;
using System.Security.Claims;
using System.Text;

namespace projectfinal.Controllers
{
    
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private IHttpContextAccessor _httpContextAccessor;
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController( IHttpContextAccessor httpContextAccessor)
        {
            //_logger = logger;
            _httpContextAccessor = httpContextAccessor;
        }

        [Authorize]
        [HttpGet]
        [Route("test")]
        public IActionResult test()
        {
            //var context = _httpContextAccessor.HttpContext;
            //string headerValue = context.Request.Headers["Authorization"];
            return Ok();
        }

        //[Authorize]
        [HttpGet(Name = "GetWeatherForecast")]
        public string Get()
        {
            //var context = _httpContextAccessor.HttpContext;

            // Lấy giá trị của header từ HttpContext
            //string headerValue = context.Request.Headers["Authorization"];
            var authClaims = new List<Claim>
            {
                new Claim(ClaimTypes.Email, "email"),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            var authenKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("fhdefdfhbejen589anwqitzdhgkvkf7heheQGHEZWTnguyenhoanganh0000123456789"));

            var token = new JwtSecurityToken(
                issuer: "http://localhost:5075",
                audience: "user",
                expires: DateTime.Now.AddMinutes(20),
                claims: authClaims,
                signingCredentials: new SigningCredentials(authenKey, SecurityAlgorithms.HmacSha512Signature)
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}