using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication1dfasdg.Models;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace MvcApplication1dfasdg.Controllers
{
    public class HomeController : Controller
    {
       
        public ActionResult Index()
        {
            var entity = new ProductsEntities();

            var model = new LocationModel();

            /*var prod = entity.Producers.ToList().First(x=>x.Id==1);
            entity.Products.Add(new Product
            {
                Producer = prod,
                Name = "TV",
                Count = 1,
                Price = 10.1m

            });
            /*entity.Locations.Add(new Location
            {
                Name = "Kyiv"
            }
                );*/
            //entity.SaveChanges();
            return View(model);
        }
        [HttpPost]
        public ActionResult Index(FormCollection form)
        {
            var entites = new ProductsEntities();           
           
            entites.Locations.Add(new Location { 
                Name=form["Location"]
            });
            entites.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult ProducerActtion()
        {
            var entity = new ProductsEntities();

            var model = new ProducerModel();

            model.Locations = ConvertEntities(entity.Locations);
            
            return View(model);
        }

        [HttpPost]
        public ActionResult ProducerActtion(FormCollection form2)
        {
            var entity = new ProductsEntities();

           var loc = entity.Locations.ToList().First(x => x.Id == int.Parse(form2["Location"]));
            entity.Producers.Add(new Producer
            {
                Name = form2["Name"],
                Location=loc
            });
            entity.SaveChanges();

            return RedirectToAction("ProducerActtion");
        }

        public ActionResult ProductAction()
        {
            var entity = new ProductsEntities();

            var model = new ProductsModel();

            model.Producers = ConvertEntities(entity.Producers);

            return View(model);
        }

        [HttpPost]
        public ActionResult ProductAction(FormCollection form2)
        {
            var entity = new ProductsEntities();

            var prod = entity.Producers.ToList().First(x => x.Id == int.Parse(form2["Producer"]));
            entity.Products.Add(new Product
            {
                Name = form2["Name"],
                Producer = prod,
                Count = int.Parse(form2["Count"]),
                Price = int.Parse(form2["Price"])
            });
            entity.SaveChanges();

            return RedirectToAction("ProductAction");
        }

        private List<SelectListItem> ConvertEntities(DbSet<Producer> producers)
        {
            var list = new List<SelectListItem>();

            foreach (var producer in producers)
            {
                list.Add(new SelectListItem
                {
                    Text = producer.Name,
                    Value = producer.Id.ToString()
                });
            }

            return list;
        }

        private List<SelectListItem> ConvertEntities(DbSet<Location> locations)
        {
            var list = new List<SelectListItem>();

            foreach (var location in locations)
            {
                list.Add(new SelectListItem
                {
                    Text = location.Name,
                    Value = location.Id.ToString()
                });
            }

            return list;
        }



    }
}
