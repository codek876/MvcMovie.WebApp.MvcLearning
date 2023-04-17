using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using Microsoft.Extensions.Logging;

namespace MvcMovie.Controllers;

//[Route("[controller]")]
public class HelloWorldController : Controller
{
    //Hello World Get
    public IActionResult Index()
    {
        return View();
    }

    //Get: HelloWorld/Welcome
    public IActionResult Welcome(string name, int numTimes = 1)
    {
        ViewData["Message"] = "Hello " + name;
        ViewData["NumTimes"] = numTimes;

        return View();
    }
}
