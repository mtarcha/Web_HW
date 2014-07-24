using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1dfasdg.Models
{
    public class ProductsModel
    {
        [Display(Name = "Producer Name")]
        public string Name { get; set; }

        [Display(Name = "Producer")]
        public string Producer { get; set; }

        public IEnumerable<SelectListItem> Producers { get; set; }

        [Display(Name = "Count")]
        public int Count { get; set; }

        [Display(Name = "Price")]
        public int Price { get; set; }
    }
}