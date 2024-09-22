using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Entities;

namespace TravelTripProject.Controllers
{
    public class BlogController : Controller
    {
        Context context = new Context();
        BlogComment blogComment = new BlogComment();

        public ActionResult Index()
        {
            //var blogs = context.Blogs.ToList();
            blogComment.Value1 = context.Blogs.ToList();
            blogComment.Value3 = context.Blogs.OrderByDescending(x => x.BlogID).Take(3).ToList();
            return View(blogComment);
        }

        public ActionResult BlogDetail(int id)
        {
            //var blog = context.Blogs.Where(x => x.BlogID == id).ToList();
            blogComment.Value1 = context.Blogs.Where(x => x.BlogID == id).ToList();
            blogComment.Value2 = context.Comments.Where(x => x.BlogID == id).ToList();
            return View(blogComment);
        }

        [HttpGet]
        public PartialViewResult MakeComment(int id)
        {
            ViewBag.value = id;
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult MakeComment(Comment comment)
        {
            context.Comments.Add(comment);
            context.SaveChanges();
            return PartialView();
        }
    }
}