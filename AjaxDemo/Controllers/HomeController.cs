using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AjaxDemo.Models;

namespace AjaxDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Chess()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }

        [HttpGet]
        public bool GetInfo(string type, int x1, int y1, int x2, int y2)
        { //https://localhost:5001/Home/GetInfo?type=horse&x1=1&y1=2&x2=3&y2=4
            return type.ToLower() switch
            {
                "pawn" => ChessLogic.Pawn(x1, y1, x2, y2),
                "bishop" => ChessLogic.Bishop(x1, y1, x2, y2),
                "king" => ChessLogic.King(x1, y1, x2, y2),
                "queen" => ChessLogic.Queen(x1, y1, x2, y2),
                "knight" => ChessLogic.Knight(x1, y1, x2, y2),
                "rook" => ChessLogic.Rook(x1, y1, x2, y2),
                _ => false
            };
        }
    }
}