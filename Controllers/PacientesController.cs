using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using pacientesPessoas.Models;

namespace pacientesPessoas.Controllers
{
    public class PacientesController : Controller
    {
        private readonly ILogger<PacientesController> logger;

        public PacientesController(ILogger<PacientesController> logger){
            this.logger = logger;
        }

        public IActionResult Index(){
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}