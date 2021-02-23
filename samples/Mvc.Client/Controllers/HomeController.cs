/*
 * Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
 * See https://github.com/aspnet-contrib/AspNet.Security.OAuth.Providers
 * for more information concerning the license and the contributors participating to this project.
 */

using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Mvc.Client.Services.Discord;
using Mvc.Client.ViewModels;
using static Mvc.Client.Services.Discord.Responses;

namespace Mvc.Client.Controllers
{
    public class HomeController : Controller
    {
        private readonly IService discord;

        public HomeController(IService discord)
        {
            this.discord = discord;
        }

        [HttpGet("~/")]
        public ActionResult Index()
        {
            // Using the ClaimPrincipal
            var email = User.FindFirst(ClaimTypes.Email);

            return View();
        }

        [HttpGet("Profile")]
        public async Task<ActionResult> Profile()
        {
            User? user = await discord.GetCurrentUserAsync();
            IEnumerable<Guild>? guilds = await discord.GetCurrentUserGuildsAsync();

            ProfileVM model = new ProfileVM
            {
                Id = user?.Id,
                Email = user?.Email,
                Name = user?.Avatar,
                Guilds = guilds
            };
            return View(model);
        }
    }
}
