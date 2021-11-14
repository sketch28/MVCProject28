using Microsoft.AspNetCore.Mvc;
using System;


namespace MVCProject28.Controllers
{
    public class AppointmentController : Controller
    {
        public IActionResult Index()
        {
             return View();
            //string todaysDate = DateTime.Now.ToLongDateString();
            //return Ok(todaysDate);
        }


        public IActionResult Details(int id)
        {
            return Ok("You have entered id =" + id);
        }
    }
}
