using Microsoft.AspNetCore.Mvc;

namespace API.Controllers {
    public class EconomiasController : Controller {
        public IActionResult Index() {
            return View();
        }
    }
}
