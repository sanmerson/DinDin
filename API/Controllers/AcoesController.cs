﻿using Microsoft.AspNetCore.Mvc;

namespace API.Controllers {
    public class AcoesController : Controller {
        public IActionResult Index() {
            return View();
        }
    }
}
