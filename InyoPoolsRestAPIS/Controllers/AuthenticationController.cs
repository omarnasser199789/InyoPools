using InyoPools.Core.Domain.Model;
using InyoPools.Core.Domain.Model.Authentication;
using InyoPools.Core.Domain.Model.Authentication.Login;
using InyoPools.Core.Domain.Model.Authentication.SignUp;
using InyoPoolsRest.API.Application.Aithentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Microsoft.VisualBasic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Policy;
using System.Text;

namespace InyoPoolsRest.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IEmailService _emailService;
        private readonly IConfiguration _configuration;

        public AuthenticationController(
            UserManager<IdentityUser> userManager,
            RoleManager<IdentityRole> roleManager,
            IEmailService emailService,
            IConfiguration configuration)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _emailService = emailService;
            _configuration = configuration; 
        }

        [HttpPost]
        public async Task<IActionResult> Register([FromBody] RegisterUser registerUser, string role)
        {
            //Check User Exist
            var userExist = await _userManager.FindByEmailAsync(registerUser.Email);
            if (userExist != null)
            {
                return StatusCode(StatusCodes.Status403Forbidden, new Response { Status = "Error", Message = "User already exist!" });
            }

            //Add the User in the database

            IdentityUser user = new()
            {
                Email = registerUser.Email,
                SecurityStamp = Guid.NewGuid().ToString(),
                UserName = registerUser.Username

            };

            if (await _roleManager.RoleExistsAsync(role))
            {
                var result = await _userManager.CreateAsync(user, registerUser.Password);
                if (!result.Succeeded)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "User Failed to Create" });
                }

                //Add role to user....

                await _userManager.AddToRoleAsync(user, role);

                //Add Token to Verify the eamil...
                var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                var confirmationLink = Url.Action(nameof(ConfirmEmail), "Authentication", new { token, email = user.Email }, Request.Scheme);
                var message = new Message(new string[] { user.Email }, "Confirmation email link", confirmationLink!);
                _emailService.SendEmail(message);





                return StatusCode(StatusCodes.Status200OK,
                    new Response { Status = "Success", Message = $"User Created & Email Sent to {user.Email} Successfully" });

            }
            else
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "This Role Doesnot Exist." });

            }




        }


        [HttpGet("ConfirmEmail")]
        public async Task<IActionResult> ConfirmEmail(string token, string email)
        {
            var user = await _userManager.FindByEmailAsync(email);
            if (user != null)
            {
                var result = await _userManager.ConfirmEmailAsync(user, token);
                if (result.Succeeded)
                {
                    return StatusCode(StatusCodes.Status200OK,
                        new Response { Status = "Success", Message = "Email Verfied SuccessFully" });
                }
            }

            return StatusCode(StatusCodes.Status500InternalServerError,
                new Response { Status = "Error", Message = "This User Doesnot exist!" });



        }


        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] LoginModel loginModel) {


            //checking the user
            var user = await _userManager.FindByEmailAsync(loginModel.Email);

            if (user == null)
            {
                // User not found
                return BadRequest("Invalid email.");
            }

            // Check if the password is correct
            if (!await _userManager.CheckPasswordAsync(user, loginModel.Password))
            {
               
            }

            //checking the password
            if (await _userManager.CheckPasswordAsync(user, loginModel.Password))
            {




                //claimlist creation


                var authClaims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.UserName),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                };


                //we add roles to the list

                var userRoles = await _userManager.GetRolesAsync(user);
                foreach (var role in userRoles)
                {
                    authClaims.Add(new Claim(ClaimTypes.Role, role));
                }





                //generate the token with claims
                var jwtToken = GetToken(authClaims);

                //returning the token 
                return Ok(new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(jwtToken),
                    expiration = jwtToken.ValidTo
                });
            }
            else {
                // Incorrect password
                return BadRequest("Invalid password.");
            }

            
          


        
        }

        private JwtSecurityToken GetToken(List<Claim> authClaims) 
        {
            var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"]));


            var token = new JwtSecurityToken(
                issuer: _configuration["JWT:ValidIssuer"],
                audience: _configuration["JWT:ValidAudience"],
                expires: DateTime.Now.AddHours(24),
                //expires: new DateTime(9999, 12, 31),
                claims: authClaims,
                signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
                );

            return token;
        }


        [HttpPost("ChangePassword")]
        public async Task<IActionResult> ChangePassword([FromBody] ChangePassword.Request changePasswordModel)
        {
            var user = await _userManager.FindByEmailAsync(changePasswordModel.Username);

            if (user == null)
            {
                return BadRequest(new Response { Status = "Error", Message = "User not found." });
            }

            // Check old password
            var result = await _userManager.CheckPasswordAsync(user, changePasswordModel.OldPassword);
            if (!result)
            {
                return BadRequest(new Response { Status = "Error", Message = "Invalid old password." });
            }

            // Check new password and confirmation
            if (changePasswordModel.NewPassword != changePasswordModel.ConfirmPassword)
            {
                return BadRequest(new Response { Status = "Error", Message = "New password and confirmation do not match." });
            }

            // Change password
            var changeResult = await _userManager.ChangePasswordAsync(user, changePasswordModel.OldPassword, changePasswordModel.NewPassword);

            if (!changeResult.Succeeded)
            {
                var errorMessage = changeResult.Errors.FirstOrDefault()?.Description ?? "Error changing password.";
                return BadRequest(new Response { Status = "Error", Message = errorMessage });
            }

            return Ok(new Response { Status = "Success", Message = "Password changed successfully." });
        }

    }
}
