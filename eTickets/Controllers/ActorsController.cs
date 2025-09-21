﻿using eTickets.Data;
using eTickets.Models;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
    public class ActorsController : Controller
    {
        private readonly AppDbContext _context;

        public ActorsController(AppDbContext context)
        {
                _context = context;
        }
        public IActionResult Index()
        {
            var actors= _context.Actors.ToList();
            return View(actors);
        }
    }
}
