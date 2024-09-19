using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProject.Models.Entities
{
    public class Home
    {
        [Key]
        public int HomeID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}