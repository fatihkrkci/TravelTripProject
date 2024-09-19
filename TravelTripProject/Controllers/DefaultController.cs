using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Entities;

namespace TravelTripProject.Controllers
{
    public class DefaultController : Controller
    {
        Context context = new Context();

        public ActionResult Index()
        {
            var values = context.Blogs.OrderByDescending(x => x.BlogID).Take(5).ToList();
            return View(values);
        }

        public PartialViewResult Last2Blogs()
        {
            var values = context.Blogs.OrderByDescending(x => x.BlogID).Take(2).ToList();
            return PartialView(values);
        }

        public PartialViewResult ThirdFromTheLastBlog()
        {
            var values = context.Blogs.Where(x => x.BlogID == 5).ToList();
            return PartialView(values);
        }

        public PartialViewResult Top10Blogs()
        {
            var values = context.Blogs.OrderByDescending(x => x.BlogID).Take(10).ToList();
            return PartialView(values);
        }

        public PartialViewResult OurBestPlaces1()
        {
            var values = context.Blogs.OrderByDescending(x => x.BlogID).Take(3).ToList();
            return PartialView(values);
        }

        public PartialViewResult OurBestPlaces2()
        {
            var values = context.Blogs.OrderBy(x => x.BlogID).Take(3).ToList();
            return PartialView(values);
        }
    }
}