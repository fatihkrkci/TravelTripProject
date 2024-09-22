using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Entities;

namespace TravelTripProject.Controllers
{
    public class AdminController : Controller
    {
        Context context = new Context();

        [Authorize]
        public ActionResult Index()
        {
            var values = context.Blogs.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult NewBlog()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NewBlog(Blog blog)
        {
            context.Blogs.Add(blog);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteBlog(int id)
        {
            var blog = context.Blogs.Find(id);
            context.Blogs.Remove(blog);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult GetBlog(int id)
        {
            var blog = context.Blogs.Find(id);
            return View("GetBlog", blog);
        }

        public ActionResult EditBlog(Blog b)
        {
            var blg = context.Blogs.Find(b.BlogID);
            blg.Description = b.Description;
            blg.Title = b.Title;
            blg.ImageURL = b.ImageURL;
            blg.CreatedAt = b.CreatedAt;
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult CommentList()
        {
            var comments = context.Comments.ToList();
            return View(comments);
        }

        public ActionResult DeleteComment(int id)
        {
            var comment = context.Comments.Find(id);
            context.Comments.Remove(comment);
            context.SaveChanges();
            return RedirectToAction("CommentList");
        }

        public ActionResult GetComment(int id)
        {
            var comment = context.Comments.Find(id);
            return View("GetComment", comment);
        }

        public ActionResult EditComment(Comment y)
        {
            var yrm = context.Comments.Find(y.CommentID);
            yrm.Username= y.Username;
            yrm.Email = y.Email;
            yrm.FullComment = y.FullComment;
            context.SaveChanges();
            return RedirectToAction("CommentList");
        }
    }
}