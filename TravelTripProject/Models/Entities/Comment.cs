using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProject.Models.Entities
{
    public class Comment
    {
        [Key]
        public int CommentID { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string FullComment { get; set; }

        public Blog Blog { get; set; }
    }
}