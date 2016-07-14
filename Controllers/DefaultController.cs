using HandlebarsMvcGettingStarted.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HandlebarsMvcGettingStarted.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            ViewBag.HtmlHeadline = "<h1>Handlebars HTML Headline</h1>";
            ViewBag.Article = new Article();
            return View();
        }
    }
}