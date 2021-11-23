using System.Diagnostics;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc;
using movieAPP.Models;

namespace movieAPP.Controllers

{
    public class HomeController : Controller
    {



        // public string Index()
        // {
        //     return "This is my default action...";
        // }
        public IActionResult Index()
        {
            return View();
        }


        // public string Welcome( string name , int ID = 1)
        // {
        //     // return "This is the Welcome action method...";
        //     // return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        //     return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        // }
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}
