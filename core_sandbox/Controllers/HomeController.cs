using core_sandbox.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace core_sandbox.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [HttpGet]
        public IActionResult GetDepartmentPerformance(int teamId)
        {
            try
            {
                switch (teamId)
                {
                    case 1:
                        var teams = new List<string>() { "Team A", "Team B" };
                        var performance = new List<int>() { 44, 33 };
                        var jsonObject = new
                        {
                            teams = teams,
                            performance = performance
                        };
                        return Json(jsonObject);
                    case 2:
                        var teams2 = new List<string>() { "Team A", "Team B", "Team C" };
                        var performance2 = new List<int>() { 15, 23, 17 };
                        var jsonObject2 = new
                        {
                            teams = teams2,
                            performance = performance2
                        };
                        return Json(jsonObject2);
                    case 3:
                        var teams3 = new List<string>() { "Team A", "Team B", "Team C", "Team D" };
                        var performance3 = new List<int>() { 89, 37, 21, 54 };
                        var jsonObject3 = new
                        {
                            teams = teams3,
                            performance = performance3
                        };
                        return Json(jsonObject3);
                    default:
                        return Json("No data found");
                }

            }
            catch (Exception ex)
            {

                ViewBag.error = ex.Message;
                return Json("No data found");
            }
        }
        [HttpGet]
        public IActionResult GetDepartmentPerformance1(int teamId)
        {
            try
            {
                switch (teamId)
                {
                    case 1:
                        var teams = new List<string>() { "Team A", "Team B" };
                        var performance = new List<int>() { 44, 33 };
                        var jsonObject = new
                        {
                            teams = teams,
                            performance = performance
                        };
                        return Json(jsonObject);
                    case 2:
                        var teams2 = new List<string>() { "Team A", "Team B", "Team C","Team D","Team E","Team F" };
                        var performance2 = new List<int>() { 15, 23, 17,64,32,45 };
                        var jsonObject2 = new
                        {
                            teams = teams2,
                            performance = performance2
                        };
                        return Json(jsonObject2);
                    case 3:
                        var teams3 = new List<string>() { "Team A", "Team B", "Team C", "Team D" };
                        var performance3 = new List<int>() { 89, 37, 21, 54 };
                        var jsonObject3 = new
                        {
                            teams = teams3,
                            performance = performance3
                        };
                        return Json(jsonObject3);
                    default:
                        return Json("No data found");
                }

            }
            catch (Exception ex)
            {

                ViewBag.error = ex.Message;
                return Json("No data found");
            }
        }


    }
}
