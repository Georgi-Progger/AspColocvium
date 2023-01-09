using Microsoft.AspNetCore.Mvc;
using ProdCalculate.Models;
using System.Diagnostics;

namespace ProdCalculate.Controllers
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

        public IActionResult CalculateFactorial(int n)
        {
            int c = 0;
            c = n * (n + 1) * (2 * n + 1) / 6;
            TaskModel taskModel = new TaskModel { IntN = c };
            return View(taskModel);
        }

        public IActionResult DateCalculate(string date1, string date2)
        {
            DateTime startTime, endTime;
            startTime = Convert.ToDateTime(date1);
            endTime = Convert.ToDateTime(date2);
            int t = (startTime.Second - endTime.Second) + (startTime.Minute - endTime.Minute) * 60 + (startTime.Hour - endTime.Hour)* 3600;
            TaskModel taskModel = new TaskModel { Time = t };
            return View(taskModel);
        }
    }
}