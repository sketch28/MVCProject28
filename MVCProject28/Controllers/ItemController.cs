using Microsoft.AspNetCore.Mvc;
using MVCProject28.Data;
using MVCProject28.Models;
using System.Collections.Generic;

namespace MVCProject28.Controllers
{
    public class ItemController : Controller
    {
        private readonly ApplicationDbContext _db;
        public ItemController(ApplicationDbContext db)
        {
            _db = db; //LOCAL DATABASE
        }
        public IActionResult Index()
        {
            IEnumerable<Item> objList = _db.Items;
            return View(objList); //Pass this object list to directly view                                                                                         //RETRIVE ITEMS FROM DATABASE
            
        }
        //GET-CREATE
        public IActionResult Create()
        {
                                                                                                    
            return View();
        }
        //POST-CREATE
        [HttpPost]
        [ValidateAntiForgeryToken]      
        public IActionResult Create(Item obj)
        {
            _db.Items.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
