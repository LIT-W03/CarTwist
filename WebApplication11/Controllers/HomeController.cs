using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarTwist.Data;
using WebApplication11.Models;

namespace WebApplication11.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            CarTwistDb db = new CarTwistDb(Properties.Settings.Default.ConStr);
            IEnumerable<Car> cars = db.GetCars();
            HomePageViewModel viewModel = new HomePageViewModel();
            viewModel.Cars = cars;
            return View(viewModel);
        }

        public ActionResult ShowAddForm()
        {
            return View();
        }

        
        public ActionResult AddCar(Car car)
        {
            CarTwistDb db = new CarTwistDb(Properties.Settings.Default.ConStr);
            db.AddCar(car);
            return Redirect("/");
        }

        public ActionResult CheckboxTest()
        {
            return View();
        }

        [HttpPost]
        public void CheckboxTest(bool isGood)
        {
            Response.Write($"<h1>IsGood: ${isGood}</h1>");
        }
    }
}