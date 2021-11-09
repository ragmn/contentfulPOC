using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contentful.Core;
using Contentful.Core.Search;
using contentfulPOC.Models;

namespace contentfulPOC.Controllers
{
    public class LessonsController : Controller
    {
        private readonly IContentfulClient _client;
        public LessonsController(IContentfulClient client)
        {
            _client = client;
        }
        public async Task<IActionResult> Index()
        {
            var qb = QueryBuilder<Lesson>.New.ContentTypeIs("lesson");
            var a = await _client.GetEntries(qb);
            return View(a);
        }
    }
}
