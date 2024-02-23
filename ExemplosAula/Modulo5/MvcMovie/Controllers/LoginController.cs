using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Data;
using MvcMovie.Data.Security;
using MvcMovie.Models;

namespace MvcMovie.Controllers;

public class LoginController : Controller
{
    private readonly MvcMovieContext _context;
    public LoginController(MvcMovieContext context)
    {
        _context = context;
    }
       // GET: Login/Index
    public IActionResult Index()
   {
      return View();
   }
}
