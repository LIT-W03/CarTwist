using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CarTwist.Data;

namespace WebApplication11.Models
{
    public class HomePageViewModel
    {
        public IEnumerable<Car> Cars { get; set; }
    }
}