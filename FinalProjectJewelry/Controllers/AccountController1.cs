﻿using FinalProjectJewelry.Areas.Manage.ViewModels.Account;
using FinalProjectJewelry.DAL;
using FinalProjectJewelry.Extension;
using FinalProjectJewelry.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectJewelry.Controllers
{
    public class AccountController1 : Controller
    {

        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IWebHostEnvironment _env;
        private readonly AppDbContext _context;

        public AccountController1(RoleManager<IdentityRole> roleManager, IWebHostEnvironment env, AppDbContext context,
            UserManager<AppUser> userManager,
            SignInManager<AppUser> signInManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
            _signInManager = signInManager;
            _env = env;
            _context = context;
        }
        
       
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterVM registerVM)
        {
            if (!ModelState.IsValid)
            {
                return View(registerVM);
            }

            AppUser appUser = new AppUser
            {
                Name = registerVM.Name,
                Email = registerVM.Email,
                UserName = registerVM.UserName
            };

            IdentityResult identityResult = await _userManager.CreateAsync(appUser, registerVM.Password);
            if (!identityResult.Succeeded)
            {
                foreach (var item in identityResult.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
                return View(registerVM);
            }

            await _userManager.AddToRoleAsync(appUser, "Member");

            return RedirectToAction("Index", "Home");
            //return RedirectToAction("login");
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginVM loginVM)
        {
            if (!ModelState.IsValid)
            {
                return View(loginVM);
            }

            AppUser appUser = await _userManager.FindByEmailAsync(loginVM.Email);

            if (appUser == null)
            {
                ModelState.AddModelError("", "Daxil Etdiyniz Email ve ya Sifre Yanlisdir");
                return View(loginVM);
            }

            Microsoft.AspNetCore.Identity.SignInResult signInResult = await _signInManager.CheckPasswordSignInAsync(appUser, loginVM.Password, true);


            if (signInResult.IsLockedOut)
            {
                ModelState.AddModelError("", "");
                return View(loginVM);
            }

            if (!signInResult.Succeeded)
            {
                ModelState.AddModelError("", "Daxil Etdiyniz Email ve ya Sifre Yanlisdir");
                return View(loginVM);
            }

            signInResult = await _signInManager.PasswordSignInAsync(appUser, loginVM.Password, loginVM.RemindMe, true);

            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Profile()
        {
            AppUser appUser = await _userManager.FindByNameAsync(User.Identity.Name);

            ProfileVM profileVM = new ProfileVM
            {
                Name = appUser.Name,
                UserName = appUser.UserName,
                Email = appUser.Email,
                File = appUser.ProfileFile
            };

            return View(profileVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Profile(ProfileVM profileVM)
        {
            if (!ModelState.IsValid)
            {
                return View(profileVM);
            }

            bool check = false;

            AppUser appUser = await _userManager.FindByNameAsync(User.Identity.Name);

            if (appUser.Name.ToLowerInvariant() != profileVM.Name.Trim().ToLowerInvariant())
            {
                check = true;
                appUser.Name = profileVM.Name.Trim();
            }

            if (appUser.NormalizedEmail != profileVM.Email.Trim().ToUpperInvariant())
            {
                check = true;
                appUser.Email = profileVM.Email.Trim();

            }

            if (appUser.NormalizedUserName != profileVM.UserName.Trim().ToUpperInvariant())
            {
                check = true;
                appUser.UserName = profileVM.UserName.Trim();
            }

            if (check)
            {
                IdentityResult identityResult = await _userManager.UpdateAsync(appUser);

                if (!identityResult.Succeeded)
                {
                    foreach (var item in identityResult.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                    return View(profileVM);
                }
            }
            if (appUser.ProfileFile != null)
            {

                if (!appUser.ProfileFile.IsSizeOkay(5))
                {
                    ModelState.AddModelError("ImageFile", "File must be max 2mb");
                    return View();
                }
                appUser.ProfilImg = appUser.ProfileFile.SaveImg(_env.WebRootPath, "assest/img/profile");
            }

            if (!string.IsNullOrWhiteSpace(profileVM.CurrentPassword))
            {
                if (!await _userManager.CheckPasswordAsync(appUser, profileVM.CurrentPassword))
                {
                    ModelState.AddModelError("CurrentPassword", "Enter Correct Password");
                    return View(profileVM);
                }

                if (profileVM.NewPassword == profileVM.CurrentPassword)
                {
                    ModelState.AddModelError("NewPassword", "Add New Password");
                    return View(profileVM);
                }

                string token = await _userManager.GeneratePasswordResetTokenAsync(appUser);

                IdentityResult identityResult = await _userManager.ResetPasswordAsync(appUser, token, profileVM.NewPassword);

                if (!identityResult.Succeeded)
                {
                    foreach (var item in identityResult.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                    return View(profileVM);
                }
            }

            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }
    }
}
