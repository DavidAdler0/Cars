using Cars.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Cars.Controllers
{
    public class Car : Controller
    {
        private readonly ILogger<Car> _logger;

        public Car(ILogger<Car> logger)
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
        [Route("Car/Model")]
        public IActionResult Model(string model, int year, string color)
        {
            CarModel myCar = new CarModel()
            {
                Model = model,
                Year = year,
                Color = color
            };
            return View(myCar);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
