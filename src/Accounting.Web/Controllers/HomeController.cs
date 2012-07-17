using System.Collections.Generic;
using System.Web.Mvc;
using Accounting.Web.Models;

namespace Accounting.Web.Controllers
{
    public class HomeController : Controller
    {
        private static readonly List<Account> _accounts = new List<Account>();
        //
        // GET: /Account/

        public ActionResult Index()
        {
            return View();
        }

    }
}
