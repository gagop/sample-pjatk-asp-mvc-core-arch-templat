using Microsoft.AspNetCore.Mvc;
using PjatkArchExample.Domain.Entities;
using PjatkArchExample.Domain.Interfaces.Services;
using PjatkArchExample.UI.Models;
using System.Diagnostics;
using System.Threading.Tasks;

namespace PjatkArchExample.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStudentService _service;

        public HomeController(IStudentService service)
        {

            _service = service;

            //TODO simple seed
            _service.AddStudentAsync(new Student
            {
                IdStudent = 1,
                FirstName = "John",
                LastName = "Smith"
            });
            
        }

        public async Task<IActionResult> Index()
        {
            return View(await _service.GetStudentsAsync());
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
