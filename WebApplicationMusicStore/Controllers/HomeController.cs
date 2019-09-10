﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplicationMusicStore.Data;
using WebApplicationMusicStore.Models;

namespace WebApplicationMusicStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Songs.Where(m => m.IsFeatured).ToList());
        }
        public IActionResult Albums()
        {
            return View(_context.Songs.GroupBy(x => x.Album).Select(grp => grp.First()).ToList());
        }
    }
}
