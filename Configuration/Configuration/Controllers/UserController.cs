using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Configuration.Controllers
{
    public class UserController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }
    }
}
