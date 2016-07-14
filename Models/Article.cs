using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HandlebarsMvcGettingStarted.Models
{
    public class Article
    {
        public string HtmlBody { get; set; } = "<p>Body</p>";
        public string Excerpt { get; set; } = "<p>Excerpt</p>";
        public string Title { get; set; } = "Title's<>";
    }
}