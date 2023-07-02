using Itemmanagement.Data;
using Itemmanagement.Models;
using Itemmanagement.Models.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Update.Internal;

namespace Itemmanagement.Controllers
{
  
    public class ItemController : Controller
    {
        private readonly DbItemClass dbitemclass;

        public ItemController(DbItemClass dbitemclass)
        {
            this.dbitemclass = dbitemclass;
        }
        [HttpGet]
        public IActionResult Index()
        {
            {
                var students = dbitemclass.Items.ToList();
                return View(students);

            };
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(AddItem additem)
        {
            var item = new Item()
            {
                Id = Guid.NewGuid(),
                Name = additem.Name,
                Category = additem.Category,
                Delivery = additem.Delivery,
                price= additem.price,
                
            };
            dbitemclass.Items.Add(item);
            dbitemclass.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult View(Guid id)
        {
            var item=dbitemclass.Items.FirstOrDefault(i=>i.Id==id);
            if (item!=null)
            {
                    var viewmodel = new UpdateItem()
                    {
                        Id = item.Id,
                        Name = item.Name,
                        Category = item.Category,
                        Delivery = item.Delivery,
                        price = item.price,
                       
                    };
                return View("View", viewmodel);
            }
            return RedirectToAction("Index");

        }

        }
    }

