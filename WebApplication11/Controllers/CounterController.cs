using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication11.Models;

namespace WebApplication11.Controllers
{
    //Name
    //Email
    //PhoneNumber
    //Message
    //WantsNewsletter

    public class CounterController : Controller
    {
        public ActionResult Index()
        {
            int number;
            if (Request.Cookies["number"] != null)
            {
                number = int.Parse(Request.Cookies["number"].Value);
            }
            else
            {
                number = 1;
            }
            Response.Cookies.Add(new HttpCookie("number", $"{number + 1}"));
            CounterViewModel viewModel = new CounterViewModel();
            viewModel.Number = number;
            return View(viewModel);
        }
    }
}