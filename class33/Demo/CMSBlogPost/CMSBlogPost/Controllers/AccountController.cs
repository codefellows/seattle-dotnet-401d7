using CMSBlogPost.Models;
using CMSBlogPost.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace CMSBlogPost.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<ApplicationUser> _userManager;
        private SignInManager<ApplicationUser> _signInManager;
        private readonly IEmailSender _emailSender;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, IEmailSender email)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _emailSender = email;
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel rvm)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser user = new ApplicationUser
                {
                    UserName = rvm.Email,
                    Email = rvm.Email,
                    FirstName = rvm.FirstName,
                    LastName = rvm.LastName,
                    Birthday = rvm.Birthday
                };

                var result = await _userManager.CreateAsync(user, rvm.Password);

                if (result.Succeeded)
                {

                    Claim nameClaim = new Claim("FullName", $"{user.FirstName} {user.LastName}");

                    Claim bdClaim = new Claim(ClaimTypes.DateOfBirth, new DateTime(user.Birthday.Year, user.Birthday.Month, user.Birthday.Day).ToString("u"), ClaimValueTypes.DateTime);

                    Claim email = new Claim(ClaimTypes.Email, user.Email, ClaimValueTypes.Email);
                    List<Claim> claims = new List<Claim> { nameClaim, bdClaim, email };

                    await _userManager.AddClaimsAsync(user, claims);

                    // Give the user a role. 
                    if(rvm.Email.ToLower() == "amanda@codefellows.com")
                    {
                        await _userManager.AddToRoleAsync(user, ApplicationRoles.Admin);
                    }

                    await _userManager.AddToRoleAsync(user, ApplicationRoles.Member);

                    StringBuilder sb = new StringBuilder();

                    sb.AppendLine("<h1>Welcome To My Website!!</h1>");
                    sb.AppendLine("The Items that you have purchased are: <ul>");
                    // Foreach loop over all the basket items.....
                    sb.Append("<li>NAME OF ITEM and PRICE</li>");
                    sb.Append("String interpolation DOES WORK with SB!");

                    // outside of my foreach loop
                    sb.Append("</ul>");
                    sb.ToString();

                    await _emailSender.SendEmailAsync(rvm.Email, "Thank you for registering", "<p> Hello Welcome </p>");

                    // Sign the user in
                    await _signInManager.SignInAsync(user, isPersistent: false);

                    // redirect to the home page
                    return RedirectToAction("Index", "Home");

                }

            }
            return View(rvm);

        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel lvm)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(lvm.Email, lvm.Password, false, false);
                if (result.Succeeded)
                {
                    // REdirect to the home page

                    return RedirectToAction("Index", "Home");
                }

                ModelState.AddModelError(string.Empty, "Invalid Login Attempt");

            }
            ModelState.AddModelError(string.Empty, "Please see below for errors");  
           
            return View(lvm);
        }
    }
}