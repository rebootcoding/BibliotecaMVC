using BibliotecaMVC.Filters;
using BibliotecaMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BibliotecaMVC.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Libri()
		{
			return View(Manager.GetBooks());
		}

		public IActionResult AggiungiLibro()
		{
			return View();
		}

		[HttpPost]
		public IActionResult AggiungiLibro(Libro l)
		{
			Manager.AddBook(l);
			return RedirectToAction("Index");
		}

		public IActionResult AggiungiUtente()
		{
			return View();
		}

		[HttpPost]
		public IActionResult AggiungiUtente(Utente u)
		{
			Manager.AddUser(u);
			return RedirectToAction("Index");
		}


        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string Nome, string Cognome, string Password)
        {
            Manager.Login(Nome, Cognome, Password);
            return RedirectToAction("LoginSuccess");
        }

		public IActionResult AccessoStaff()
		{
			return View();
		}

		public IActionResult LoginSuccess()
		{
			return View();
		}

		//Action per prendere in prestito libro
		//[CustomActionFilter]
		//public IActionResult Libri(Utente u, Libro l)
		//{
		//	//Manger.PrendiInPrestito(u, l);
		//	return View();
		//}

		public IActionResult Index()
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