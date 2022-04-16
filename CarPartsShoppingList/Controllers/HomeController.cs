using CarPartsShoppingList.Core.ViewModels;
using CarPartsShoppingList.Data;
using CarPartsShoppingList.Infrastructure.Data.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using System.Diagnostics;
using System.Security.Claims;

namespace CarPartsShoppingList.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ApplicationDbContext dbContext;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly ILogger<HomeController> logger;

        private readonly IDistributedCache cache;

        public HomeController(
            ILogger<HomeController> _logger,
            IDistributedCache _cache,
            UserManager<ApplicationUser> userManager)
        {
            logger = _logger;
            cache = _cache;
            this.userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var user = await userManager.FindByIdAsync(userId);
            var role = await userManager.GetRolesAsync(user);

            if (role.Contains("ADMINISTRATOR"))
            {
                return RedirectToAction("Index", "Admin", new { });
            }

            DateTime dateTime = DateTime.Now;
            var cachedData = await cache.GetStringAsync("cachedTime");

            if (cachedData == null)
            {
                cachedData = dateTime.ToString();
                DistributedCacheEntryOptions cacheOptions = new DistributedCacheEntryOptions()
                {
                    SlidingExpiration = TimeSpan.FromSeconds(20),
                    AbsoluteExpiration = DateTime.Now.AddSeconds(60)
                };

                await cache.SetStringAsync("cachedTime", cachedData, cacheOptions);
            }

            return View(nameof(Index), cachedData);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult UploadFile()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}