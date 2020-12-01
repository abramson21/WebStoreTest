using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Models;

namespace WebStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration _Configuration;
        private static readonly List<Employee> _Employee = new()
        {
            new Employee() { Id = 1, FirstName = "Иван", LastName = "Иванов", Patronymic = "Иванович", Age = 26 },
            new Employee() { Id = 1, FirstName = "Петр", LastName = "Петров", Patronymic = "Петрович", Age = 28 },
            new Employee() { Id = 1, FirstName = "Сидор", LastName = "Сидоров", Patronymic = "Сидорович", Age = 26 },
        }

        public HomeController(IConfiguration Configuration) => _Configuration = Configuration;
        public IActionResult Index()
        {
            //Обработка данных
            //return Content(_Configuration["ControllerActionText"]);
            return View();
        }

        public IActionResult SecondAction()
        {
            return Content("Second controller");
        }

        public IActionResult Employes()
        {
            return View();
        }
    }

}
