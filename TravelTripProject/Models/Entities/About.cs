using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProject.Models.Entities
{
    public class About
    {
        [Key]
        public int AboutID { get; set; }
        public string ImageURL { get; set; }
        public string Description { get; set; }
    }
}