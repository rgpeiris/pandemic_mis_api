using Microsoft.AspNetCore.Mvc;
using Pandemic_MIS.Services.AuthAPI.Data;
using Pandemic_MIS.Services.AuthAPI.Models;
using Pandemic_MIS.Services.AuthAPI.Models.Dto;
using Pandemic_MIS.Services.AuthAPI.Service.IService;

namespace Pandemic_MIS.Services.AuthAPI.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthAPIController : ControllerBase
    {
        private readonly IAuthService _authService;
        protected ResponseDto _response;

        public AuthAPIController(IAuthService authService, AppDbContext db)
        {
            _authService = authService;
            _response = new();
        }

        [HttpGet]
        [Route("system-users")]
        public async Task<IActionResult> GetAllUsers()
        {
            var getResponse = await _authService.GetAllUsers();
            if (getResponse == null)
            {
                _response.IsSuccess = false;
                _response.Message = "Error encountered";
                return BadRequest(_response);
            }
            _response.Result = getResponse;
            return Ok(_response);
        }

        [HttpGet]
        [Route("system-user/{username}")]
        public async Task<IActionResult> GetByUsername(string username)
        {    
            var getByUsernameResponse = await _authService.GetByUsername(username);
            if (getByUsernameResponse == null)
            {
                _response.IsSuccess = false;
                _response.Message = "Error encountered";
                return BadRequest(_response);
            }
            _response.Result = getByUsernameResponse;
            return Ok(_response);
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegistrationRequestDto model)
        {
            var errorMessage = await _authService.Register(model);
            if(!string.IsNullOrEmpty(errorMessage))
            {
                _response.IsSuccess = false;
                _response.Message = errorMessage;
                return BadRequest(_response);
            }
            return Ok(_response);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequestDto model)
        {
            var loginResponse = await _authService.Login(model);
            if(loginResponse.User ==  null) 
            {
                _response.IsSuccess = false;
                _response.Message = "The username or password is incorrect. Try again.";
                return BadRequest(_response);
            }
            _response.Result = loginResponse;
            return Ok(_response);
        }

        [HttpPost("login/public")]
        public async Task<IActionResult> LoginPublic([FromBody] LoginRequestDto model)
        {
            var loginResponse = await _authService.LoginPublic(model);
            if (loginResponse.User == null)
            {
                _response.IsSuccess = false;
                _response.Message = "The username or password is incorrect. Try again.";
                return BadRequest(_response);
            }
            _response.Result = loginResponse;
            return Ok(_response);
        }

        [HttpPost("assign-role")]
        public async Task<IActionResult> AssignRole([FromBody] RegistrationRequestDto model)
        {
            var assignRoleResponse = await _authService.AssignRole(model.UserName, model.Role.ToUpper());
            if (!assignRoleResponse)
            {
                _response.IsSuccess = false;
                _response.Message = "Error encountered";
                return BadRequest(_response);
            }
            return Ok(_response);
        }

        [HttpPut("system-user/{userId}")]
        public async Task<IActionResult> UpdateUser(string userId, [FromBody] UpdateUserRequestDto model)
        {
            var errorMessage = await _authService.UpdateUser(userId, model);
            if (!string.IsNullOrEmpty(errorMessage))
            {
                _response.IsSuccess = false;
                _response.Message = errorMessage;
                return BadRequest(_response);
            }
            return Ok(_response);
        }
    }
}
