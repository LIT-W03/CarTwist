using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication11.Models;

namespace WebApplication11.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Index()
        {
            ContactViewModel vm = new ContactViewModel();
            if (Request.Cookies["name"] != null && Request.Cookies["email"] != null)
            {
                vm.Name = Request.Cookies["name"].Value;
                vm.Email = Request.Cookies["email"].Value;
            }
            return View(vm);
        }

        [HttpPost]
        public ActionResult Post(string name, string email, string phone, string message, bool wantsNewsLetter)
        {
            //go to db....
            Response.Cookies.Add(new HttpCookie("name", name));
            Response.Cookies.Add(new HttpCookie("email", email));
            return View();
        }
    }
}