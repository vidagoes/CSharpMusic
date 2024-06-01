using CSharpMusic.Data;
using CSharpMusic.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CSharpMusic.Controllers
{
    public class HomeController : Controller
    {
        private readonly CSharpMusicContext _context;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, CSharpMusicContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Produto.ToList());
        }

        public IActionResult Privacy()
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
