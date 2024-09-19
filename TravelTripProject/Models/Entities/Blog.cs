using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProject.Models.Entities
{
    public class Blog
    {
        [Key]
        public int BlogID { get; set; }
        public string Title { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }

        public ICollection<Comment> Comments { get; set; }
    }
}