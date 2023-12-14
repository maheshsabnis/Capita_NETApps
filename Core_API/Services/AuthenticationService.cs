using Core_API.Models;
using Microsoft.AspNetCore.Identity;

namespace Core_API.Services
{
    public class AuthenticationService
    {
        UserManager<IdentityUser>? userManager;
        SignInManager<IdentityUser>? signInManager;
        RoleManager<IdentityRole>? roleManager;

        public AuthenticationService(UserManager<IdentityUser> user, RoleManager<IdentityRole> role, SignInManager<IdentityUser> sign)
        {
            userManager=user;
            signInManager=sign;
            roleManager=role;
        }


        public async Task<bool> RegisterUserAsync(RegisterUser user)
        {
            bool isSuccess = false;

            // 1. Create IdentityUser

            var regUser = new IdentityUser()
            { 
               Email = user.Email,
               UserName = user.Email
            };

            // 2. Create User
            var result = await userManager.CreateAsync(regUser, user.Password);
            if (result.Succeeded)
            {
                isSuccess = true;
            }
            return isSuccess;
        }

        public async Task<bool> AuthenticateUser(LoginUser user)
        {
            bool isSuccess = false;

            // 1. Create IdentityUser
            var authUser = new IdentityUser()
            {
                Email = user.UserName,
                UserName = user.UserName
            };
            // 2. Sign In User
            var result = await signInManager.PasswordSignInAsync(user.UserName, user.Password, false, true);
            if (result.Succeeded) 
            {
                isSuccess = true;
            }
            return isSuccess;
        }


        public async Task<bool> CreateRoleAsync(RoleInfo role)
        { 
            bool isSuccess = false;
            //1. Create a IdentityRole

            var newRole = new IdentityRole()
            {
                 Name = role.RoleName
            };

            // Check if the role already exist
            
            var result = await roleManager.CreateAsync(newRole);
            if (result.Succeeded) 
            {
                isSuccess = true;
            }

            return isSuccess;
        }


        public async Task<bool> AssignRoleToUserAsync(UserInRole info)
        {
            bool isSuccess = false;

            // 1. Check if Role Exist
            // 2. Check if User Exist
            var user = await userManager.FindByNameAsync(info.UserName);
            // 3. Check if the User Already Have Role
            
             
            var result = await userManager.AddToRoleAsync(user, info.RoleName);
            if (result.Succeeded)
            {
                isSuccess = true;
            }
            return isSuccess; 
        }

    }
}
