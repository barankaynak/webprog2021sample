using BSM.Ticaret.BLL;
using BSM.Ticaret.WebUI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BSM.Ticaret.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UrunIslem _urunIslem;

        public HomeController(ILogger<HomeController> logger, UrunIslem urunIslem)
        {
            _logger = logger;
            _urunIslem = urunIslem;
        }

        public async Task<IActionResult> Index()
        {
            var urunler = await _urunIslem.List();
            return View(urunler);
        }

        public IActionResult Ekle(int id)
        {
            List<int> liste = new List<int>();
            if (HttpContext.Session.GetString("Sepet") != null)
            {
                var sepetListStr = HttpContext.Session.GetString("Sepet");
                var eskiSepet = System.Text.Json.JsonSerializer.Deserialize<List<int>>(sepetListStr);
                liste.AddRange(eskiSepet);
            }
            liste.Add(id);
            HttpContext.Session.SetString("Sepet", System.Text.Json.JsonSerializer.Serialize(liste));
            return Ok();
        }

        public IActionResult Sepet()
        {
            var sepetListStr = HttpContext.Session.GetString("Sepet");
            var model = System.Text.Json.JsonSerializer.Deserialize<List<int>>(sepetListStr);
            return View(model);
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
