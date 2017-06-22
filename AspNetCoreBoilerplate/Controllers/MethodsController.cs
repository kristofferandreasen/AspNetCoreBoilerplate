using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreBoilerplate.Models;

namespace AspNetCoreBoilerplate.Controllers
{
    public class MethodsController : Controller
    {
       
       // Create a local variable for the repository
       private readonly AppDbContext _context;

       // The constructor initalizes the item repository
       public MethodsController(AppDbContext context)
       {
            _context = context;
       }

       public IActionResult HttpData()
       {

            return View(_context.Items.ToList());
        }

        public IActionResult Localjson()
        {
            
            return View();
        }
    }
}
