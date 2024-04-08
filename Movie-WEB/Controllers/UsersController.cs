using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Movie_Core.DTO_s.UserDTO;
using Movie_Core.Entities.Concrete;
using Movie_Core.Entities.UserEntities.Concrete;
using Movie_DataAccess.Services.Interface;
using System.Globalization;
using System.Text;

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
            model.Roles = roles;

            if (ModelState.IsValid)
            {
                var appUser = new AppUser
                {
                    UserName = String.Join("", model.FirstName.Normalize(NormalizationForm.FormD)
        .Where(c => char.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)).ToLower().Replace('ı', 'i') + "." + String.Join("", model.LastName.Normalize(NormalizationForm.FormD)
        .Where(c => char.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)).ToLower().Replace('ı', 'i'),
                    Email = model.Email,    
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    BirthDate = (DateTime)model.BirthDate
                };

                appUser.PasswordHash = _passwordHasher.HashPassword(appUser, model.Password);

                IdentityResult result = await _userManager.CreateAsync(appUser);

                if (result.Succeeded)
                {
                    var role = await _roleManager.FindByIdAsync(model.RoleId);

                    var user = new User
                    {
                        FirstName = model.FirstName,
                        LastName = model.LastName,
                        BirthDate = (DateTime)model.BirthDate,
                        Email = model.Email,
                    };
                    await _userRepository.AddAsync(user);

                    TempData["Success"] = $"Hoşgeldiniz. Giriş yapma sayfasına yönlendiriliyorsunuz...";
                    return RedirectToAction("Login");
                }
                else
                {
                    TempData["Error"] = "Kayıt yapılamadı!";
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                    return View(model);
                }
            }
            TempData["Error"] = "Lütfen aşağıdaki kurallara uyunuz!";
            return View(model);
        }

        [AllowAnonymous]
        public IActionResult Login() => View();

        [HttpPost, ValidateAntiForgeryToken, AllowAnonymous]
        public async Task<IActionResult> Login(LoginDTO model)
        {
            if (ModelState.IsValid)
            {
                var appUser = await _userManager.FindByNameAsync(model.UserName);

                if (appUser != null)
                {
                    Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(model.UserName, model.Password, false, false);

                    if (result.Succeeded)
                    {
                        if (await _userManager.IsInRoleAsync(appUser, "editor"))
                        {
                            TempData["Success"] = "Sayın Editör Hoşgeldiniz!";
                            return RedirectToAction("Index", "Dashboard", new { area = "Admin" });
                        }
                        TempData["Success"] = $"Hoşgeldiniz {appUser.FirstName} {appUser.LastName}";
                        return RedirectToAction("Index", "Home");
                    }
                    TempData["Error"] = "Giriş yapılamadı!";
                    return View(model);
                }
                TempData["Error"] = "Kullanıcı adı veya şifre yanlış!";
                return View(model);
            }
            TempData["Error"] = "Lütfen aşağıdaki kurallara uyunuz!";
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> ChangePassword(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user != null)
            {
                var model = new ChangePasswordDTO() { Id = id };
                return View(model);
            }
            TempData["Error"] = "Kullanıcı bulunamadı!";
            return RedirectToAction("Login");
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangePassword(ChangePasswordDTO model)
        {
            if(ModelState.IsValid)
            {
                if (model.OldPassword == model.Password)
                {
                    TempData["Error"] = "Yeni şifreniz eski şifrenizle aynı olamaz!";
                    return View(model);
                }
                if (model.Password == model.PasswordCheck)
                {
                    var appUser = await _userManager.FindByIdAsync(model.Id);
                    var result = await _userManager.ChangePasswordAsync(appUser, model.OldPassword, model.Password);
                    if (result.Succeeded)
                    {
                        await _signInManager.SignOutAsync();
                        TempData["Success"] = "Şifreniz kaydedildi. Yeni şifreniz ile giriş yapabilirsiniz!";
                        return RedirectToAction("Login");
                    }
                }
                TempData["Error"] = "Şifreleriniz uyuşmuyor!";
                return View(model);
            }
            TempData["Error"] = "Lütfen aşağıdaki kurallara uyunuz!";
            return View(model);
        }


    }
}
