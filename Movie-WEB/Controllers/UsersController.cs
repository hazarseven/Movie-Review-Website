﻿using AutoMapper;
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

        [AllowAnonymous]
         public IActionResult Register() => View();

        [HttpPost, ValidateAntiForgeryToken, AllowAnonymous]
        public async Task<IActionResult> Register(RegisterDTO model)
        {
            var roles = await _roleManager.Roles.ToListAsync();
            model.Roles = roles;
            if (ModelState.IsValid)
            {
                AppUser appUser = new AppUser 
                { 
                    UserName = String.Join("", model.FirstName.Normalize(NormalizationForm.FormD)
        .Where(c => char.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)).ToLower().Replace('ı', 'i') + "." + String.Join("", model.LastName.Normalize(NormalizationForm.FormD)
        .Where(c => char.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)).ToLower().Replace('ı', 'i'),
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    BirthDate = (DateTime)model.BirthDate,
                    Email = model.Email,
                };
                appUser.PasswordHash = _passwordHasher.HashPassword(appUser, model.Password);

                IdentityResult identityResult = await _userManager.CreateAsync(appUser);

                if (identityResult.Succeeded)
                {
                    var role = await _roleManager.FindByIdAsync(model.RoleId);
                    var member = new User
                    {
                        FirstName = model.FirstName,
                        LastName = model.LastName,
                        BirthDate = (DateTime)model.BirthDate,
                        Email = model.Email,
                    };
                    await _userManager.AddToRoleAsync(appUser, "member");
                    TempData["Success"] = "Kaydınız yapıldı. Giriş yapabilirsiniz...";
                    return RedirectToAction("Login");
                }
                else
                {
                    TempData["Error"] = "Kayıt yapılamadı!";
                    foreach (var error in identityResult.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                        return View(model);
                    }

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


        [Authorize(Roles = "editor, member")]
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
        [Authorize(Roles = "editor, member")]
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

        [Authorize(Roles = "editor, member")]
        public async Task<IActionResult> EditUser()
        {
            var userId = _userManager.GetUserId(HttpContext.User);
            if (userId is not null)
            {
                var appUser = await _userManager.FindByIdAsync(userId);
                var model = new EditUserDTO()
                {
                    Id = appUser.Id,
                    FirstName = appUser.FirstName,
                    LastName = appUser.LastName,
                    Email = appUser.Email,
                    BirthDate = appUser.BirthDate.ToShortDateString(),
                    UserName = appUser.UserName,
                    Password = appUser.PasswordHash,
                    CreatedDate = appUser.CreatedDate,
                    UpdatedDate = appUser.UpdatedDate
                };
                return View(model);
            }
            TempData["Error"] = "You must be logged in to view this page!";
            return RedirectToAction("Index", "Home");
        }

        [HttpPost, ValidateAntiForgeryToken]
        [Authorize(Roles = "editor, member")]
        public async Task<IActionResult> EditUser(EditUserDTO model)
        {
            if (!ModelState.IsValid)
            {
                var userId = _userManager.GetUserId(HttpContext.User);
                var appUser = await _userManager.FindByIdAsync(userId);
                if (appUser is not null)
                {
                    appUser.Email = model.Email;
                    if (model.Password != null)
                    {
                        appUser.PasswordHash = _passwordHasher.HashPassword(appUser, model.Password);
                    }
                    appUser.UpdatedDate = DateTime.Now;
                    appUser.Status = Movie_Core.Entities.Abstract.Status.Modified;

                    var result = await _userManager.UpdateAsync(appUser);
                    if (result.Succeeded)
                    {
                        TempData["Success"] = "Your information has been updated!";
                    }
                    else
                    {
                        foreach (var error in result.Errors)
                        {
                            TempData["Error"] = error.Description;
                        }
                    }
                }
            }

            else
            {
                TempData["Error"] = "Please follow the rules below!";
            }
            return View(model);
        }

        [Authorize(Roles = "editor, member")]
        public async Task<IActionResult> Logout()
        {
            if(HttpContext.User.Identity.IsAuthenticated)
            {
                await _signInManager.SignOutAsync();
                TempData["Success"] = "You have been logged out!";
                return RedirectToAction("Login");
            }

            TempData["Error"] = "You must be logged in to view this page!";
            return RedirectToAction("Index", "Home");
        }
    }
}
