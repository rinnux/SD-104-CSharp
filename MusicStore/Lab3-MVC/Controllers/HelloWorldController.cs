﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MusicStore.Controllers
{
    public class HelloWorldController : Controller
    {
        public string Index()
        {
            return "Hello World, Welcometo the Store!";
        }
        public IActionResult WhiteRAbbit()
        {
            return View();
        }

    }
}