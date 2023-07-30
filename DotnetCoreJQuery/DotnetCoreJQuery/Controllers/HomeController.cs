using DotnetCoreJQuery.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DotnetCoreJQuery.Controllers
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

        [HttpPost]
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        [HttpPost]
        public int Sub(int num1, int num2)
        {
            return num1 - num2;
        }

        [HttpPost]
        public int Mul(int num1, int num2)
        {
            return num1 * num2;
        }

        [HttpPost]
        public CalculateModel CalculateNumber(int num1, int num2)
        {
            CalculateModel calculateModel = new CalculateModel();

            calculateModel.Add = num1 + num2;    
            calculateModel.Substract = num1 - num2;    
            calculateModel.Multiple = num1 * num2;    
            calculateModel.Division = (double)((decimal) num1 / num2);    
            return calculateModel;
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