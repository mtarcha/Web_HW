using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MvcApplication1dfasdg.Models
{
    public class ProducerModel
    {
        [Display(Name = "Producer Name")]
        public string Name { get; set; }

        [Display(Name = "The producer's location")]
        public string Location { get; set; }

        public IEnumerable<SelectListItem> Locations { get; set; }
    }
}