using Microsoft.AspNetCore.Mvc;

namespace API.Controllers {
    public class SaidasController : Controller {
        public IActionResult Index() {
            return View();
        }
    }
}
