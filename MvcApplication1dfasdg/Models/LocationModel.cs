using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace MvcApplication1dfasdg.Models
{
    public class LocationModel
    {
        [Display(Name = "Input the produser's location")]
        public string Location { get; set; }
    }
}