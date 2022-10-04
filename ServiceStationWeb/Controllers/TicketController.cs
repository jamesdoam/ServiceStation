using Microsoft.AspNetCore.Mvc;
using ServiceStationWeb.Data;

namespace ServiceStationWeb.Controllers
{
    public class TicketController : Controller
    {
        private readonly ApplicationDbContext _db;

        public TicketController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var objTicketList = _db.Tickets.ToList();
            return View();
        }
    }
}
