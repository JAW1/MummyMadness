using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MummyMadness.Controllers
{
    public class RoleController : Controller
    {
        RoleManager<IdentityRole> roleManager;

        public RoleController(RoleManager<IdentityRole> roleManager)
        {
            this.roleManager = roleManager;
        }
        [Authorize(Policy = "adminpolicy")]
        public IActionResult Index()
        {
            var roles = roleManager.Roles.ToList();
            return View(roles);
        }
        [Authorize(Policy = "adminpolicy")]
        public IActionResult Create()
        {
            return View(new IdentityRole());
        }
        [Authorize(Policy = "adminpolicy")]
        [HttpPost]
        public async Task<IActionResult> Create(IdentityRole role)
        {
            await roleManager.CreateAsync(role);
            return RedirectToAction("Index");
        }
    }
}
