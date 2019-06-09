using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PDK.Catering.WebUI.Controllers
{
    public class SecureController : Controller
    {
        [Authorize]
        public string Index()
        {
            return "View()";
        }
    }
}