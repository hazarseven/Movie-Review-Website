using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Movie_Core.DTO_s.UserDTO;
using Movie_Core.Entities.UserEntities.Concrete;
using Movie_DataAccess.Services.Interface;

namespace Movie_WEB.Controllers
{
    public class UsersController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IPasswordHasher<AppUser> _passwordHasher;
        private readonly IUserRepository _userRepository;
        private readonly RoleManager<IdentityRole> _roleManager;

        public UsersController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, IPasswordHasher<AppUser> passwordHasher, IUserRepository userRepository, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _passwordHasher = passwordHasher;
            _userRepository = userRepository;
            _roleManager = roleManager;
        }
        public async Task<IActionResult> Register()
        {
            var roles = await _roleManager.Roles.ToListAsync();
            var model = new RegisterDTO() { Roles = roles };

            return View(model);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterDTO model)
        {
            var roles = await _roleManager.Roles.ToListAsync();

        }
    }
}
