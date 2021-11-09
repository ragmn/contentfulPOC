using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Contentful.Core.Models;
using Microsoft.AspNetCore.Html;
using Newtonsoft.Json;

namespace contentfulPOC.Models
{
    public class Blog
    {
        public string Title{ get; set; }
        public Document Body { get; set; }
        public Asset HeaderImage{ get; set; }
    }
}
