using Core_API.Models;
using Core_API.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Core_API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        AuthenticationService authenticationService;
        /// <summary>
        /// Inject the AuthenticationService
        /// </summary>
        /// <param name="serv"></param>
        public AuthController(AuthenticationService serv)
        {
            authenticationService = serv;
        }

        [HttpPost]
        [ActionName("createuser")]
        public async Task<IActionResult> CreateUser(RegisterUser user)
        {
            try
            {
                var isUserCreated = await authenticationService.RegisterUserAsync(user);
                if (isUserCreated) 
                {
                    return Ok($"User {user.Email} is created Successfully");
                }
                return BadRequest($"Error Occurred While Creating User");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [ActionName("authuser")]
        public async Task<IActionResult> AuthUser(LoginUser user)
        {
            try
            {
                var response = await authenticationService.AuthenticateUser(user);
                if (response.IsSuccess)
                {
                    return Ok(response);
                }
                return BadRequest($"Error Occurred While Authenticating User");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [ActionName("createrole")]
        public async Task<IActionResult> RegisterRoleAsync(RoleInfo role)
        {
            try
            {
                var isRoleCreated = await authenticationService.CreateRoleAsync(role);
                if (isRoleCreated)
                {
                    return Ok($"Role {role.RoleName} is created Successfully");
                }
                else
                {
                    return BadRequest($"Error Occurred While creating role");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpPost]
        [ActionName("addroletouser")]
        public async Task<IActionResult> AddRoleToUserAsync(UserInRole info)
        {
            try
            {
                var isRoleAssigned = await authenticationService.AssignRoleToUserAsync(info);
                if (isRoleAssigned)
                {
                    return Ok($"Role {info.RoleName} is  Successfully assigned to User {info.UserName}");
                }
                else
                {
                    return BadRequest($"Error Occurred While assigning role to user");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
