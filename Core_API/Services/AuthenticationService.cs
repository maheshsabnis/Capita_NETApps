using Core_API.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace Core_API.Services
{
    public class AuthenticationService
    {
        UserManager<IdentityUser>? userManager;
        SignInManager<IdentityUser>? signInManager;
        RoleManager<IdentityRole>? roleManager;
        /* COntract to Read appSettings.json */
        IConfiguration configuration;
    
        public AuthenticationService(UserManager<IdentityUser> user, RoleManager<IdentityRole> role, SignInManager<IdentityUser> sign, IConfiguration config)
        {
            userManager=user;
            signInManager=sign;
            roleManager=role;
            configuration=config;
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

        public async Task<SecurityResponse> AuthenticateUser(LoginUser user)
        {
            bool isSuccess = false;

            SecurityResponse response = new SecurityResponse();

            // 1. Create IdentityUser
            //var authUser = new IdentityUser()
            //{
            //    Email = user.UserName,
            //    UserName = user.UserName
            //};

            // Get the UserId based on Name
            var authUser = await userManager.FindByNameAsync(user.UserName);


            // 2. Sign In User
            var result = await signInManager.PasswordSignInAsync(user.UserName, user.Password, false, true);
            if (result.Succeeded) 
            {
                #region Code for Generating Token
                // 2.a. Read Secret Key and Expiry from appsettings.json
                var secretKey = Convert.FromBase64String(configuration["JWTSettings:SecretKey"]);
                var expiry = Convert.ToInt32(configuration["JWTSettings:ExpiryInMinuts"]);

                //2.b. Use SecurityTokenDescriptor to define a token description
                // e.g. Issuer, Audience, Claim, Signeture

                var securityTokenDeescriptor = new SecurityTokenDescriptor()
                {
                    Issuer = null, /*No Third Party Issuer*/
                    Audience = null, /*The Current App is Audience itself*/
                    /* Define Claims using Subject*/
                    Subject = new System.Security.Claims.ClaimsIdentity(new List<Claim> { 
                        /* The UserId will be stored in the claim i.e. in Payload */
                      new Claim("userid", authUser.Id)
                    }),

                    Expires = DateTime.UtcNow.AddMinutes(expiry),
                    IssuedAt =  DateTime.UtcNow,
                    NotBefore = DateTime.UtcNow,
                    /* The Signeture */
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(secretKey), SecurityAlgorithms.HmacSha256)
                };


                // 2.c. Generate the Token
                var jwtHandler = new JwtSecurityTokenHandler();
                /*2.d. Create a token*/
                var jwtToken = jwtHandler.CreateJwtSecurityToken(securityTokenDeescriptor);

                /* 2.e. Write the Token in Headfer.Payload.Signerture form to Response*/
                response.Token = jwtHandler.WriteToken(jwtToken);
                #endregion

                isSuccess = true;
                response.IsSuccess = isSuccess;
            }
            return response;
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
