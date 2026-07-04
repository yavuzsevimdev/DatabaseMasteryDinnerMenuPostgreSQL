using DatabaseMastery.DinnerMenuPostgreSQL.Services.DashboardServices;
using Microsoft.AspNetCore.Mvc;

namespace DatabaseMastery.DinnerMenuPostgreSQL.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
