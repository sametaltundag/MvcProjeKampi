using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class IstatistikController : Controller
    {
        Context c = new Context();

        public ActionResult Index()
        {
            ViewBag.TotalCat = c.Categories.Count();
            ViewBag.TotalSoftWrite = c.Headings.Where(x => x.CategoryID == 32).Count();
            ViewBag.WriterInA = c.Writers.Count(x => x.WriterName.Contains("a"));
            ViewBag.MoreCatsHeading = c.Headings.Max(x => x.Category.CategoryName);
            ViewBag.TotalDifferent = c.Categories.Where(x => x.CategoryStatus).Count()
                - c.Categories.Where(x => x.CategoryStatus == false).Count();
            return View();
        }
    }
}